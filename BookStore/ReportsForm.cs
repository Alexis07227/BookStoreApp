using OfficeOpenXml;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ReportsForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public ReportsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Отчеты - Книжный магазин";
        }

        // --- ОТЧЁТЫ ---

        // 1. Остатки книг
        private void btnStockReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT Title AS Название, QuantityInStock AS Остаток, Price AS Цена FROM vw_BookStock ORDER BY QuantityInStock DESC";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 2. Продажи по дням
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
                                FORMAT(OrderDate, 'yyyy-MM-dd') AS Дата,
                                COUNT(*) AS Количество,
                                SUM(FinalAmount) AS Выручка
                            FROM Orders 
                            WHERE Status = 'Completed'
                            GROUP BY FORMAT(OrderDate, 'yyyy-MM-dd')
                            ORDER BY Дата DESC";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 3. Статистика клиентов
        private void btnClientReport_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
                                LastName + ' ' + FirstName AS Клиент,
                                Phone AS Телефон,
                                DiscountPercent AS Скидка,
                                COUNT(o.OrderID) AS Покупок,
                                ISNULL(SUM(o.FinalAmount), 0) AS Сумма
                            FROM Clients c
                            LEFT JOIN Orders o ON c.ClientID = o.ClientID
                            GROUP BY c.ClientID, LastName, FirstName, Phone, DiscountPercent
                            ORDER BY Сумма DESC";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 4. Отчёт по заявкам на поставку (новый)
        private void btnSupplyReport_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
                                sr.RequestNumber AS '№ заявки',
                                sr.RequestDate AS 'Дата',
                                s.SupplierName AS 'Поставщик',
                                sr.Status AS 'Статус',
                                sr.TotalAmount AS 'Сумма'
                            FROM SupplyRequests sr
                            INNER JOIN Suppliers s ON sr.SupplierID = s.SupplierID
                            ORDER BY sr.RequestDate DESC";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 5. Отчёт по клиентам (справочник)
        private void btnClientsListReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT LastName + ' ' + FirstName AS Клиент, Phone AS Телефон, DiscountPercent AS Скидка FROM Clients";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 6. Отчёт по сотрудникам
        private void btnEmployeesReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT LastName + ' ' + FirstName AS Сотрудник, Position AS Должность FROM Employees";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 7. Отчёт по поставщикам (справочник)
        private void btnSuppliersListReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT SupplierName AS Поставщик, Phone AS Телефон, Email FROM Suppliers";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --- ЭКСПОРТ В EXCEL ---
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null || dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта. Сначала сформируйте отчет.", "Внимание");
                return;
            }

            string fileName = "Отчет";
            if (dgvReport.Columns.Contains("Название") && dgvReport.Columns.Contains("Остаток"))
                fileName = "Остатки_книг";
            else if (dgvReport.Columns.Contains("Дата") && dgvReport.Columns.Contains("Выручка"))
                fileName = "Продажи";
            else if (dgvReport.Columns.Contains("Клиент") && dgvReport.Columns.Contains("Покупок"))
                fileName = "Статистика_клиентов";
            else if (dgvReport.Columns.Contains("№ заявки"))
                fileName = "Заявки_на_поставку";
            else if (dgvReport.Columns.Contains("Сотрудник"))
                fileName = "Сотрудники";
            else if (dgvReport.Columns.Contains("Поставщик"))
                fileName = "Поставщики";

            ExportHelper.ExportToCsv(dgvReport, fileName);
        }

        // --- ПЕЧАТЬ ---
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для печати!", "Внимание");
                return;
            }

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                int y = 100;
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                Font headerFont = new Font("Arial", 12, FontStyle.Bold);
                Font cellFont = new Font("Arial", 10);

                ev.Graphics.DrawString("Отчет по книжному магазину", titleFont, Brushes.Black, 200, 50);

                for (int i = 0; i < dgvReport.Columns.Count; i++)
                {
                    ev.Graphics.DrawString(dgvReport.Columns[i].HeaderText, headerFont, Brushes.Black, 50 + i * 100, y);
                }
                y += 30;

                for (int i = 0; i < dgvReport.Rows.Count && i < 30; i++)
                {
                    for (int j = 0; j < dgvReport.Columns.Count; j++)
                    {
                        string value = dgvReport.Rows[i].Cells[j].Value?.ToString() ?? "";
                        ev.Graphics.DrawString(value, cellFont, Brushes.Black, 50 + j * 100, y + i * 20);
                    }
                }
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                MessageBox.Show("Печать отправлена!", "Успех");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

  
        private void btnEmployeeListReport_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT LastName + ' ' + FirstName AS Сотрудник, Position AS Должность FROM Employees";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnSupplierListReport_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT SupplierName AS Поставщик, Phone AS Телефон, Email FROM Suppliers";
            dgvReport.DataSource = db.ExecuteQuery(query);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}