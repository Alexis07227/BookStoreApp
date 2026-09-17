using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore
{
    public partial class SupplyForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable supplyCart = new DataTable();

        public SupplyForm()
        {
            InitializeComponent();
            LoadSuppliers();
            LoadBooks();
            SetupCart();
        }

        private void SetupCart()
        {
            supplyCart.Columns.Add("BookID", typeof(int));
            supplyCart.Columns.Add("Title", typeof(string));
            supplyCart.Columns.Add("Quantity", typeof(int));
            supplyCart.Columns.Add("Price", typeof(decimal));
            supplyCart.Columns.Add("Subtotal", typeof(decimal));
            RefreshCart();
        }

        private void LoadSuppliers()
        {
            DataTable dt = db.ExecuteQuery("SELECT SupplierID, SupplierName FROM Suppliers ORDER BY SupplierName");
            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";
            cmbSupplier.SelectedIndex = -1;
        }

        private void LoadBooks()
        {
            DataTable dt = db.ExecuteQuery("SELECT BookID, Title, Price FROM Books ORDER BY Title");
            dgvBooks.DataSource = dt;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvBooks.Columns.Contains("BookID"))
                dgvBooks.Columns["BookID"].Visible = false;
        }

        private void RefreshCart()
        {
            dgvCart.Rows.Clear();
            decimal total = 0;
            foreach (DataRow row in supplyCart.Rows)
            {
                dgvCart.Rows.Add(row["Title"], row["Quantity"], row["Price"], row["Subtotal"]);
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            lblTotal.Text = $"Итого: {total:N2} руб.";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите поставщика!");
                return;
            }

            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Введите корректное количество!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену!");
                return;
            }

            int bookID = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
            string title = dgvBooks.CurrentRow.Cells["Title"].Value.ToString();

            DataRow[] existing = supplyCart.Select($"BookID = {bookID}");
            if (existing.Length > 0)
            {
                existing[0]["Quantity"] = (int)existing[0]["Quantity"] + qty;
                existing[0]["Subtotal"] = (int)existing[0]["Quantity"] * (decimal)existing[0]["Price"];
            }
            else
            {
                supplyCart.Rows.Add(bookID, title, qty, price, qty * price);
            }
            RefreshCart();
            txtQuantity.Text = "1";
            txtPrice.Text = "";
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null)
            {
                int index = dgvCart.CurrentRow.Index;
                supplyCart.Rows.RemoveAt(index);
                RefreshCart();
            }
        }

        private void btnSaveSupply_Click(object sender, EventArgs e)
        {
            if (supplyCart.Rows.Count == 0)
            {
                MessageBox.Show("Добавьте товары в поставку!");
                return;
            }

            if (cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите поставщика!");
                return;
            }

            int supplierID = (int)cmbSupplier.SelectedValue;
            string supplyNumber = "SUP-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            decimal total = 0;
            foreach (DataRow row in supplyCart.Rows)
                total += Convert.ToDecimal(row["Subtotal"]);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string supplyQuery = @"INSERT INTO Supplies (SupplyNumber, SupplyDate, SupplierID, TotalAmount) 
                                           VALUES (@num, GETDATE(), @sid, @total);
                                           SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdSupply = new SqlCommand(supplyQuery, conn, tran);
                    cmdSupply.Parameters.AddWithValue("@num", supplyNumber);
                    cmdSupply.Parameters.AddWithValue("@sid", supplierID);
                    cmdSupply.Parameters.AddWithValue("@total", total);
                    int supplyID = Convert.ToInt32(cmdSupply.ExecuteScalar());

                    foreach (DataRow row in supplyCart.Rows)
                    {
                        string detailQuery = @"INSERT INTO SupplyDetails (SupplyID, BookID, Quantity, PurchasePrice, Subtotal) 
                                               VALUES (@sid, @bid, @qty, @price, @sub)";
                        SqlCommand cmdDetail = new SqlCommand(detailQuery, conn, tran);
                        cmdDetail.Parameters.AddWithValue("@sid", supplyID);
                        cmdDetail.Parameters.AddWithValue("@bid", row["BookID"]);
                        cmdDetail.Parameters.AddWithValue("@qty", row["Quantity"]);
                        cmdDetail.Parameters.AddWithValue("@price", row["Price"]);
                        cmdDetail.Parameters.AddWithValue("@sub", row["Subtotal"]);
                        cmdDetail.ExecuteNonQuery();

                        string updateStock = "UPDATE Books SET QuantityInStock = QuantityInStock + @qty WHERE BookID = @bid";
                        SqlCommand cmdStock = new SqlCommand(updateStock, conn, tran);
                        cmdStock.Parameters.AddWithValue("@qty", row["Quantity"]);
                        cmdStock.Parameters.AddWithValue("@bid", row["BookID"]);
                        cmdStock.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show($"Поставка {supplyNumber} оформлена! Остатки книг обновлены.");
                    this.Close();
                }
                catch
                {
                    tran.Rollback();
                    MessageBox.Show("Ошибка при оформлении поставки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обработчик для события Load (нужен дизайнеру)
        private void SupplyForm_Load(object sender, EventArgs e)
        {
            // Пустой обработчик
        }
    }
}