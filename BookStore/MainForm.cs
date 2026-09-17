using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public partial class MainForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            LoadBooks();
            LoadOrders();
            SetPermissions();
        }

        private void SetPermissions()
        {
            string role = Form1.CurrentRole;

            if (role == "Seller")
            {
                добавитьКнигуToolStripMenuItem.Enabled = false;
                редактироватьКнигуToolStripMenuItem.Enabled = false;
                удалитьКнигуToolStripMenuItem.Enabled = false;
                импортExcelToolStripMenuItem.Enabled = false;
                клиентыToolStripMenuItem.Enabled = false;
                поставщикиToolStripMenuItem.Enabled = false;
                приходТовараToolStripMenuItem.Enabled = false;
                новыйЗаказToolStripMenuItem.Enabled = true;
                отменитьЗаказToolStripMenuItem.Enabled = true;
            }
            else if (role == "Accountant")
            {
                добавитьКнигуToolStripMenuItem.Enabled = false;
                редактироватьКнигуToolStripMenuItem.Enabled = false;
                удалитьКнигуToolStripMenuItem.Enabled = false;
                импортExcelToolStripMenuItem.Enabled = false;
                новыйЗаказToolStripMenuItem.Enabled = false;
                отменитьЗаказToolStripMenuItem.Enabled = false;
                клиентыToolStripMenuItem.Enabled = false;
                поставщикиToolStripMenuItem.Enabled = false;
                приходТовараToolStripMenuItem.Enabled = false;
                отчетыToolStripMenuItem.Enabled = true;
                остаткиКнигToolStripMenuItem.Enabled = true;
                продажиПоДнямToolStripMenuItem.Enabled = true;
                статистикаКлиентовToolStripMenuItem.Enabled = true;
                печатьToolStripMenuItem.Enabled = true;
            
            }
        }

        private void LoadBooks()
        {
            string query = "SELECT BookID, Title, Author, PublisherName, Genre, Price, QuantityInStock FROM vw_BooksFullInfo ORDER BY Title";
            dgvBooks.DataSource = db.ExecuteQuery(query);
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvBooks.Columns.Contains("BookID")) dgvBooks.Columns["BookID"].Visible = false;
            if (dgvBooks.Columns.Contains("Title")) dgvBooks.Columns["Title"].HeaderText = "Название";
            if (dgvBooks.Columns.Contains("Author")) dgvBooks.Columns["Author"].HeaderText = "Автор";
            if (dgvBooks.Columns.Contains("PublisherName")) dgvBooks.Columns["PublisherName"].HeaderText = "Издательство";
            if (dgvBooks.Columns.Contains("Genre")) dgvBooks.Columns["Genre"].HeaderText = "Жанр";
            if (dgvBooks.Columns.Contains("Price")) dgvBooks.Columns["Price"].HeaderText = "Цена";
            if (dgvBooks.Columns.Contains("QuantityInStock")) dgvBooks.Columns["QuantityInStock"].HeaderText = "Остаток";
        }

        private void LoadOrders()
        {
            string query = "SELECT OrderID, OrderNumber, OrderDate, ClientName, EmployeeName, FinalAmount, PaymentMethod, Status FROM vw_OrdersFullInfo ORDER BY OrderDate DESC";
            dgvOrders.DataSource = db.ExecuteQuery(query);
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvOrders.Columns.Contains("OrderID")) dgvOrders.Columns["OrderID"].Visible = false;
            if (dgvOrders.Columns.Contains("OrderNumber")) dgvOrders.Columns["OrderNumber"].HeaderText = "№ заказа";
            if (dgvOrders.Columns.Contains("OrderDate")) dgvOrders.Columns["OrderDate"].HeaderText = "Дата";
            if (dgvOrders.Columns.Contains("ClientName")) dgvOrders.Columns["ClientName"].HeaderText = "Клиент";
            if (dgvOrders.Columns.Contains("EmployeeName")) dgvOrders.Columns["EmployeeName"].HeaderText = "Продавец";
            if (dgvOrders.Columns.Contains("FinalAmount")) dgvOrders.Columns["FinalAmount"].HeaderText = "Сумма";
            if (dgvOrders.Columns.Contains("PaymentMethod")) dgvOrders.Columns["PaymentMethod"].HeaderText = "Оплата";
            if (dgvOrders.Columns.Contains("Status")) dgvOrders.Columns["Status"].HeaderText = "Статус";
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            LoadBooks();
            LoadOrders();
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string search = txtSearchBooks.Text.Trim();
            if (string.IsNullOrEmpty(search)) { LoadBooks(); return; }
            string query = "SELECT BookID, Title, Author, PublisherName, Genre, Price, QuantityInStock FROM vw_BooksFullInfo WHERE Title LIKE @search OR Author LIKE @search ORDER BY Title";
            dgvBooks.DataSource = db.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@search", "%" + search + "%") });
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            string search = txtSearchOrders.Text.Trim();
            if (string.IsNullOrEmpty(search)) { LoadOrders(); return; }
            string query = "SELECT OrderID, OrderNumber, OrderDate, ClientName, EmployeeName, FinalAmount, PaymentMethod, Status FROM vw_OrdersFullInfo WHERE OrderNumber LIKE @search OR ClientName LIKE @search ORDER BY OrderDate DESC";
            dgvOrders.DataSource = db.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@search", "%" + search + "%") });
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void добавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addForm = new AddBookForm();
            addForm.ShowDialog();
            LoadBooks();
        }

        private void редактироватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу для редактирования!");
                return;
            }

            int bookID = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
            EditBookForm editForm = new EditBookForm(bookID);
            editForm.ShowDialog();
            LoadBooks();
        }

        private void удалитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу!", "Внимание");
                return;
            }

            int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
            string title = dgvBooks.CurrentRow.Cells["Title"].Value.ToString();

            string checkQuery = "SELECT COUNT(*) FROM OrderDetails WHERE BookID = @id";
            int count = Convert.ToInt32(db.ExecuteScalar(checkQuery, new SqlParameter[] { new SqlParameter("@id", id) }));

            if (count > 0)
            {
                MessageBox.Show($"Нельзя удалить книгу \"{title}\", так как она есть в заказах!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить \"{title}\"?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.ExecuteNonQuery("DELETE FROM Books WHERE BookID = @id", new SqlParameter[] { new SqlParameter("@id", id) });
                LoadBooks();
            }
        }

        private void импортExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel файлы (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Выберите Excel файл с книгами";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (ExcelPackage package = new ExcelPackage(new FileInfo(openFileDialog.FileName)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.Rows;
                        int importedCount = 0;

                        for (int row = 2; row <= rowCount; row++) // 1-я строка — заголовки
                        {
                            string title = worksheet.Cells[row, 1].Text?.Trim();
                            string author = worksheet.Cells[row, 2].Text?.Trim();
                            string publisher = worksheet.Cells[row, 3].Text?.Trim();
                            string priceStr = worksheet.Cells[row, 4].Text?.Trim();
                            string quantityStr = worksheet.Cells[row, 5].Text?.Trim();

                            if (string.IsNullOrEmpty(title)) continue;

                            // ... логика поиска/создания автора и издательства (такая же, как в CSV) ...
                            // (код я опускаю, он у тебя уже есть в старом методе)
                            // Просто скопируй блок с 60 по 120 строки из старого метода
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка импорта: " + ex.Message);
                }
            }
        }

        private void новыйЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm orderForm = new AddOrderForm();
            orderForm.ShowDialog();
            LoadOrders();
            LoadBooks();
        }

        private void отменитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Выберите заказ для отмены!");
                return;
            }

            int orderID = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderID"].Value);
            string orderNumber = dgvOrders.CurrentRow.Cells["OrderNumber"].Value.ToString();
            string status = dgvOrders.CurrentRow.Cells["Status"]?.Value?.ToString() ?? "Completed";

            if (status == "Cancelled")
            {
                MessageBox.Show("Заказ уже отменен!");
                return;
            }

            if (MessageBox.Show($"Отменить заказ {orderNumber}? Остатки книг будут восстановлены.", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string getDetailsQuery = "SELECT BookID, Quantity FROM OrderDetails WHERE OrderID = @oid";
                        SqlCommand cmdDetails = new SqlCommand(getDetailsQuery, conn, tran);
                        cmdDetails.Parameters.AddWithValue("@oid", orderID);
                        DataTable details = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmdDetails);
                        adapter.Fill(details);

                        foreach (DataRow row in details.Rows)
                        {
                            int bookID = Convert.ToInt32(row["BookID"]);
                            int quantity = Convert.ToInt32(row["Quantity"]);
                            string updateStock = "UPDATE Books SET QuantityInStock = QuantityInStock + @qty WHERE BookID = @bid";
                            SqlCommand cmdStock = new SqlCommand(updateStock, conn, tran);
                            cmdStock.Parameters.AddWithValue("@qty", quantity);
                            cmdStock.Parameters.AddWithValue("@bid", bookID);
                            cmdStock.ExecuteNonQuery();
                        }

                        string cancelQuery = "UPDATE Orders SET Status = 'Cancelled' WHERE OrderID = @oid";
                        SqlCommand cmdCancel = new SqlCommand(cancelQuery, conn, tran);
                        cmdCancel.Parameters.AddWithValue("@oid", orderID);
                        cmdCancel.ExecuteNonQuery();

                        string logQuery = "INSERT INTO AuditLog (UserID, ActionType, TableName, RecordID, ActionDate) VALUES (@uid, 'CANCEL_ORDER', 'Orders', @oid, GETDATE())";
                        SqlCommand cmdLog = new SqlCommand(logQuery, conn, tran);
                        cmdLog.Parameters.AddWithValue("@uid", Form1.CurrentUserID);
                        cmdLog.Parameters.AddWithValue("@oid", orderID);
                        cmdLog.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show($"Заказ {orderNumber} отменен. Остатки книг восстановлены.");
                        LoadOrders();
                        LoadBooks();
                    }
                    catch
                    {
                        tran.Rollback();
                        MessageBox.Show("Ошибка при отмене заказа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void приходТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplyForm supplyForm = new SupplyForm();
            supplyForm.ShowDialog();
            LoadBooks();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportForm = new ReportsForm();
            reportForm.ShowDialog();
        }

        private void остаткиКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportForm = new ReportsForm();
            reportForm.ShowDialog();
        }

        private void продажиПоДнямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportForm = new ReportsForm();
            reportForm.ShowDialog();
        }

        private void статистикаКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportForm = new ReportsForm();
            reportForm.ShowDialog();
        }

     

        private void экспортОбеихТаблицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBooks.Rows.Count == 0 && dgvOrders.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта!", "Внимание");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Excel файлы (*.xlsx)|*.xlsx",
                FileName = $"Книжный_магазин_полный_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (var package = new ExcelPackage())
                {
                    var bookSheet = package.Workbook.Worksheets.Add("Книги");
                    for (int i = 0; i < dgvBooks.Columns.Count; i++)
                    {
                        bookSheet.Cells[1, i + 1].Value = dgvBooks.Columns[i].HeaderText;
                        bookSheet.Cells[1, i + 1].Style.Font.Bold = true;
                    }
                    for (int i = 0; i < dgvBooks.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvBooks.Columns.Count; j++)
                        {
                            bookSheet.Cells[i + 2, j + 1].Value = dgvBooks.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }
                    bookSheet.Cells[bookSheet.Dimension.Address].AutoFitColumns();

                    var orderSheet = package.Workbook.Worksheets.Add("Заказы");
                    for (int i = 0; i < dgvOrders.Columns.Count; i++)
                    {
                        orderSheet.Cells[1, i + 1].Value = dgvOrders.Columns[i].HeaderText;
                        orderSheet.Cells[1, i + 1].Style.Font.Bold = true;
                    }
                    for (int i = 0; i < dgvOrders.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvOrders.Columns.Count; j++)
                        {
                            orderSheet.Cells[i + 2, j + 1].Value = dgvOrders.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }
                    orderSheet.Cells[orderSheet.Dimension.Address].AutoFitColumns();

                    package.SaveAs(new FileInfo(saveDialog.FileName));
                }

                MessageBox.Show($"Экспорт завершен!\n{saveDialog.FileName}", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка");
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportForm = new ReportsForm();
            reportForm.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информационная система «Книжный магазин»\nВерсия 1.0\nРазработчик: Эскендарова Снежана\n\nСпециальность: 09.02.07 Информационные системы и программирование", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }


        private void подтвердитьПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmSupplyForm confirmForm = new ConfirmSupplyForm();
            confirmForm.ShowDialog();
        }

     
    }
}