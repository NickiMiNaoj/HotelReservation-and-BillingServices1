using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class LoginPageForm : Form
    {
        private readonly EmployeeController _employeeController = new EmployeeController();

        public LoginPageForm()
        {
            InitializeComponent();

            this.btnLogin.Click += BtnLogin_Click;
            this.btnExit.Click += BtnExit_Click;
            this.chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cboRole.SelectedItem?.ToString() ?? string.Empty;

            // Call the controller's Login method
            Employee loggedInEmployee = _employeeController.Login(username, password, role, out string message);

            if (loggedInEmployee != null)
            {
                MessageBox.Show($"Welcome back, {loggedInEmployee.FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Open your main application dashboard here and pass the loggedInEmployee object if needed
                // MainDashboardForm dashboard = new MainDashboardForm(loggedInEmployee);
                // dashboard.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password masking based on the checkbox state
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}