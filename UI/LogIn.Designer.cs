namespace UI
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblwelcome = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogIn = new Button();
            lblerror = new Label();
            SuspendLayout();
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 18F);
            lblwelcome.Location = new Point(10, 7);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(339, 64);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "               Wellcome! \r\nPlease sign in to your account.";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 18F);
            txtUsername.Location = new Point(189, 156);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(236, 39);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.Location = new Point(189, 229);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 39);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 18F);
            lblUsername.Location = new Point(12, 163);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(126, 32);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 18F);
            lblPassword.Location = new Point(22, 236);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(116, 32);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 18F);
            btnLogIn.Location = new Point(164, 395);
            btnLogIn.Margin = new Padding(3, 2, 3, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(152, 62);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "LogIn";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.BackColor = SystemColors.Control;
            lblerror.ForeColor = Color.Crimson;
            lblerror.Location = new Point(10, 173);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 15);
            lblerror.TabIndex = 8;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 598);
            Controls.Add(lblerror);
            Controls.Add(btnLogIn);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblwelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcome;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogIn;
        private Label lblerror;
    }
}