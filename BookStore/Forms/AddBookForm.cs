using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddBookForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public AddBookForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadAuthors();
            LoadPublishers();
        }

        private void LoadAuthors()
        {
            DataTable dt = db.ExecuteQuery("SELECT AuthorID, LastName + ' ' + LEFT(FirstName, 1) + '.' AS AuthorName FROM Authors");
            cmbAuthor.DataSource = dt;
            cmbAuthor.DisplayMember = "AuthorName";
            cmbAuthor.ValueMember = "AuthorID";
            cmbAuthor.SelectedIndex = -1;
        }

        private void LoadPublishers()
        {
            DataTable dt = db.ExecuteQuery("SELECT PublisherID, PublisherName FROM Publishers");
            cmbPublisher.DataSource = dt;
            cmbPublisher.DisplayMember = "PublisherName";
            cmbPublisher.ValueMember = "PublisherID";
            cmbPublisher.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Введите название книги!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Введите корректную цену (неотрицательное число)!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Введите корректное количество (неотрицательное число)!");
                return;
            }

            string query = @"INSERT INTO Books (ISBN, Title, AuthorID, PublisherID, PublicationYear, Genre, Price, QuantityInStock, Description) 
                             VALUES (@isbn, @title, @authorid, @publisherid, @year, @genre, @price, @quantity, @desc)";

            SqlParameter[] param = {
                new SqlParameter("@isbn", string.IsNullOrEmpty(txtISBN.Text) ? (object)DBNull.Value : txtISBN.Text),
                new SqlParameter("@title", txtTitle.Text),
                new SqlParameter("@authorid", cmbAuthor.SelectedIndex == -1 ? (object)DBNull.Value : cmbAuthor.SelectedValue),
                new SqlParameter("@publisherid", cmbPublisher.SelectedIndex == -1 ? (object)DBNull.Value : cmbPublisher.SelectedValue),
                new SqlParameter("@year", (int)numYear.Value == 0 ? (object)DBNull.Value : (int)numYear.Value),
                new SqlParameter("@genre", string.IsNullOrEmpty(txtGenre.Text) ? (object)DBNull.Value : txtGenre.Text),
                new SqlParameter("@price", price),
                new SqlParameter("@quantity", quantity),
                new SqlParameter("@desc", string.IsNullOrEmpty(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text)
            };

            if (db.ExecuteNonQuery(query, param) > 0)
            {
                MessageBox.Show("Книга добавлена!");
                this.Close();
            }
        }
    }
}