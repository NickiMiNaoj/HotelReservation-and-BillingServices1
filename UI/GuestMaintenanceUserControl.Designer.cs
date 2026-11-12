namespace UI
{
    partial class GuestMaintenanceUserControl
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
            lblGuestID = new Label();
            txtGuestID = new TextBox();
            lblNationality = new Label();
            cboNationality = new ComboBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblContactNumber = new Label();
            txtContactNumber = new TextBox();
            lblEmailAddress = new Label();
            txtEmailAddress = new TextBox();
            lblIDType = new Label();
            cboIDType = new ComboBox();
            lblIDNumber = new Label();
            txtIDNumber = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblGuestPreferences = new Label();
            rtbGuestPreferences = new RichTextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblGuestList = new Label();
            dgvGuestList = new DataGridView();
            colGuestID = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colContactNumber = new DataGridViewTextBoxColumn();
            colEmailAddress = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Guest Maintenance";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnUpdate);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(rtbGuestPreferences);
            pnlForm.Controls.Add(lblGuestPreferences);
            pnlForm.Controls.Add(txtAddress);
            pnlForm.Controls.Add(lblAddress);
            pnlForm.Controls.Add(txtIDNumber);
            pnlForm.Controls.Add(lblIDNumber);
            pnlForm.Controls.Add(cboIDType);
            pnlForm.Controls.Add(lblIDType);
            pnlForm.Controls.Add(txtEmailAddress);
            pnlForm.Controls.Add(lblEmailAddress);
            pnlForm.Controls.Add(txtContactNumber);
            pnlForm.Controls.Add(lblContactNumber);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(lblLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(lblFirstName);
            pnlForm.Controls.Add(cboNationality);
            pnlForm.Controls.Add(lblNationality);
            pnlForm.Controls.Add(txtGuestID);
            pnlForm.Controls.Add(lblGuestID);
            pnlForm.Location = new Point(30, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(620, 690);
            pnlForm.TabIndex = 1;
            // 
            // lblGuestID
            // 
            lblGuestID.AutoSize = true;
            lblGuestID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestID.Location = new Point(20, 20);
            lblGuestID.Name = "lblGuestID";
            lblGuestID.Size = new Size(70, 20);
            lblGuestID.TabIndex = 0;
            lblGuestID.Text = "Guest ID";
            // 
            // txtGuestID
            // 
            txtGuestID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestID.Location = new Point(20, 45);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.Size = new Size(270, 27);
            txtGuestID.TabIndex = 1;
            txtGuestID.ReadOnly = true;
            txtGuestID.Text = "Auto-generated";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNationality.Location = new Point(320, 20);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(90, 20);
            lblNationality.TabIndex = 2;
            lblNationality.Text = "Nationality";
            // 
            // cboNationality
            // 
            cboNationality.DropDownStyle = ComboBoxStyle.DropDown;
            cboNationality.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNationality.FormattingEnabled = true;
            cboNationality.Items.AddRange(new object[] { "Filipino", "American", "British", "Australian", "Chinese", "Japanese", "Korean" });
            cboNationality.Location = new Point(320, 45);
            cboNationality.Name = "cboNationality";
            cboNationality.Size = new Size(280, 28);
            cboNationality.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(20, 100);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(85, 20);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(20, 125);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(270, 27);
            txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(320, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 20);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(320, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 27);
            txtLastName.TabIndex = 7;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactNumber.Location = new Point(20, 180);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(125, 20);
            lblContactNumber.TabIndex = 8;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.Location = new Point(20, 205);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(270, 27);
            txtContactNumber.TabIndex = 9;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailAddress.Location = new Point(320, 180);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(110, 20);
            lblEmailAddress.TabIndex = 10;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailAddress.Location = new Point(320, 205);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(280, 27);
            txtEmailAddress.TabIndex = 11;
            // 
            // lblIDType
            // 
            lblIDType.AutoSize = true;
            lblIDType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDType.Location = new Point(20, 260);
            lblIDType.Name = "lblIDType";
            lblIDType.Size = new Size(55, 20);
            lblIDType.TabIndex = 12;
            lblIDType.Text = "ID Type";
            // 
            // cboIDType
            // 
            cboIDType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIDType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboIDType.FormattingEnabled = true;
            cboIDType.Items.AddRange(new object[] { "Passport", "National ID", "Driver's License" });
            cboIDType.Location = new Point(20, 285);
            cboIDType.Name = "cboIDType";
            cboIDType.Size = new Size(270, 28);
            cboIDType.TabIndex = 13;
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDNumber.Location = new Point(320, 260);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(80, 20);
            lblIDNumber.TabIndex = 14;
            lblIDNumber.Text = "ID Number";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDNumber.Location = new Point(320, 285);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(280, 27);
            txtIDNumber.TabIndex = 15;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(20, 340);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(60, 20);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(20, 365);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(580, 27);
            txtAddress.TabIndex = 17;
            // 
            // lblGuestPreferences
            // 
            lblGuestPreferences.AutoSize = true;
            lblGuestPreferences.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestPreferences.Location = new Point(20, 420);
            lblGuestPreferences.Name = "lblGuestPreferences";
            lblGuestPreferences.Size = new Size(135, 20);
            lblGuestPreferences.TabIndex = 18;
            lblGuestPreferences.Text = "Guest Preferences";
            // 
            // rtbGuestPreferences
            // 
            rtbGuestPreferences.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbGuestPreferences.Location = new Point(20, 445);
            rtbGuestPreferences.Name = "rtbGuestPreferences";
            rtbGuestPreferences.Size = new Size(580, 130);
            rtbGuestPreferences.TabIndex = 19;
            rtbGuestPreferences.Text = "";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(20, 605);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 55);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(165, 605);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 55);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(310, 605);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 55);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(455, 605);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 55);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblGuestList
            // 
            lblGuestList.AutoSize = true;
            lblGuestList.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestList.Location = new Point(680, 75);
            lblGuestList.Name = "lblGuestList";
            lblGuestList.Size = new Size(90, 26);
            lblGuestList.TabIndex = 2;
            lblGuestList.Text = "Guest List";
            // 
            // dgvGuestList
            // 
            dgvGuestList.AllowUserToAddRows = false;
            dgvGuestList.AllowUserToDeleteRows = false;
            dgvGuestList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGuestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestList.BackgroundColor = Color.White;
            dgvGuestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestList.Columns.AddRange(new DataGridViewColumn[] { colGuestID, colFirstName, colLastName, colContactNumber, colEmailAddress, colNationality });
            dgvGuestList.Location = new Point(680, 110);
            dgvGuestList.Name = "dgvGuestList";
            dgvGuestList.ReadOnly = true;
            dgvGuestList.RowHeadersVisible = false;
            dgvGuestList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuestList.Size = new Size(735, 820);
            dgvGuestList.TabIndex = 3;
            // 
            // colGuestID
            // 
            colGuestID.HeaderText = "Guest ID";
            colGuestID.Name = "colGuestID";
            colGuestID.ReadOnly = true;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            // 
            // colContactNumber
            // 
            colContactNumber.HeaderText = "Contact Number";
            colContactNumber.Name = "colContactNumber";
            colContactNumber.ReadOnly = true;
            // 
            // colEmailAddress
            // 
            colEmailAddress.HeaderText = "Email Address";
            colEmailAddress.Name = "colEmailAddress";
            colEmailAddress.ReadOnly = true;
            // 
            // colNationality
            // 
            colNationality.HeaderText = "Nationality";
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            // 
            // GuestMaintenanceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvGuestList);
            Controls.Add(lblGuestList);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "GuestMaintenanceUserControl";
            Size = new Size(1445, 963);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private Label lblTitle;
        private Label lblGuestID;
        private TextBox txtGuestID;
        private Label lblNationality;
        private ComboBox cboNationality;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblContactNumber;
        private TextBox txtContactNumber;
        private Label lblEmailAddress;
        private TextBox txtEmailAddress;
        private Label lblIDType;
        private ComboBox cboIDType;
        private Label lblIDNumber;
        private TextBox txtIDNumber;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblGuestPreferences;
        private RichTextBox rtbGuestPreferences;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblGuestList;
        private DataGridView dgvGuestList;
        private DataGridViewTextBoxColumn colGuestID;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colContactNumber;
        private DataGridViewTextBoxColumn colEmailAddress;
        private DataGridViewTextBoxColumn colNationality;
    }
}