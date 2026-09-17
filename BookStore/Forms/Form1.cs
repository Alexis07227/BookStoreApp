using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public static int CurrentUserID { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentRole { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Авторизация - Книжный магазин";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ВРЕМЕННО: сравниваем пароль как есть (без хеширования)
            string query = "SELECT UserID, Username, Role, EmployeeID FROM Users WHERE Username = @username AND PasswordHash = @password AND IsActive = 1";
            SqlParameter[] parameters = {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password)   // ← теперь поле PasswordHash сравнивается с открытым паролем
    };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                CurrentUserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                CurrentUsername = dt.Rows[0]["Username"].ToString();
                CurrentRole = dt.Rows[0]["Role"].ToString();

                string logQuery = "INSERT INTO AuditLog (UserID, ActionType, TableName, ActionDate) VALUES (@uid, 'LOGIN', 'Users', GETDATE())";
                db.ExecuteNonQuery(logQuery, new SqlParameter[] { new SqlParameter("@uid", CurrentUserID) });

                string updateQuery = "UPDATE Users SET LastLogin = GETDATE() WHERE UserID = @userid";
                db.ExecuteNonQuery(updateQuery, new SqlParameter[] { new SqlParameter("@userid", CurrentUserID) });

                MessageBox.Show("Добро пожаловать, " + CurrentUsername + "!\nВаша роль: " + CurrentRole, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}