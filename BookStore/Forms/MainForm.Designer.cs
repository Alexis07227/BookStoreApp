using System.Windows.Forms;

namespace BookStore
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvBooks;
        private DataGridView dgvOrders;
        private TextBox txtSearchBooks;
        private TextBox txtSearchOrders;
        private Button btnSearchBooks;
        private Button btnSearchOrders;
        private Button btnRefreshAll;
        private Label lblBooks;
        private Label lblOrders;

        // MenuStrip
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private ToolStripMenuItem редактироватьКнигуToolStripMenuItem;
        private ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private ToolStripMenuItem импортExcelToolStripMenuItem;
        private ToolStripMenuItem заказыToolStripMenuItem;
        private ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private ToolStripMenuItem отменитьЗаказToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem приходТовараToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem остаткиКнигToolStripMenuItem;
        private ToolStripMenuItem продажиПоДнямToolStripMenuItem;
        private ToolStripMenuItem статистикаКлиентовToolStripMenuItem;
        private ToolStripMenuItem экспортВExcelToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.txtSearchOrders = new System.Windows.Forms.TextBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.btnSearchOrders = new System.Windows.Forms.Button();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остаткиКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиПоДнямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeight = 34;
            this.dgvBooks.Location = new System.Drawing.Point(18, 123);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.Size = new System.Drawing.Size(1200, 462);
            this.dgvBooks.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeight = 34;
            this.dgvOrders.Location = new System.Drawing.Point(18, 662);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.Size = new System.Drawing.Size(1200, 385);
            this.dgvOrders.TabIndex = 1;
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Location = new System.Drawing.Point(18, 1092);
            this.txtSearchBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(223, 26);
            this.txtSearchBooks.TabIndex = 2;
            // 
            // txtSearchOrders
            // 
            this.txtSearchOrders.Location = new System.Drawing.Point(270, 1092);
            this.txtSearchOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchOrders.Name = "txtSearchOrders";
            this.txtSearchOrders.Size = new System.Drawing.Size(223, 26);
            this.txtSearchOrders.TabIndex = 3;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(50, 1131);
            this.btnSearchBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(150, 46);
            this.btnSearchBooks.TabIndex = 12;
            this.btnSearchBooks.Text = "Поиск книг";
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // btnSearchOrders
            // 
            this.btnSearchOrders.Location = new System.Drawing.Point(309, 1131);
            this.btnSearchOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchOrders.Name = "btnSearchOrders";
            this.btnSearchOrders.Size = new System.Drawing.Size(150, 46);
            this.btnSearchOrders.TabIndex = 11;
            this.btnSearchOrders.Text = "Поиск заказов";
            this.btnSearchOrders.Click += new System.EventHandler(this.btnSearchOrders_Click);
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Location = new System.Drawing.Point(551, 1131);
            this.btnRefreshAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(225, 46);
            this.btnRefreshAll.TabIndex = 10;
            this.btnRefreshAll.Text = "Обновить";
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBooks.Location = new System.Drawing.Point(18, 85);
            this.lblBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(90, 29);
            this.lblBooks.TabIndex = 14;
            this.lblBooks.Text = "Книги";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrders.Location = new System.Drawing.Point(18, 623);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(102, 29);
            this.lblOrders.TabIndex = 13;
            this.lblOrders.Text = "Заказы";
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 33);
            this.menuStrip.TabIndex = 20;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКнигуToolStripMenuItem,
            this.редактироватьКнигуToolStripMenuItem,
            this.удалитьКнигуToolStripMenuItem,
            this.импортExcelToolStripMenuItem});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            this.добавитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКнигуToolStripMenuItem_Click);
            // 
            // редактироватьКнигуToolStripMenuItem
            // 
            this.редактироватьКнигуToolStripMenuItem.Name = "редактироватьКнигуToolStripMenuItem";
            this.редактироватьКнигуToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.редактироватьКнигуToolStripMenuItem.Text = "Редактировать книгу";
            this.редактироватьКнигуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьКнигуToolStripMenuItem_Click);
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            this.удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            this.удалитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            this.удалитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.удалитьКнигуToolStripMenuItem_Click);
            // 
            // импортExcelToolStripMenuItem
            // 
            this.импортExcelToolStripMenuItem.Name = "импортExcelToolStripMenuItem";
            this.импортExcelToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.импортExcelToolStripMenuItem.Text = "Импорт из Excel";
            this.импортExcelToolStripMenuItem.Click += new System.EventHandler(this.импортExcelToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйЗаказToolStripMenuItem,
            this.отменитьЗаказToolStripMenuItem});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            this.новыйЗаказToolStripMenuItem.Click += new System.EventHandler(this.новыйЗаказToolStripMenuItem_Click);
            // 
            // отменитьЗаказToolStripMenuItem
            // 
            this.отменитьЗаказToolStripMenuItem.Name = "отменитьЗаказToolStripMenuItem";
            this.отменитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.отменитьЗаказToolStripMenuItem.Text = "Отменить заказ";
            this.отменитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.отменитьЗаказToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.приходТовараToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // приходТовараToolStripMenuItem
            // 
            this.приходТовараToolStripMenuItem.Name = "приходТовараToolStripMenuItem";
            this.приходТовараToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.приходТовараToolStripMenuItem.Text = "Приход товара";
            this.приходТовараToolStripMenuItem.Click += new System.EventHandler(this.приходТовараToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остаткиКнигToolStripMenuItem,
            this.продажиПоДнямToolStripMenuItem,
            this.статистикаКлиентовToolStripMenuItem,
            this.экспортВExcelToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // остаткиКнигToolStripMenuItem
            // 
            this.остаткиКнигToolStripMenuItem.Name = "остаткиКнигToolStripMenuItem";
            this.остаткиКнигToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.остаткиКнигToolStripMenuItem.Text = "Остатки книг";
            this.остаткиКнигToolStripMenuItem.Click += new System.EventHandler(this.остаткиКнигToolStripMenuItem_Click);
            // 
            // продажиПоДнямToolStripMenuItem
            // 
            this.продажиПоДнямToolStripMenuItem.Name = "продажиПоДнямToolStripMenuItem";
            this.продажиПоДнямToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.продажиПоДнямToolStripMenuItem.Text = "Продажи по дням";
            this.продажиПоДнямToolStripMenuItem.Click += new System.EventHandler(this.продажиПоДнямToolStripMenuItem_Click);
            // 
            // статистикаКлиентовToolStripMenuItem
            // 
            this.статистикаКлиентовToolStripMenuItem.Name = "статистикаКлиентовToolStripMenuItem";
            this.статистикаКлиентовToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.статистикаКлиентовToolStripMenuItem.Text = "Статистика клиентов";
            this.статистикаКлиентовToolStripMenuItem.Click += new System.EventHandler(this.статистикаКлиентовToolStripMenuItem_Click);
            // 
            // экспортВExcelToolStripMenuItem
            // 
            this.экспортВExcelToolStripMenuItem.Name = "экспортВExcelToolStripMenuItem";
            this.экспортВExcelToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.экспортВExcelToolStripMenuItem.Text = "Экспорт в Excel";
            this.экспортВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортВExcelToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1231);
            this.Controls.Add(this.btnRefreshAll);
            this.Controls.Add(this.btnSearchOrders);
            this.Controls.Add(this.btnSearchBooks);
            this.Controls.Add(this.txtSearchOrders);
            this.Controls.Add(this.txtSearchBooks);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Книжный магазин - Главное меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}