using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore
{
    public partial class SupplierForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            string query = "SELECT SupplierID, SupplierName, ContactPerson, Phone, Email FROM Suppliers ORDER BY SupplierName";
            DataTable dt = db.ExecuteQuery(query);
            dgvSuppliers.DataSource = dt;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvSuppliers.Columns.Contains("SupplierID"))
                dgvSuppliers.Columns["SupplierID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("Введите название поставщика!");
                return;
            }

            string query = @"INSERT INTO Suppliers (SupplierName, ContactPerson, Phone, Email, Address) 
                             VALUES (@name, @contact, @phone, @email, @address)";

            SqlParameter[] param = {
                new SqlParameter("@name", txtSupplierName.Text),
                new SqlParameter("@contact", string.IsNullOrEmpty(txtContactPerson.Text) ? (object)DBNull.Value : txtContactPerson.Text),
                new SqlParameter("@phone", txtPhone.Text),
                new SqlParameter("@email", string.IsNullOrEmpty(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text),
                new SqlParameter("@address", string.IsNullOrEmpty(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text)
            };

            if (db.ExecuteNonQuery(query, param) > 0)
            {
                MessageBox.Show("Поставщик добавлен!");
                ClearForm();
                LoadSuppliers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null)
            {
                MessageBox.Show("Выберите поставщика!");
                return;
            }

            int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["SupplierID"].Value);
            string name = dgvSuppliers.CurrentRow.Cells["SupplierName"].Value.ToString();

            string checkQuery = "SELECT COUNT(*) FROM Supplies WHERE SupplierID = @id";
            int count = Convert.ToInt32(db.ExecuteScalar(checkQuery, new SqlParameter[] { new SqlParameter("@id", id) }));

            if (count > 0)
            {
                MessageBox.Show($"Нельзя удалить поставщика \"{name}\", так как у него есть поставки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить поставщика {name}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.ExecuteNonQuery("DELETE FROM Suppliers WHERE SupplierID = @id", new SqlParameter[] { new SqlParameter("@id", id) });
                LoadSuppliers();
            }
        }

        private void ClearForm()
        {
            txtSupplierName.Text = "";
            txtContactPerson.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}