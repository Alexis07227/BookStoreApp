using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
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
            SetupCart();
            SetupCartColumns();
            LoadBooks();
            RefreshCart();
        }

        private void SetupCartColumns()
        {
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("Title", "Название");
            dgvCart.Columns.Add("Quantity", "Кол-во");
            dgvCart.Columns.Add("Price", "Цена закупки");
            dgvCart.Columns.Add("Subtotal", "Сумма");
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupCart()
        {
            supplyCart.Columns.Clear();
            supplyCart.Columns.Add("BookID", typeof(int));
            supplyCart.Columns.Add("Title", typeof(string));
            supplyCart.Columns.Add("Quantity", typeof(int));
            supplyCart.Columns.Add("Price", typeof(decimal));
            supplyCart.Columns.Add("Subtotal", typeof(decimal));
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
            if (cmbSupplier.SelectedIndex == -1)
            {
                string query = "SELECT BookID, Title, Price FROM Books ORDER BY Title";
                dgvBooks.DataSource = db.ExecuteQuery(query);
            }
            else
            {
                int supplierID = (int)cmbSupplier.SelectedValue;
                string query = @"SELECT DISTINCT b.BookID, b.Title, b.Price 
                         FROM Books b
                         INNER JOIN SupplyDetails sd ON b.BookID = sd.BookID
                         INNER JOIN Supplies s ON sd.SupplyID = s.SupplyID
                         WHERE s.SupplierID = @supplierID
                         ORDER BY b.Title";
                dgvBooks.DataSource = db.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@supplierID", supplierID) });
            }
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvBooks.Columns.Contains("BookID"))
                dgvBooks.Columns["BookID"].Visible = false;
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBooks();
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
                MessageBox.Show("Введите корректную закупочную цену!");
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
            string supplyNumber = "REQ-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            decimal total = 0;
            foreach (DataRow row in supplyCart.Rows)
                total += Convert.ToDecimal(row["Subtotal"]);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // Сохраняем заявку в таблицу SupplyRequests (НЕ обновляем остатки!)
                    string requestQuery = @"INSERT INTO SupplyRequests (RequestNumber, RequestDate, SupplierID, Status, TotalAmount) 
                                           VALUES (@num, GETDATE(), @sid, 'Sent', @total);
                                           SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdRequest = new SqlCommand(requestQuery, conn, tran);
                    cmdRequest.Parameters.AddWithValue("@num", supplyNumber);
                    cmdRequest.Parameters.AddWithValue("@sid", supplierID);
                    cmdRequest.Parameters.AddWithValue("@total", total);
                    int requestID = Convert.ToInt32(cmdRequest.ExecuteScalar());

                    foreach (DataRow row in supplyCart.Rows)
                    {
                        string detailQuery = @"INSERT INTO SupplyRequestDetails (RequestID, BookID, Quantity, PurchasePrice, Subtotal) 
                                               VALUES (@rid, @bid, @qty, @price, @sub)";
                        SqlCommand cmdDetail = new SqlCommand(detailQuery, conn, tran);
                        cmdDetail.Parameters.AddWithValue("@rid", requestID);
                        cmdDetail.Parameters.AddWithValue("@bid", row["BookID"]);
                        cmdDetail.Parameters.AddWithValue("@qty", row["Quantity"]);
                        cmdDetail.Parameters.AddWithValue("@price", row["Price"]);
                        cmdDetail.Parameters.AddWithValue("@sub", row["Subtotal"]);
                        cmdDetail.ExecuteNonQuery();
                    }

                    tran.Commit();

                    // --- Отправка письма поставщику (запрос на поставку) ---
                    if (chkSendEmail.Checked)
                    {
                        string supplierEmail = GetSupplierEmail(supplierID);
                        if (!string.IsNullOrEmpty(supplierEmail))
                        {
                            string subject = $"Запрос на поставку №{supplyNumber}";
                            StringBuilder body = new StringBuilder();
                            body.AppendLine($"<h2>Запрос на поставку №{supplyNumber}</h2>");
                            body.AppendLine($"<p><b>Поставщик:</b> {cmbSupplier.Text}</p>");
                            body.AppendLine($"<p><b>Дата:</b> {DateTime.Now:dd.MM.yyyy HH:mm}</p>");
                            body.AppendLine("<h3>Список товаров:</h3>");
                            body.AppendLine("<table border='1' cellpadding='5'>");
                            body.AppendLine("<tr><th>Книга</th><th>Количество</th><th>Цена закупки</th><th>Сумма</th></tr>");
                            foreach (DataRow row in supplyCart.Rows)
                            {
                                string title = row["Title"].ToString();
                                int qty = Convert.ToInt32(row["Quantity"]);
                                decimal price = Convert.ToDecimal(row["Price"]);
                                decimal sub = Convert.ToDecimal(row["Subtotal"]);
                                body.AppendLine($"<tr><td>{title}</td><td>{qty}</td><td>{price:N2}</td><td>{sub:N2}</td></tr>");
                            }
                            body.AppendLine("</table>");
                            body.AppendLine($"<p><b>Общая сумма:</b> {total:N2} руб.</p>");
                            body.AppendLine("<p>Просьба подтвердить возможность поставки.</p>");
                            EmailHelper.SendEmail(supplierEmail, subject, body.ToString());
                        }
                    }

                    MessageBox.Show($"Заявка на поставку {supplyNumber} создана. Остатки пока не изменены. Ждите подтверждения.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    tran.Rollback();
                    MessageBox.Show("Ошибка при оформлении заявки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetSupplierEmail(int supplierID)
        {
            string query = "SELECT Email FROM Suppliers WHERE SupplierID = @id";
            object result = db.ExecuteScalar(query, new SqlParameter[] { new SqlParameter("@id", supplierID) });
            return result?.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplyForm_Load(object sender, EventArgs e) { }
    }
}