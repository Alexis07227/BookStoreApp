using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ClientForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public ClientForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            string query = "SELECT ClientID, LastName, FirstName, Phone, DiscountPercent FROM Clients ORDER BY LastName";
            dgvClients.DataSource = db.ExecuteQuery(query);
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvClients.Columns.Contains("ClientID"))
                dgvClients.Columns["ClientID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Введите фамилию и имя!");
                return;
            }

            string query = @"INSERT INTO Clients (LastName, FirstName, MiddleName, Phone, Email, Address, DiscountPercent) 
                             VALUES (@last, @first, @middle, @phone, @email, @address, @discount)";

            SqlParameter[] param = {
                new SqlParameter("@last", txtLastName.Text),
                new SqlParameter("@first", txtFirstName.Text),
                new SqlParameter("@middle", string.IsNullOrEmpty(txtMiddleName.Text) ? (object)DBNull.Value : txtMiddleName.Text),
                new SqlParameter("@phone", txtPhone.Text),
                new SqlParameter("@email", string.IsNullOrEmpty(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text),
                new SqlParameter("@address", string.IsNullOrEmpty(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text),
                new SqlParameter("@discount", (int)numDiscount.Value)
            };

            if (db.ExecuteNonQuery(query, param) > 0)
            {
                MessageBox.Show("Клиент добавлен!");
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtMiddleName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtAddress.Text = "";
                numDiscount.Value = 0;
                LoadClients();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Выберите клиента!");
                return;
            }

            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientID"].Value);
            string name = dgvClients.CurrentRow.Cells["LastName"].Value.ToString();

            string checkQuery = "SELECT COUNT(*) FROM Orders WHERE ClientID = @id";
            int count = Convert.ToInt32(db.ExecuteScalar(checkQuery, new SqlParameter[] { new SqlParameter("@id", id) }));

            if (count > 0)
            {
                MessageBox.Show($"Нельзя удалить клиента \"{name}\", так как у него есть заказы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить клиента {name}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.ExecuteNonQuery("DELETE FROM Clients WHERE ClientID = @id", new SqlParameter[] { new SqlParameter("@id", id) });
                LoadClients();
            }
        }
    }
}