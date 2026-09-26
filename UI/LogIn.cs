namespace UI
{
    public partial class LogIn : Form
    {
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

            if (username == "admin" && password == "password123")
            {
                admindashboardform adminForm = new admindashboardform();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "frontdesk" && password == "password123")
            {
                frontdeskdashboardForm frontDeskForm = new frontdeskdashboardForm();
                frontDeskForm.Show();
                this.Hide();
            }
            else
            {
                lblerror.Text = "Invalid username or password.";
            }
        }
    }
}
