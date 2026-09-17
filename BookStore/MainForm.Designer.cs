namespace BookStore
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panelBooksSearch = new System.Windows.Forms.Panel();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.lblSearchBooks = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelOrdersSearch = new System.Windows.Forms.Panel();
            this.btnSearchOrders = new System.Windows.Forms.Button();
            this.txtSearchOrders = new System.Windows.Forms.TextBox();
            this.lblSearchOrders = new System.Windows.Forms.Label();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.подтвердитьПоставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelBooksSearch.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelOrdersSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКнигуToolStripMenuItem,
            this.редактироватьКнигуToolStripMenuItem,
            this.удалитьКнигуToolStripMenuItem,
            this.импортExcelToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.книгиToolStripMenuItem.Text = "Книги";
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
            this.приходТовараToolStripMenuItem,
            this.подтвердитьПоставкиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // приходТовараToolStripMenuItem
            // 
            this.приходТовараToolStripMenuItem.Name = "приходТовараToolStripMenuItem";
            this.приходТовараToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.приходТовараToolStripMenuItem.Text = "Приход товара";
            this.приходТовараToolStripMenuItem.Click += new System.EventHandler(this.приходТовараToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остаткиКнигToolStripMenuItem,
            this.продажиПоДнямToolStripMenuItem,
            this.статистикаКлиентовToolStripMenuItem});
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
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelBooks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelOrders);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 929);
            this.splitContainer1.SplitterDistance = 464;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelBooks
            // 
            this.panelBooks.Controls.Add(this.dgvBooks);
            this.panelBooks.Controls.Add(this.panelBooksSearch);
            this.panelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooks.Location = new System.Drawing.Point(0, 0);
            this.panelBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(1350, 464);
            this.panelBooks.TabIndex = 0;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 50);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(1350, 414);
            this.dgvBooks.TabIndex = 1;
            // 
            // panelBooksSearch
            // 
            this.panelBooksSearch.Controls.Add(this.btnSearchBooks);
            this.panelBooksSearch.Controls.Add(this.txtSearchBooks);
            this.panelBooksSearch.Controls.Add(this.lblSearchBooks);
            this.panelBooksSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBooksSearch.Location = new System.Drawing.Point(0, 0);
            this.panelBooksSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBooksSearch.Name = "panelBooksSearch";
            this.panelBooksSearch.Size = new System.Drawing.Size(1350, 50);
            this.panelBooksSearch.TabIndex = 0;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(394, 10);
            this.btnSearchBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(112, 31);
            this.btnSearchBooks.TabIndex = 2;
            this.btnSearchBooks.Text = "Поиск";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Location = new System.Drawing.Point(90, 10);
            this.txtSearchBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(292, 26);
            this.txtSearchBooks.TabIndex = 1;
            // 
            // lblSearchBooks
            // 
            this.lblSearchBooks.AutoSize = true;
            this.lblSearchBooks.Location = new System.Drawing.Point(11, 15);
            this.lblSearchBooks.Name = "lblSearchBooks";
            this.lblSearchBooks.Size = new System.Drawing.Size(59, 20);
            this.lblSearchBooks.TabIndex = 0;
            this.lblSearchBooks.Text = "Поиск:";
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.dgvOrders);
            this.panelOrders.Controls.Add(this.panelOrdersSearch);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(1350, 460);
            this.panelOrders.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 50);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1350, 410);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // panelOrdersSearch
            // 
            this.panelOrdersSearch.Controls.Add(this.btnSearchOrders);
            this.panelOrdersSearch.Controls.Add(this.txtSearchOrders);
            this.panelOrdersSearch.Controls.Add(this.lblSearchOrders);
            this.panelOrdersSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdersSearch.Location = new System.Drawing.Point(0, 0);
            this.panelOrdersSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelOrdersSearch.Name = "panelOrdersSearch";
            this.panelOrdersSearch.Size = new System.Drawing.Size(1350, 50);
            this.panelOrdersSearch.TabIndex = 0;
            // 
            // btnSearchOrders
            // 
            this.btnSearchOrders.Location = new System.Drawing.Point(394, 10);
            this.btnSearchOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchOrders.Name = "btnSearchOrders";
            this.btnSearchOrders.Size = new System.Drawing.Size(112, 31);
            this.btnSearchOrders.TabIndex = 2;
            this.btnSearchOrders.Text = "Поиск";
            this.btnSearchOrders.UseVisualStyleBackColor = true;
            this.btnSearchOrders.Click += new System.EventHandler(this.btnSearchOrders_Click);
            // 
            // txtSearchOrders
            // 
            this.txtSearchOrders.Location = new System.Drawing.Point(90, 10);
            this.txtSearchOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchOrders.Name = "txtSearchOrders";
            this.txtSearchOrders.Size = new System.Drawing.Size(292, 26);
            this.txtSearchOrders.TabIndex = 1;
            // 
            // lblSearchOrders
            // 
            this.lblSearchOrders.AutoSize = true;
            this.lblSearchOrders.Location = new System.Drawing.Point(11, 15);
            this.lblSearchOrders.Name = "lblSearchOrders";
            this.lblSearchOrders.Size = new System.Drawing.Size(59, 20);
            this.lblSearchOrders.TabIndex = 0;
            this.lblSearchOrders.Text = "Поиск:";
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshAll.Location = new System.Drawing.Point(1226, 919);
            this.btnRefreshAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(112, 38);
            this.btnRefreshAll.TabIndex = 2;
            this.btnRefreshAll.Text = "Обновить";
            this.btnRefreshAll.UseVisualStyleBackColor = true;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // подтвердитьПоставкиToolStripMenuItem
            // 
            this.подтвердитьПоставкиToolStripMenuItem.Name = "подтвердитьПоставкиToolStripMenuItem";
            this.подтвердитьПоставкиToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.подтвердитьПоставкиToolStripMenuItem.Text = "Подтвердить поставки";
            this.подтвердитьПоставкиToolStripMenuItem.Click += new System.EventHandler(this.подтвердитьПоставкиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 962);
            this.Controls.Add(this.btnRefreshAll);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Книжный магазин";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelBooksSearch.ResumeLayout(false);
            this.panelBooksSearch.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelOrdersSearch.ResumeLayout(false);
            this.panelOrdersSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остаткиКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиПоДнямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.Panel panelBooksSearch;
        private System.Windows.Forms.Label lblSearchBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelOrdersSearch;
        private System.Windows.Forms.Label lblSearchOrders;
        private System.Windows.Forms.Button btnSearchOrders;
        private System.Windows.Forms.TextBox txtSearchOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.ToolStripMenuItem подтвердитьПоставкиToolStripMenuItem;
    }
}