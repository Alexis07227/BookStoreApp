using System.Windows.Forms;

namespace BookStore
{
    partial class AddOrderForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panelBookControls = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panelCart = new System.Windows.Forms.Panel();
            this.lvCart = new System.Windows.Forms.ListView();
            this.panelCartControls = new System.Windows.Forms.Panel();
            // --- Новый чекбокс ---
            this.chkSendEmailOrder = new System.Windows.Forms.CheckBox();
            this.txtPhoneSearch1 = new System.Windows.Forms.TextBox();
            this.cmbClient1 = new System.Windows.Forms.ComboBox();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbGuest = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelBookControls.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.panelCartControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.panelBooks);
            this.splitContainer1.Panel2.Controls.Add(this.panelCart);
            this.splitContainer1.Size = new System.Drawing.Size(1507, 672);
            this.splitContainer1.SplitterDistance = 752;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelBooks
            // 
            this.panelBooks.Controls.Add(this.dgvBooks);
            this.panelBooks.Controls.Add(this.panelBookControls);
            this.panelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooks.Location = new System.Drawing.Point(0, 0);
            this.panelBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(752, 672);
            this.panelBooks.TabIndex = 0;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(752, 572);
            this.dgvBooks.TabIndex = 0;
            // 
            // panelBookControls
            // 
            this.panelBookControls.Controls.Add(this.btnAddToCart);
            this.panelBookControls.Controls.Add(this.txtQuantity);
            this.panelBookControls.Controls.Add(this.lblQuantity);
            this.panelBookControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookControls.Location = new System.Drawing.Point(0, 572);
            this.panelBookControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBookControls.Name = "panelBookControls";
            this.panelBookControls.Size = new System.Drawing.Size(752, 100);
            this.panelBookControls.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(225, 25);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(158, 44);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Добавить в корзину";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(135, 31);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 26);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 35);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(104, 20);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Количество:";
            // 
            // panelCart
            // 
            this.panelCart.Controls.Add(this.lvCart);
            this.panelCart.Controls.Add(this.panelCartControls);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCart.Location = new System.Drawing.Point(0, 0);
            this.panelCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(751, 672);
            this.panelCart.TabIndex = 0;
            // 
            // lvCart
            // 
            this.lvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(0, 0);
            this.lvCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(751, 447);
            this.lvCart.TabIndex = 0;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            // 
            // panelCartControls
            // 
            this.panelCartControls.Controls.Add(this.chkSendEmailOrder);
            this.panelCartControls.Controls.Add(this.txtPhoneSearch1);
            this.panelCartControls.Controls.Add(this.cmbClient1);
            this.panelCartControls.Controls.Add(this.rbClient);
            this.panelCartControls.Controls.Add(this.rbGuest);
            this.panelCartControls.Controls.Add(this.btnCancel);
            this.panelCartControls.Controls.Add(this.btnSaveOrder);
            this.panelCartControls.Controls.Add(this.cmbPaymentMethod);
            this.panelCartControls.Controls.Add(this.lblPayment);
            this.panelCartControls.Controls.Add(this.lblTotal);
            this.panelCartControls.Controls.Add(this.btnRemoveFromCart);
            this.panelCartControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCartControls.Location = new System.Drawing.Point(0, 447);
            this.panelCartControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCartControls.Name = "panelCartControls";
            this.panelCartControls.Size = new System.Drawing.Size(751, 225);
            this.panelCartControls.TabIndex = 1;
            // 
            // chkSendEmailOrder
            // 
            this.chkSendEmailOrder.AutoSize = true;
            this.chkSendEmailOrder.Enabled = false;
            this.chkSendEmailOrder.Location = new System.Drawing.Point(476, 93);
            this.chkSendEmailOrder.Name = "chkSendEmailOrder";
            this.chkSendEmailOrder.Size = new System.Drawing.Size(260, 24);
            this.chkSendEmailOrder.TabIndex = 13;
            this.chkSendEmailOrder.Text = "Отправить подтверждение клиенту";
            this.chkSendEmailOrder.UseVisualStyleBackColor = true;
            this.chkSendEmailOrder.Checked = false;
            // 
            // txtPhoneSearch1
            // 
            this.txtPhoneSearch1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPhoneSearch1.Location = new System.Drawing.Point(476, 27);
            this.txtPhoneSearch1.Name = "txtPhoneSearch1";
            this.txtPhoneSearch1.Size = new System.Drawing.Size(200, 26);
            this.txtPhoneSearch1.TabIndex = 3;
            this.txtPhoneSearch1.Text = "Поиск по телефону";
            // 
            // cmbClient1
            // 
            this.cmbClient1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient1.FormattingEnabled = true;
            this.cmbClient1.Location = new System.Drawing.Point(476, 59);
            this.cmbClient1.Name = "cmbClient1";
            this.cmbClient1.Size = new System.Drawing.Size(200, 28);
            this.cmbClient1.TabIndex = 12;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(169, 100);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(245, 24);
            this.rbClient.TabIndex = 11;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Клиент (выбрать из списка)";
            this.rbClient.UseVisualStyleBackColor = true;
            // 
            // rbGuest
            // 
            this.rbGuest.AutoSize = true;
            this.rbGuest.Location = new System.Drawing.Point(169, 59);
            this.rbGuest.Name = "rbGuest";
            this.rbGuest.Size = new System.Drawing.Size(227, 24);
            this.rbGuest.TabIndex = 10;
            this.rbGuest.TabStop = true;
            this.rbGuest.Text = "Гость (быстрая продажа)";
            this.rbGuest.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 175);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 44);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(79, 175);
            this.btnSaveOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(135, 44);
            this.btnSaveOrder.TabIndex = 8;
            this.btnSaveOrder.Text = "Оформить заказ";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Наличные",
            "Карта",
            "Онлайн"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(169, 138);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(168, 28);
            this.cmbPaymentMethod.TabIndex = 7;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(22, 141);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(129, 20);
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = "Способ оплаты:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(22, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Итого: 0 руб.";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(225, 6);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(191, 38);
            this.btnRemoveFromCart.TabIndex = 1;
            this.btnRemoveFromCart.Text = "Удалить из корзины";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 672);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrderForm";
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelBookControls.ResumeLayout(false);
            this.panelBookControls.PerformLayout();
            this.panelCart.ResumeLayout(false);
            this.panelCartControls.ResumeLayout(false);
            this.panelCartControls.PerformLayout();
            this.ResumeLayout(false);
        }

        // Объявление всех элементов управления
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panelBookControls;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.Panel panelCartControls;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbGuest;
        private System.Windows.Forms.ComboBox cmbClient1;
        private System.Windows.Forms.TextBox txtPhoneSearch1;
        private System.Windows.Forms.CheckBox chkSendEmailOrder; // новый элемент
    }
}