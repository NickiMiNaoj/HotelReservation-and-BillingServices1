using Microsoft.Data.SqlClient;

namespace UI
{
    public partial class LogIn : Form
    {
        private string connectionString = @"Server=MIZUTO\SQLEXPRESS;Database=DB;Trusted_Connection=True;TrustServerCertificate=True;";
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UserLogin", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullName = reader["FullName"].ToString();
                                string role = reader["Role"].ToString();

                                MessageBox.Show($"Login successful! Welcome, {fullName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (role == "Admin")
                                {
                                    admindashboardform adminForm = new admindashboardform();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else if (role == "Front Desk")
                                {
                                    frontdeskdashboardForm frontDeskForm = new frontdeskdashboardForm();
                                    frontDeskForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
