namespace BookStore
{
    partial class SupplyForm
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
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panelBookControls = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panelCart = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panelCartControls = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveSupply = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.chkSendEmail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelBookControls.SuspendLayout();
            this.panelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panelCartControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(22, 25);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(99, 20);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Поставщик:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Location = new System.Drawing.Point(124, 21);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(224, 28);
            this.cmbSupplier.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(22, 62);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelBooks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelCart);
            this.splitContainer1.Size = new System.Drawing.Size(855, 500);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 2;
            // 
            // panelBooks
            // 
            this.panelBooks.Controls.Add(this.dgvBooks);
            this.panelBooks.Controls.Add(this.panelBookControls);
            this.panelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooks.Location = new System.Drawing.Point(0, 0);
            this.panelBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(427, 500);
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
            this.dgvBooks.Size = new System.Drawing.Size(427, 400);
            this.dgvBooks.TabIndex = 0;
            // 
            // panelBookControls
            // 
            this.panelBookControls.Controls.Add(this.btnAddToCart);
            this.panelBookControls.Controls.Add(this.txtPrice);
            this.panelBookControls.Controls.Add(this.lblPrice);
            this.panelBookControls.Controls.Add(this.txtQuantity);
            this.panelBookControls.Controls.Add(this.lblQuantity);
            this.panelBookControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookControls.Location = new System.Drawing.Point(0, 400);
            this.panelBookControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBookControls.Name = "panelBookControls";
            this.panelBookControls.Size = new System.Drawing.Size(427, 100);
            this.panelBookControls.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(248, 25);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(146, 44);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Добавить";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 50);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(11, 54);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена закупки:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(112, 12);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 26);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(11, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(104, 20);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Количество:";
            // 
            // panelCart
            // 
            this.panelCart.Controls.Add(this.dgvCart);
            this.panelCart.Controls.Add(this.panelCartControls);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCart.Location = new System.Drawing.Point(0, 0);
            this.panelCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(424, 500);
            this.panelCart.TabIndex = 0;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(424, 400);
            this.dgvCart.TabIndex = 0;
            // 
            // panelCartControls
            // 
            this.panelCartControls.Controls.Add(this.btnCancel);
            this.panelCartControls.Controls.Add(this.btnSaveSupply);
            this.panelCartControls.Controls.Add(this.lblTotal);
            this.panelCartControls.Controls.Add(this.btnRemoveFromCart);
            this.panelCartControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCartControls.Location = new System.Drawing.Point(0, 400);
            this.panelCartControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCartControls.Name = "panelCartControls";
            this.panelCartControls.Size = new System.Drawing.Size(424, 100);
            this.panelCartControls.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 56);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveSupply
            // 
            this.btnSaveSupply.Location = new System.Drawing.Point(68, 56);
            this.btnSaveSupply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSupply.Name = "btnSaveSupply";
            this.btnSaveSupply.Size = new System.Drawing.Size(135, 38);
            this.btnSaveSupply.TabIndex = 2;
            this.btnSaveSupply.Text = "Оформить поставку";
            this.btnSaveSupply.UseVisualStyleBackColor = true;
            this.btnSaveSupply.Click += new System.EventHandler(this.btnSaveSupply_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(11, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Итого: 0 руб.";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(180, 12);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(135, 38);
            this.btnRemoveFromCart.TabIndex = 1;
            this.btnRemoveFromCart.Text = "Удалить";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // chkSendEmail
            // 
            this.chkSendEmail.AutoSize = true;
            this.chkSendEmail.Checked = true;
            this.chkSendEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendEmail.Location = new System.Drawing.Point(521, 20);
            this.chkSendEmail.Name = "chkSendEmail";
            this.chkSendEmail.Size = new System.Drawing.Size(382, 24);
            this.chkSendEmail.TabIndex = 3;
            this.chkSendEmail.Text = "Отправить уведомление поставщику по email";
            this.chkSendEmail.UseVisualStyleBackColor = true;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 588);
            this.Controls.Add(this.chkSendEmail);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplyForm";
            this.Text = "Приход товара (поставка)";
          
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelBookControls.ResumeLayout(false);
            this.panelBookControls.PerformLayout();
            this.panelCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panelCartControls.ResumeLayout(false);
            this.panelCartControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panelBookControls;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel panelCartControls;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveSupply;
        private System.Windows.Forms.CheckBox chkSendEmail;
    }
}