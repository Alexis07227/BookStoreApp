using System;
using System.Windows.Forms;

namespace BookStore
{
    partial class AddBookForm
    {
        private TextBox txtISBN; private TextBox txtTitle; private TextBox txtGenre;
        private TextBox txtPrice; private TextBox txtQuantity; private TextBox txtDescription;
        private ComboBox cmbAuthor; private ComboBox cmbPublisher; private NumericUpDown numYear;
        private Button btnSave; private Label lblISBN; private Label lblTitle; private Label lblAuthor;
        private Label lblPublisher; private Label lblYear; private Label lblGenre; private Label lblPrice;
        private Label lblQuantity; private Label lblDescription;

        private void InitializeComponent()
        {
            this.txtISBN = new TextBox(); this.txtTitle = new TextBox(); this.txtGenre = new TextBox();
            this.txtPrice = new TextBox(); this.txtQuantity = new TextBox(); this.txtDescription = new TextBox();
            this.cmbAuthor = new ComboBox(); this.cmbPublisher = new ComboBox(); this.numYear = new NumericUpDown();
            this.btnSave = new Button(); this.lblISBN = new Label(); this.lblTitle = new Label();
            this.lblAuthor = new Label(); this.lblPublisher = new Label(); this.lblYear = new Label();
            this.lblGenre = new Label(); this.lblPrice = new Label(); this.lblQuantity = new Label();
            this.lblDescription = new Label(); ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();

            this.Text = "Добавление книги"; this.ClientSize = new System.Drawing.Size(500, 450);
            this.StartPosition = FormStartPosition.CenterScreen; this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            int y = 20;
            lblISBN.Text = "ISBN:"; lblISBN.Location = new System.Drawing.Point(20, y); lblISBN.Size = new System.Drawing.Size(80, 25);
            txtISBN.Location = new System.Drawing.Point(120, y); txtISBN.Size = new System.Drawing.Size(350, 23); y += 35;

            lblTitle.Text = "Название:*"; lblTitle.Location = new System.Drawing.Point(20, y);
            txtTitle.Location = new System.Drawing.Point(120, y); txtTitle.Size = new System.Drawing.Size(350, 23); y += 35;

            lblAuthor.Text = "Автор:"; lblAuthor.Location = new System.Drawing.Point(20, y);
            cmbAuthor.Location = new System.Drawing.Point(120, y); cmbAuthor.Size = new System.Drawing.Size(350, 23); y += 35;

            lblPublisher.Text = "Издательство:"; lblPublisher.Location = new System.Drawing.Point(20, y);
            cmbPublisher.Location = new System.Drawing.Point(120, y); cmbPublisher.Size = new System.Drawing.Size(350, 23); y += 35;

            lblYear.Text = "Год:"; lblYear.Location = new System.Drawing.Point(20, y);
            numYear.Location = new System.Drawing.Point(120, y); numYear.Size = new System.Drawing.Size(100, 23); numYear.Maximum = 2026; numYear.Minimum = 1900; y += 35;

            lblGenre.Text = "Жанр:"; lblGenre.Location = new System.Drawing.Point(20, y);
            txtGenre.Location = new System.Drawing.Point(120, y); txtGenre.Size = new System.Drawing.Size(350, 23); y += 35;

            lblPrice.Text = "Цена:*"; lblPrice.Location = new System.Drawing.Point(20, y);
            txtPrice.Location = new System.Drawing.Point(120, y); txtPrice.Size = new System.Drawing.Size(150, 23); y += 35;

            lblQuantity.Text = "Количество:*"; lblQuantity.Location = new System.Drawing.Point(20, y);
            txtQuantity.Location = new System.Drawing.Point(120, y); txtQuantity.Size = new System.Drawing.Size(150, 23); y += 35;

            lblDescription.Text = "Описание:"; lblDescription.Location = new System.Drawing.Point(20, y);
            txtDescription.Location = new System.Drawing.Point(20, y + 25); txtDescription.Size = new System.Drawing.Size(450, 80);
            txtDescription.Multiline = true; txtDescription.ScrollBars = ScrollBars.Vertical; y += 120;

            btnSave.Text = "Сохранить"; btnSave.Location = new System.Drawing.Point(200, y); btnSave.Size = new System.Drawing.Size(100, 35);
            btnSave.Click += new EventHandler(this.btnSave_Click);

            this.Controls.AddRange(new Control[] { lblISBN, txtISBN, lblTitle, txtTitle, lblAuthor, cmbAuthor, lblPublisher, cmbPublisher,
                lblYear, numYear, lblGenre, txtGenre, lblPrice, txtPrice, lblQuantity, txtQuantity, lblDescription, txtDescription, btnSave });
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}