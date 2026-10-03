namespace UI
{
    partial class guest_maintenanceform
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
            components = new System.ComponentModel.Container();
            lblGuestMaintenance = new Label();
            bindingSource1 = new BindingSource(components);
            btnSearch = new Button();
            txbSearch = new TextBox();
            dgvGuests = new DataGridView();
            lblGuestID = new Label();
            lblFirstName = new Label();
            txtGuestID = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            SuspendLayout();
            // 
            // lblGuestMaintenance
            // 
            lblGuestMaintenance.AutoSize = true;
            lblGuestMaintenance.Location = new Point(17, 7);
            lblGuestMaintenance.Margin = new Padding(2, 0, 2, 0);
            lblGuestMaintenance.Name = "lblGuestMaintenance";
            lblGuestMaintenance.Size = new Size(109, 15);
            lblGuestMaintenance.TabIndex = 16;
            lblGuestMaintenance.Text = "Guest Maintenance";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(883, 7);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(724, 7);
            txbSearch.Margin = new Padding(2);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(155, 23);
            txbSearch.TabIndex = 25;
            // 
            // dgvGuests
            // 
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuests.Location = new Point(235, 117);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.Size = new Size(748, 323);
            dgvGuests.TabIndex = 26;
            dgvGuests.CellClick += dgvGuests_CellClick;
            // 
            // lblGuestID
            // 
            lblGuestID.AutoSize = true;
            lblGuestID.Location = new Point(17, 42);
            lblGuestID.Name = "lblGuestID";
            lblGuestID.Size = new Size(51, 15);
            lblGuestID.TabIndex = 27;
            lblGuestID.Text = "Guest ID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(17, 86);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 28;
            lblFirstName.Text = "First Name";
            // 
            // txtGuestID
            // 
            txtGuestID.Location = new Point(17, 60);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.ReadOnly = true;
            txtGuestID.Size = new Size(203, 23);
            txtGuestID.TabIndex = 29;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(17, 104);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(203, 23);
            txtFirstName.TabIndex = 30;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(17, 130);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 31;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(17, 148);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(203, 23);
            txtLastName.TabIndex = 32;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 33;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(17, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 23);
            txtEmail.TabIndex = 34;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(17, 218);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(96, 15);
            lblPhone.TabIndex = 35;
            lblPhone.Text = "Contact Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(17, 236);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(203, 23);
            txtPhone.TabIndex = 36;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(17, 262);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(67, 15);
            lblRoomType.TabIndex = 37;
            lblRoomType.Text = "Room Type";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(17, 280);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(203, 23);
            cmbRoomType.TabIndex = 38;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(17, 306);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 39;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(17, 324);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(203, 23);
            cmbStatus.TabIndex = 40;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 41;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(341, 82);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(422, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(503, 82);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // guest_maintenanceform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 452);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbRoomType);
            Controls.Add(lblRoomType);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtGuestID);
            Controls.Add(lblFirstName);
            Controls.Add(lblGuestID);
            Controls.Add(dgvGuests);
            Controls.Add(txbSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblGuestMaintenance);
            Margin = new Padding(2);
            Name = "guest_maintenanceform";
            Text = "guest_maintenanceform";
            Load += guest_maintenanceform_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListView listView5;
        private ListView listView8;
        private ListView listView10;
        private Label lblGuestMaintenance;
        private BindingSource bindingSource1;
        private TextBox txtGuestID;
        private Button btnSearch;
        private TextBox txbSearch;
        private DataGridView dgvGuests;
        private Label lblGuestID;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}