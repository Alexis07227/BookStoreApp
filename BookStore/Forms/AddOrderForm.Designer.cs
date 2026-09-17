using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore
{
    partial class AddOrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblPayment;



        private TextBox txtPhoneSearch;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lvCart = new System.Windows.Forms.ListView();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeight = 34;
            this.dgvBooks.Location = new System.Drawing.Point(15, 53);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.Size = new System.Drawing.Size(579, 467);
            this.dgvBooks.TabIndex = 0;
            // 
            // lvCart
            // 
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(617, 53);
            this.lvCart.Margin = new System.Windows.Forms.Padding(4);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(449, 409);
            this.lvCart.TabIndex = 1;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Location = new System.Drawing.Point(617, 547);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(256, 28);
            this.cmbClient.TabIndex = 2;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Online"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(617, 600);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(192, 28);
            this.cmbPaymentMethod.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(15, 547);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(76, 26);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "1";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(116, 544);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(167, 40);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Добавить в корзину";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(116, 593);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(167, 40);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "Удалить из корзины";
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(900, 600);
            this.btnSaveOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(167, 53);
            this.btnSaveOrder.TabIndex = 7;
            this.btnSaveOrder.Text = "Оформить заказ";
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(617, 653);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(171, 29);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Итого: 0 руб.";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBooks.Location = new System.Drawing.Point(15, 27);
            this.lblBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(189, 25);
            this.lblBooks.TabIndex = 4;
            this.lblBooks.Text = "Доступные книги";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCart.Location = new System.Drawing.Point(617, 27);
            this.lblCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(96, 25);
            this.lblCart.TabIndex = 3;
            this.lblCart.Text = "Корзина";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(15, 527);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(104, 20);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Количество:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(617, 527);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(69, 20);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Клиент:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(617, 580);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(71, 20);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Оплата:";
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(617, 493);
            this.txtPhoneSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(256, 26);
            this.txtPhoneSearch.TabIndex = 8;
            this.txtPhoneSearch.Text = "Поиск по телефону";
            this.txtPhoneSearch.TextChanged += new System.EventHandler(this.txtPhoneSearch_TextChanged);
            this.txtPhoneSearch.Enter += new System.EventHandler(this.txtPhoneSearch_Enter);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 707);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.lvCart);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.txtPhoneSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
    
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}