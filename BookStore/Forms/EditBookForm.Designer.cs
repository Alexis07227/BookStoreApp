using System.Windows.Forms;

namespace BookStore
{
    partial class EditBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;

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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.Text = "Редактирование книги";
            this.ClientSize = new System.Drawing.Size(350, 220);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            int y = 20;

            lblTitle.Text = "Название:*";
            lblTitle.Location = new System.Drawing.Point(20, y);
            lblTitle.Size = new System.Drawing.Size(80, 25);
            txtTitle.Location = new System.Drawing.Point(110, y);
            txtTitle.Size = new System.Drawing.Size(200, 23);
            y += 40;

            lblPrice.Text = "Цена:*";
            lblPrice.Location = new System.Drawing.Point(20, y);
            lblPrice.Size = new System.Drawing.Size(80, 25);
            txtPrice.Location = new System.Drawing.Point(110, y);
            txtPrice.Size = new System.Drawing.Size(100, 23);
            y += 40;

            lblQuantity.Text = "Количество:*";
            lblQuantity.Location = new System.Drawing.Point(20, y);
            lblQuantity.Size = new System.Drawing.Size(80, 25);
            txtQuantity.Location = new System.Drawing.Point(110, y);
            txtQuantity.Size = new System.Drawing.Size(100, 23);
            y += 45;

            btnSave.Text = "Сохранить";
            btnSave.Location = new System.Drawing.Point(120, y);
            btnSave.Size = new System.Drawing.Size(100, 35);
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtTitle);
            this.Controls.Add(lblPrice);
            this.Controls.Add(txtPrice);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(btnSave);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}