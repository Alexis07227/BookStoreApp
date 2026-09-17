using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ConfirmSupplyForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public ConfirmSupplyForm()
        {
            InitializeComponent();
            LoadRequests();
        }

        private void LoadRequests()
        {
            string query = @"SELECT sr.RequestID, sr.RequestNumber, sr.RequestDate, 
                                    s.SupplierName, sr.TotalAmount
                             FROM SupplyRequests sr
                             INNER JOIN Suppliers s ON sr.SupplierID = s.SupplierID
                             WHERE sr.Status = 'Sent'
                             ORDER BY sr.RequestDate DESC";
            dgvRequests.DataSource = db.ExecuteQuery(query);
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvRequests.Columns.Contains("RequestID"))
                dgvRequests.Columns["RequestID"].Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявку для подтверждения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestID = Convert.ToInt32(dgvRequests.CurrentRow.Cells["RequestID"].Value);
            string requestNumber = dgvRequests.CurrentRow.Cells["RequestNumber"].Value.ToString();

            if (MessageBox.Show($"Подтвердить поставку по заявке {requestNumber}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        // 1. Получить детали заявки
                        string detailQuery = "SELECT BookID, Quantity, PurchasePrice, Subtotal FROM SupplyRequestDetails WHERE RequestID = @rid";
                        SqlCommand cmdDetail = new SqlCommand(detailQuery, conn, tran);
                        cmdDetail.Parameters.AddWithValue("@rid", requestID);
                        DataTable details = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmdDetail);
                        adapter.Fill(details);

                        // 2. Обновить остатки книг
                        foreach (DataRow row in details.Rows)
                        {
                            int bookID = Convert.ToInt32(row["BookID"]);
                            int qty = Convert.ToInt32(row["Quantity"]);
                            string updateStock = "UPDATE Books SET QuantityInStock = QuantityInStock + @qty WHERE BookID = @bid";
                            SqlCommand cmdStock = new SqlCommand(updateStock, conn, tran);
                            cmdStock.Parameters.AddWithValue("@qty", qty);
                            cmdStock.Parameters.AddWithValue("@bid", bookID);
                            cmdStock.ExecuteNonQuery();
                        }

                        // 3. Создать запись в таблице Supplies (история)
                        string supplyNumber = "SUP-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        decimal total = 0;
                        foreach (DataRow row in details.Rows)
                            total += Convert.ToDecimal(row["Subtotal"]);

                        // Получить SupplierID из заявки
                        string getSupplierQuery = "SELECT SupplierID FROM SupplyRequests WHERE RequestID = @rid";
                        SqlCommand cmdGetSupplier = new SqlCommand(getSupplierQuery, conn, tran);
                        cmdGetSupplier.Parameters.AddWithValue("@rid", requestID);
                        int supplierID = Convert.ToInt32(cmdGetSupplier.ExecuteScalar());

                        string supplyInsert = @"INSERT INTO Supplies (SupplyNumber, SupplyDate, SupplierID, TotalAmount) 
                                                VALUES (@num, GETDATE(), @sid, @total);
                                                SELECT SCOPE_IDENTITY();";
                        SqlCommand cmdSupply = new SqlCommand(supplyInsert, conn, tran);
                        cmdSupply.Parameters.AddWithValue("@num", supplyNumber);
                        cmdSupply.Parameters.AddWithValue("@sid", supplierID);
                        cmdSupply.Parameters.AddWithValue("@total", total);
                        int supplyID = Convert.ToInt32(cmdSupply.ExecuteScalar());

                        // Детали поставки
                        foreach (DataRow row in details.Rows)
                        {
                            string detailInsert = @"INSERT INTO SupplyDetails (SupplyID, BookID, Quantity, PurchasePrice, Subtotal) 
                                                    VALUES (@sid, @bid, @qty, @price, @sub)";
                            SqlCommand cmdDetailInsert = new SqlCommand(detailInsert, conn, tran);
                            cmdDetailInsert.Parameters.AddWithValue("@sid", supplyID);
                            cmdDetailInsert.Parameters.AddWithValue("@bid", row["BookID"]);
                            cmdDetailInsert.Parameters.AddWithValue("@qty", row["Quantity"]);
                            cmdDetailInsert.Parameters.AddWithValue("@price", row["PurchasePrice"]);
                            cmdDetailInsert.Parameters.AddWithValue("@sub", row["Subtotal"]);
                            cmdDetailInsert.ExecuteNonQuery();
                        }

                        // 4. Обновить статус заявки
                        string updateStatus = "UPDATE SupplyRequests SET Status = 'Confirmed' WHERE RequestID = @rid";
                        SqlCommand cmdStatus = new SqlCommand(updateStatus, conn, tran);
                        cmdStatus.Parameters.AddWithValue("@rid", requestID);
                        cmdStatus.ExecuteNonQuery();

                        tran.Commit();

                        MessageBox.Show($"Поставка {supplyNumber} подтверждена и проведена. Остатки обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRequests(); // обновить список
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Ошибка при подтверждении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}