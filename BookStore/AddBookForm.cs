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

            // Необязательно: можно скрыть новые поля, если они пустые (но лучше оставить видимыми)
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
            // Проверка обязательных полей
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                MessageBox.Show("Поле ISBN обязательно для заполнения!");
                return;
            }

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

            // ★ ОБРАБОТКА АВТОРА ★
            int? authorId = null;
            if (cmbAuthor.SelectedIndex != -1)
            {
                // Если выбран из списка — берём его
                authorId = (int)cmbAuthor.SelectedValue;
            }
            else if (!string.IsNullOrEmpty(txtNewAuthor.Text))
            {
                // Если не выбран, но введён новый автор
                string fullName = txtNewAuthor.Text.Trim();
                string[] parts = fullName.Split(' ');
                string lastName = parts.Length > 0 ? parts[0] : "";
                string firstName = parts.Length > 1 ? parts[1] : "";

                // Проверяем, существует ли уже такой автор (чтобы не создавать дубликаты)
                string checkAuthor = "SELECT AuthorID FROM Authors WHERE LastName = @last AND FirstName = @first";
                DataTable dtAuthor = db.ExecuteQuery(checkAuthor, new SqlParameter[] {
                    new SqlParameter("@last", lastName),
                    new SqlParameter("@first", firstName)
                });
                if (dtAuthor.Rows.Count > 0)
                {
                    authorId = Convert.ToInt32(dtAuthor.Rows[0]["AuthorID"]);
                }
                else
                {
                    string insertAuthor = "INSERT INTO Authors (LastName, FirstName) VALUES (@last, @first); SELECT SCOPE_IDENTITY();";
                    authorId = Convert.ToInt32(db.ExecuteScalar(insertAuthor, new SqlParameter[] {
                        new SqlParameter("@last", lastName),
                        new SqlParameter("@first", firstName)
                    }));
                }
            }

            // ★ ОБРАБОТКА ИЗДАТЕЛЬСТВА ★
            int? publisherId = null;
            if (cmbPublisher.SelectedIndex != -1)
            {
                publisherId = (int)cmbPublisher.SelectedValue;
            }
            else if (!string.IsNullOrEmpty(txtNewPublisher.Text))
            {
                string publisherName = txtNewPublisher.Text.Trim();

                // Проверяем, существует ли уже такое издательство
                string checkPublisher = "SELECT PublisherID FROM Publishers WHERE PublisherName = @name";
                DataTable dtPub = db.ExecuteQuery(checkPublisher, new SqlParameter[] {
                    new SqlParameter("@name", publisherName)
                });
                if (dtPub.Rows.Count > 0)
                {
                    publisherId = Convert.ToInt32(dtPub.Rows[0]["PublisherID"]);
                }
                else
                {
                    string insertPublisher = "INSERT INTO Publishers (PublisherName) VALUES (@name); SELECT SCOPE_IDENTITY();";
                    publisherId = Convert.ToInt32(db.ExecuteScalar(insertPublisher, new SqlParameter[] {
                        new SqlParameter("@name", publisherName)
                    }));
                }
            }

            // Если автор или издательство не указаны — можно либо запретить сохранение, либо позволить NULL.
            // Я разрешаю NULL, но если хочешь, чтобы они были обязательны — раскомментируй проверки ниже.
            /*
            if (authorId == null)
            {
                MessageBox.Show("Выберите автора или введите нового!");
                return;
            }
            if (publisherId == null)
            {
                MessageBox.Show("Выберите издательство или введите новое!");
                return;
            }
            */

            string query = @"INSERT INTO Books (ISBN, Title, AuthorID, PublisherID, PublicationYear, Genre, Price, QuantityInStock, Description) 
                             VALUES (@isbn, @title, @authorid, @publisherid, @year, @genre, @price, @quantity, @desc)";

            SqlParameter[] param = {
                new SqlParameter("@isbn", txtISBN.Text),
                new SqlParameter("@title", txtTitle.Text),
                new SqlParameter("@authorid", authorId ?? (object)DBNull.Value),
                new SqlParameter("@publisherid", publisherId ?? (object)DBNull.Value),
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNewAuthor_Click(object sender, EventArgs e)
        {

        }

        private void txtNewAuthor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}