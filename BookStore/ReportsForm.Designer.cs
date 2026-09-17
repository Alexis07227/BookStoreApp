namespace BookStore
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnClientReport = new System.Windows.Forms.Button();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEmployeeListReport = new System.Windows.Forms.Button();
            this.btnSupplierListReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(14, 152);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(855, 410);
            this.dgvReport.TabIndex = 0;
            // 
            // btnClientReport
            // 
            this.btnClientReport.Location = new System.Drawing.Point(14, 15);
            this.btnClientReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientReport.Name = "btnClientReport";
            this.btnClientReport.Size = new System.Drawing.Size(202, 38);
            this.btnClientReport.TabIndex = 1;
            this.btnClientReport.Text = "Статистика клиентов";
            this.btnClientReport.UseVisualStyleBackColor = true;
            this.btnClientReport.Click += new System.EventHandler(this.btnClientReport_Click);
            // 
            // btnStockReport
            // 
            this.btnStockReport.Location = new System.Drawing.Point(223, 15);
            this.btnStockReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(169, 38);
            this.btnStockReport.TabIndex = 2;
            this.btnStockReport.Text = "Остатки книг";
            this.btnStockReport.UseVisualStyleBackColor = true;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(398, 15);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(169, 38);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.Text = "Продажи по дням";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Location = new System.Drawing.Point(675, 15);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(135, 38);
            this.btnExportToExcel.TabIndex = 4;
            this.btnExportToExcel.Text = "Экспорт в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(817, 15);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 38);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(765, 575);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 44);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEmployeeListReport
            // 
            this.btnEmployeeListReport.Location = new System.Drawing.Point(15, 61);
            this.btnEmployeeListReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeListReport.Name = "btnEmployeeListReport";
            this.btnEmployeeListReport.Size = new System.Drawing.Size(245, 38);
            this.btnEmployeeListReport.TabIndex = 7;
            this.btnEmployeeListReport.Text = "Статистика сотрудников";
            this.btnEmployeeListReport.UseVisualStyleBackColor = true;
            this.btnEmployeeListReport.Click += new System.EventHandler(this.btnEmployeeListReport_Click_1);
            // 
            // btnSupplierListReport
            // 
            this.btnSupplierListReport.Location = new System.Drawing.Point(13, 106);
            this.btnSupplierListReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierListReport.Name = "btnSupplierListReport";
            this.btnSupplierListReport.Size = new System.Drawing.Size(248, 38);
            this.btnSupplierListReport.TabIndex = 8;
            this.btnSupplierListReport.Text = "Статистика поставщиков";
            this.btnSupplierListReport.UseVisualStyleBackColor = true;
            this.btnSupplierListReport.Click += new System.EventHandler(this.btnSupplierListReport_Click_1);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 625);
            this.Controls.Add(this.btnSupplierListReport);
            this.Controls.Add(this.btnEmployeeListReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.btnClientReport);
            this.Controls.Add(this.dgvReport);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportsForm";
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnClientReport;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEmployeeListReport;
        private System.Windows.Forms.Button btnSupplierListReport;
    }
}