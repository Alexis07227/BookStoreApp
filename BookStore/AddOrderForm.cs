using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddOrderForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable cart = new DataTable();

        public AddOrderForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadBooks();
            LoadClients();
            SetupCart();
            SetupListView();

            rbGuest.Checked = true;
            cmbClient1.Enabled = false;
            txtPhoneSearch1.Enabled = false;
            chkSendEmailOrder.Enabled = false;

            rbGuest.CheckedChanged += rbGuest_CheckedChanged;
            rbClient.CheckedChanged += rbClient_CheckedChanged;
            txtPhoneSearch1.TextChanged += txtPhoneSearch1_TextChanged;
        }

        private void SetupCart()
        {
            cart.Columns.Add("BookID", typeof(int));
            cart.Columns.Add("Title", typeof(string));
            cart.Columns.Add("Quantity", typeof(int));
            cart.Columns.Add("Price", typeof(decimal));
            cart.Columns.Add("Subtotal", typeof(decimal));
        }

        private void SetupListView()
        {
            lvCart.View = View.Details;
            lvCart.Columns.Clear();
            lvCart.Columns.Add("Книга", 250);
            lvCart.Columns.Add("Кол-во", 70);
            lvCart.Columns.Add("Цена", 100);
            lvCart.Columns.Add("Сумма", 100);
            lvCart.FullRowSelect = true;
            lvCart.GridLines = true;
        }

        private void LoadBooks()
        {
            string query = "SELECT BookID, Title, Author, Price, QuantityInStock FROM vw_BooksFullInfo WHERE QuantityInStock > 0 ORDER BY Title";
            DataTable dt = db.ExecuteQuery(query);
            dgvBooks.DataSource = dt;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvBooks.Columns.Contains("BookID")) dgvBooks.Columns["BookID"].Visible = false;
            if (dgvBooks.Columns.Contains("Title")) dgvBooks.Columns["Title"].HeaderText = "Название";
            if (dgvBooks.Columns.Contains("Author")) dgvBooks.Columns["Author"].HeaderText = "Автор";
            if (dgvBooks.Columns.Contains("Price")) dgvBooks.Columns["Price"].HeaderText = "Цена";
            if (dgvBooks.Columns.Contains("QuantityInStock")) dgvBooks.Columns["QuantityInStock"].HeaderText = "Остаток";
        }

        private void LoadClients()
        {
            string query = "SELECT ClientID, LastName + ' ' + FirstName + ' ' + ISNULL(MiddleName, '') AS ClientName FROM Clients ORDER BY LastName";
            DataTable dt = db.ExecuteQuery(query);
            cmbClient1.DataSource = dt;
            cmbClient1.DisplayMember = "ClientName";
            cmbClient1.ValueMember = "ClientID";
            cmbClient1.SelectedIndex = -1;
        }

        private void txtPhoneSearch1_TextChanged(object sender, EventArgs e)
        {
            string phone = txtPhoneSearch1.Text.Trim();
            if (string.IsNullOrEmpty(phone) || phone == "Поиск по телефону")
            {
                LoadClients();
                return;
            }
            string query = "SELECT ClientID, LastName + ' ' + FirstName + ' ' + ISNULL(MiddleName, '') AS ClientName FROM Clients WHERE Phone LIKE @phone ORDER BY LastName";
            DataTable dt = db.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@phone", "%" + phone + "%") });
            cmbClient1.DataSource = dt;
            cmbClient1.DisplayMember = "ClientName";
            cmbClient1.ValueMember = "ClientID";
        }

        private void rbGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGuest.Checked)
            {
                cmbClient1.Enabled = false;
                txtPhoneSearch1.Enabled = false;
                cmbClient1.SelectedIndex = -1;
                txtPhoneSearch1.Text = "Поиск по телефону";
                chkSendEmailOrder.Enabled = false;
                chkSendEmailOrder.Checked = false;
            }
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClient.Checked)
            {
                cmbClient1.Enabled = true;
                txtPhoneSearch1.Enabled = true;
                LoadClients();
                chkSendEmailOrder.Enabled = true;
            }
        }

        private void RefreshCart()
        {
            lvCart.Items.Clear();
            if (cart.Rows.Count == 0)
            {
                lblTotal.Text = "Итого: 0 руб.";
                return;
            }

            foreach (DataRow row in cart.Rows)
            {
                string title = row["Title"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["Price"]);
                decimal subtotal = Convert.ToDecimal(row["Subtotal"]);
                ListViewItem item = new ListViewItem(title);
                item.SubItems.Add(quantity.ToString());
                item.SubItems.Add(price.ToString("N2"));
                item.SubItems.Add(subtotal.ToString("N2"));
                item.Tag = row;
                lvCart.Items.Add(item);
            }
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cart.Rows)
                total += Convert.ToDecimal(row["Subtotal"]);
            lblTotal.Text = $"Итого: {total:N2} руб.";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Введите корректное количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int bookID = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
            string title = dgvBooks.CurrentRow.Cells["Title"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvBooks.CurrentRow.Cells["Price"].Value);
            int stock = Convert.ToInt32(dgvBooks.CurrentRow.Cells["QuantityInStock"].Value);
            if (qty > stock)
            {
                MessageBox.Show($"На складе только {stock} шт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow[] existing = cart.Select($"BookID = {bookID}");
            if (existing.Length > 0)
            {
                existing[0]["Quantity"] = (int)existing[0]["Quantity"] + qty;
                existing[0]["Subtotal"] = (int)existing[0]["Quantity"] * (decimal)existing[0]["Price"];
            }
            else
            {
                cart.Rows.Add(bookID, title, qty, price, qty * price);
            }
            RefreshCart();
            txtQuantity.Text = "1";
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count > 0)
            {
                DataRow row = (DataRow)lvCart.SelectedItems[0].Tag;
                cart.Rows.Remove(row);
                RefreshCart();
            }
            else
            {
                MessageBox.Show("Выберите позицию в корзине!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (cart.Rows.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cmbPaymentMethod.Text))
            {
                MessageBox.Show("Выберите способ оплаты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? clientID = null;
            if (rbClient.Checked && cmbClient1.SelectedIndex != -1)
            {
                clientID = (int)cmbClient1.SelectedValue;
            }

            decimal total = 0;
            foreach (DataRow row in cart.Rows)
                total += Convert.ToDecimal(row["Subtotal"]);

            string orderNumber = "ORD-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string empQuery = "SELECT EmployeeID FROM Users WHERE UserID = @userid";
            object empResult = db.ExecuteScalar(empQuery, new SqlParameter[] { new SqlParameter("@userid", Form1.CurrentUserID) });
            int employeeID = empResult != null ? Convert.ToInt32(empResult) : 1;

            string payment;
            switch (cmbPaymentMethod.Text)
            {
                case "Наличные": payment = "Cash"; break;
                case "Карта": payment = "Card"; break;
                case "Онлайн": payment = "Online"; break;
                default: payment = "Cash"; break;
            }

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string orderQuery = @"INSERT INTO Orders (OrderNumber, OrderDate, ClientID, EmployeeID, TotalAmount, FinalAmount, PaymentMethod, Status) 
                                          VALUES (@num, GETDATE(), @cid, @eid, @total, @total, @pay, 'Completed');
                                          SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdOrder = new SqlCommand(orderQuery, conn, tran);
                    cmdOrder.Parameters.AddWithValue("@num", orderNumber);
                    cmdOrder.Parameters.AddWithValue("@cid", clientID ?? (object)DBNull.Value);
                    cmdOrder.Parameters.AddWithValue("@eid", employeeID);
                    cmdOrder.Parameters.AddWithValue("@total", total);
                    cmdOrder.Parameters.AddWithValue("@pay", payment);
                    int orderID = Convert.ToInt32(cmdOrder.ExecuteScalar());

                    foreach (DataRow row in cart.Rows)
                    {
                        int bookID = Convert.ToInt32(row["BookID"]);
                        int qty = Convert.ToInt32(row["Quantity"]);
                        decimal price = Convert.ToDecimal(row["Price"]);

                        string checkStock = "SELECT QuantityInStock FROM Books WHERE BookID = @bid";
                        SqlCommand cmdCheck = new SqlCommand(checkStock, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@bid", bookID);
                        int stock = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        if (qty > stock)
                            throw new Exception($"Недостаточно товара: {row["Title"]}. Доступно {stock} шт.");

                        string detailQuery = @"INSERT INTO OrderDetails (OrderID, BookID, Quantity, PriceAtSale, Subtotal) 
                                               VALUES (@oid, @bid, @qty, @price, @sub)";
                        SqlCommand cmdDetail = new SqlCommand(detailQuery, conn, tran);
                        cmdDetail.Parameters.AddWithValue("@oid", orderID);
                        cmdDetail.Parameters.AddWithValue("@bid", bookID);
                        cmdDetail.Parameters.AddWithValue("@qty", qty);
                        cmdDetail.Parameters.AddWithValue("@price", price);
                        cmdDetail.Parameters.AddWithValue("@sub", price * qty);
                        cmdDetail.ExecuteNonQuery();

                        string updateStock = "UPDATE Books SET QuantityInStock = QuantityInStock - @qty WHERE BookID = @bid";
                        SqlCommand cmdStock = new SqlCommand(updateStock, conn, tran);
                        cmdStock.Parameters.AddWithValue("@qty", qty);
                        cmdStock.Parameters.AddWithValue("@bid", bookID);
                        cmdStock.ExecuteNonQuery();
                    }

                    tran.Commit();

                    // --- Отправка письма клиенту (если выбран и чекбокс включён) ---
                    if (chkSendEmailOrder.Checked && clientID != null)
                    {
                        string clientEmail = GetClientEmail(clientID.Value);
                        if (!string.IsNullOrEmpty(clientEmail))
                        {
                            string subject = $"Ваш заказ №{orderNumber} оформлен";
                            StringBuilder body = new StringBuilder();
                            body.AppendLine($"<h2>Заказ №{orderNumber}</h2>");
                            body.AppendLine($"<p><b>Дата:</b> {DateTime.Now:dd.MM.yyyy HH:mm}</p>");
                            body.AppendLine("<h3>Список товаров:</h3>");
                            body.AppendLine("<table border='1' cellpadding='5'>");
                            body.AppendLine("<tr><th>Книга</th><th>Количество</th><th>Цена</th><th>Сумма</th></tr>");
                            foreach (DataRow row in cart.Rows)
                            {
                                string title = row["Title"].ToString();
                                int qty = Convert.ToInt32(row["Quantity"]);
                                decimal price = Convert.ToDecimal(row["Price"]);
                                decimal sub = Convert.ToDecimal(row["Subtotal"]);
                                body.AppendLine($"<tr><td>{title}</td><td>{qty}</td><td>{price:N2}</td><td>{sub:N2}</td></tr>");
                            }
                            body.AppendLine("</table>");
                            body.AppendLine($"<p><b>Итого:</b> {total:N2} руб.</p>");
                            EmailHelper.SendEmail(clientEmail, subject, body.ToString());
                        }
                    }

                    MessageBox.Show($"Заказ {orderNumber} оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Ошибка при оформлении заказа:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetClientEmail(int clientID)
        {
            string query = "SELECT Email FROM Clients WHERE ClientID = @id";
            object result = db.ExecuteScalar(query, new SqlParameter[] { new SqlParameter("@id", clientID) });
            return result?.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cart.Rows.Count > 0)
            {
                var result = MessageBox.Show("В корзине есть товары. Закрыть форму?", "Подтверждение",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            this.Close();
        }

        private void txtPhoneSearch_Enter(object sender, EventArgs e)
        {
            if (txtPhoneSearch1.Text == "Поиск по телефону")
                txtPhoneSearch1.Text = "";
        }

        private void AddOrderForm_Load(object sender, EventArgs e) { }
    }
}