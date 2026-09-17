using System;
using System.Windows.Forms;

namespace BookStore
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.DataGridView dgvReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnClientReport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientReport
            // 
            this.btnClientReport.Location = new System.Drawing.Point(1068, 18);
            this.btnClientReport.Name = "btnClientReport";
            this.btnClientReport.Size = new System.Drawing.Size(120, 40);
            this.btnClientReport.TabIndex = 0;
            this.btnClientReport.Text = "Клиенты (статистика)";
            this.btnClientReport.Click += new System.EventHandler(this.btnClientReport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(736, 18);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 62);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Печать";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(525, 18);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(180, 62);
            this.btnExportToExcel.TabIndex = 1;
            this.btnExportToExcel.Text = "Экспорт в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeight = 34;
            this.dgvReport.Location = new System.Drawing.Point(18, 108);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 62;
            this.dgvReport.Size = new System.Drawing.Size(1140, 615);
            this.dgvReport.TabIndex = 0;
            // 
            // btnStockReport
            // 
            this.btnStockReport.Location = new System.Drawing.Point(18, 18);
            this.btnStockReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(225, 62);
            this.btnStockReport.TabIndex = 1;
            this.btnStockReport.Text = "Остатки книг";
            this.btnStockReport.UseVisualStyleBackColor = true;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(270, 18);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(225, 62);
            this.btnSalesReport.TabIndex = 2;
            this.btnSalesReport.Text = "Продажи по дням";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 769);
            this.Controls.Add(this.btnClientReport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.dgvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчеты - Книжный магазин";
     
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        private void BtnStockReport_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT Title, QuantityInStock, Price FROM vw_BookStock ORDER BY QuantityInStock DESC";
            dgvReport.DataSource = db.ExecuteQuery(query);
        }

        private void BtnSalesReport_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = @"SELECT FORMAT(OrderDate, 'yyyy-MM-dd') AS Дата, COUNT(*) AS Количество, SUM(FinalAmount) AS Выручка 
                             FROM Orders WHERE Status = 'Completed' GROUP BY FORMAT(OrderDate, 'yyyy-MM-dd') ORDER BY Дата DESC";
            dgvReport.DataSource = db.ExecuteQuery(query);
        }





        private Button btnExportToExcel;


        private Button btnPrint;
        private Button btnClientReport;
    }
}