using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore
{
    public partial class EditBookForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int bookID;

        public EditBookForm(int id)
        {
            InitializeComponent();
            bookID = id;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadBookData();
        }

        private void LoadBookData()
        {
            string query = "SELECT Title, Price, QuantityInStock FROM Books WHERE BookID = @id";
            DataTable dt = db.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@id", bookID) });
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtTitle.Text = row["Title"].ToString();
                txtPrice.Text = row["Price"].ToString();
                txtQuantity.Text = row["QuantityInStock"].ToString();
            }
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

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Введите корректное количество (неотрицательное число)!");
                return;
            }

            string query = "UPDATE Books SET Title = @title, Price = @price, QuantityInStock = @qty WHERE BookID = @id";
            SqlParameter[] param = {
                new SqlParameter("@id", bookID),
                new SqlParameter("@title", txtTitle.Text),
                new SqlParameter("@price", price),
                new SqlParameter("@qty", qty)
            };

            if (db.ExecuteNonQuery(query, param) > 0)
            {
                MessageBox.Show("Книга обновлена!");
                this.Close();
            }
        }

    

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}