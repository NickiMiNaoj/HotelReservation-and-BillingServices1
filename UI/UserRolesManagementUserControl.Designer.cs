namespace UI
{
    partial class UserRolesManagementUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlForm = new Panel();
            lblTitle = new Label();
            lblEmployeeID = new Label();
            txtEmployeeID = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblAccountStatus = new Label();
            cboAccountStatus = new ComboBox();
            btnSaveAccount = new Button();
            btnUpdateAccount = new Button();
            btnDeactivateAccount = new Button();
            btnClear = new Button();
            lblEmployeeList = new Label();
            dgvEmployeeList = new DataGridView();
            colEmployeeID = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Roles Management";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnDeactivateAccount);
            pnlForm.Controls.Add(btnUpdateAccount);
            pnlForm.Controls.Add(btnSaveAccount);
            pnlForm.Controls.Add(cboAccountStatus);
            pnlForm.Controls.Add(lblAccountStatus);
            pnlForm.Controls.Add(cboRole);
            pnlForm.Controls.Add(lblRole);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(txtFullName);
            pnlForm.Controls.Add(lblFullName);
            pnlForm.Controls.Add(txtEmployeeID);
            pnlForm.Controls.Add(lblEmployeeID);
            pnlForm.Location = new Point(30, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(620, 430);
            pnlForm.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeID.Location = new Point(20, 20);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(95, 20);
            lblEmployeeID.TabIndex = 0;
            lblEmployeeID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.Location = new Point(20, 45);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(270, 27);
            txtEmployeeID.TabIndex = 1;
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Text = "Auto-generated";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(320, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(320, 45);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(280, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(20, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(20, 125);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 27);
            txtUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(320, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(320, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(20, 180);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(40, 20);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            cboRole.Location = new Point(20, 205);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(270, 28);
            cboRole.TabIndex = 9;
            // 
            // lblAccountStatus
            // 
            lblAccountStatus.AutoSize = true;
            lblAccountStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountStatus.Location = new Point(320, 180);
            lblAccountStatus.Name = "lblAccountStatus";
            lblAccountStatus.Size = new Size(120, 20);
            lblAccountStatus.TabIndex = 10;
            lblAccountStatus.Text = "Account Status";
            // 
            // cboAccountStatus
            // 
            cboAccountStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAccountStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAccountStatus.FormattingEnabled = true;
            cboAccountStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cboAccountStatus.Location = new Point(320, 205);
            cboAccountStatus.Name = "cboAccountStatus";
            cboAccountStatus.Size = new Size(280, 28);
            cboAccountStatus.TabIndex = 11;
            // 
            // btnSaveAccount
            // 
            btnSaveAccount.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAccount.Location = new Point(20, 270);
            btnSaveAccount.Name = "btnSaveAccount";
            btnSaveAccount.Size = new Size(285, 55);
            btnSaveAccount.TabIndex = 12;
            btnSaveAccount.Text = "Save Account";
            btnSaveAccount.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAccount.Location = new Point(315, 270);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(285, 55);
            btnUpdateAccount.TabIndex = 13;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeactivateAccount
            // 
            btnDeactivateAccount.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivateAccount.Location = new Point(20, 340);
            btnDeactivateAccount.Name = "btnDeactivateAccount";
            btnDeactivateAccount.Size = new Size(285, 55);
            btnDeactivateAccount.TabIndex = 14;
            btnDeactivateAccount.Text = "Deactivate Account";
            btnDeactivateAccount.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(315, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(285, 55);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeList.Location = new Point(680, 75);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(115, 26);
            lblEmployeeList.TabIndex = 2;
            lblEmployeeList.Text = "Employee List";
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.AllowUserToAddRows = false;
            dgvEmployeeList.AllowUserToDeleteRows = false;
            dgvEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeList.BackgroundColor = Color.White;
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Columns.AddRange(new DataGridViewColumn[] { colEmployeeID, colFullName, colUsername, colRole, colStatus });
            dgvEmployeeList.Location = new Point(680, 110);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.ReadOnly = true;
            dgvEmployeeList.RowHeadersVisible = false;
            dgvEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeList.Size = new Size(735, 820);
            dgvEmployeeList.TabIndex = 3;
            // 
            // colEmployeeID
            // 
            colEmployeeID.HeaderText = "Employee ID";
            colEmployeeID.Name = "colEmployeeID";
            colEmployeeID.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // UserRolesManagementUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvEmployeeList);
            Controls.Add(lblEmployeeList);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "UserRolesManagementUserControl";
            Size = new Size(1445, 963);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private Label lblTitle;
        private Label lblEmployeeID;
        private TextBox txtEmployeeID;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox cboRole;
        private Label lblAccountStatus;
        private ComboBox cboAccountStatus;
        private Button btnSaveAccount;
        private Button btnUpdateAccount;
        private Button btnDeactivateAccount;
        private Button btnClear;
        private Label lblEmployeeList;
        private DataGridView dgvEmployeeList;
        private DataGridViewTextBoxColumn colEmployeeID;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colStatus;
    }
}