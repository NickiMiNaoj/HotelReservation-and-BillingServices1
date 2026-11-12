namespace UI
{
    partial class LoginPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPageForm));
            pnlBrand = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlLogin = new Panel();
            pnlCard = new Panel();
            btnExit = new Button();
            lnkForgotPassword = new LinkLabel();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            chkRememberMe = new CheckBox();
            cboRole = new ComboBox();
            lblRole = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = SystemColors.GradientActiveCaption;
            pnlBrand.Controls.Add(label2);
            pnlBrand.Controls.Add(label1);
            pnlBrand.Controls.Add(pictureBox1);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(480, 720);
            pnlBrand.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(150, 420);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 2;
            label2.Text = "Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Felix Titling", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 360);
            label1.Name = "label1";
            label1.Size = new Size(300, 32);
            label1.TabIndex = 1;
            label1.Text = "HOTEL RESERVATION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.Silver;
            pnlLogin.Controls.Add(pnlCard);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(480, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(720, 720);
            pnlLogin.TabIndex = 1;
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.None;
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(btnExit);
            pnlCard.Controls.Add(lnkForgotPassword);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(chkShowPassword);
            pnlCard.Controls.Add(chkRememberMe);
            pnlCard.Controls.Add(cboRole);
            pnlCard.Controls.Add(lblRole);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Location = new Point(151, 80);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(420, 560);
            pnlCard.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(19, 505);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(384, 45);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkForgotPassword.Location = new Point(151, 470);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(118, 19);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(19, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(384, 55);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(264, 340);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(123, 23);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.BackColor = Color.Transparent;
            chkRememberMe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRememberMe.Location = new Point(22, 340);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(118, 23);
            chkRememberMe.TabIndex = 3;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // cboRole
            // 
            cboRole.BackColor = Color.White;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Front Desk", "Admin" });
            cboRole.Location = new Point(19, 295);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(384, 29);
            cboRole.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(22, 273);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 19);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Silver;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(22, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(381, 29);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(22, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 19);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Silver;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(20, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(383, 29);
            txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(20, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(76, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.GrayText;
            lblSubtitle.Location = new Point(4, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(177, 20);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Please sign in to continue";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(6, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back";
            // 
            // LoginPageForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            Controls.Add(pnlLogin);
            Controls.Add(pnlBrand);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPageForm";
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBrand;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnlLogin;
        private Panel pnlCard;
        private Button btnExit;
        private LinkLabel lnkForgotPassword;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private CheckBox chkRememberMe;
        private ComboBox cboRole;
        private Label lblRole;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblSubtitle;
        private Label lblTitle;
    }
}