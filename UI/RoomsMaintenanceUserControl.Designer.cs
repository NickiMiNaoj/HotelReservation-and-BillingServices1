namespace UI
{
    partial class RoomsMaintenanceUserControl
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
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblRoomType = new Label();
            cboRoomType = new ComboBox();
            lblNightlyRate = new Label();
            nudNightlyRate = new NumericUpDown();
            lblRoomStatus = new Label();
            cboRoomStatus = new ComboBox();
            lblMaxCapacity = new Label();
            nudMaxCapacity = new NumericUpDown();
            lblBedType = new Label();
            cboBedType = new ComboBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            lblAmenities = new Label();
            clbAmenities = new CheckedListBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblSearchRoom = new Label();
            txtSearchRoom = new TextBox();
            dgvRoomList = new DataGridView();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colNightlyRate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colBedType = new DataGridViewTextBoxColumn();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNightlyRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
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
            lblTitle.Text = "Rooms Maintenance";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnUpdate);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(clbAmenities);
            pnlForm.Controls.Add(lblAmenities);
            pnlForm.Controls.Add(rtbDescription);
            pnlForm.Controls.Add(lblDescription);
            pnlForm.Controls.Add(cboBedType);
            pnlForm.Controls.Add(lblBedType);
            pnlForm.Controls.Add(nudMaxCapacity);
            pnlForm.Controls.Add(lblMaxCapacity);
            pnlForm.Controls.Add(cboRoomStatus);
            pnlForm.Controls.Add(lblRoomStatus);
            pnlForm.Controls.Add(nudNightlyRate);
            pnlForm.Controls.Add(lblNightlyRate);
            pnlForm.Controls.Add(cboRoomType);
            pnlForm.Controls.Add(lblRoomType);
            pnlForm.Controls.Add(txtRoomNumber);
            pnlForm.Controls.Add(lblRoomNumber);
            pnlForm.Location = new Point(30, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(620, 790);
            pnlForm.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(20, 20);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(100, 20);
            lblRoomNumber.TabIndex = 0;
            lblRoomNumber.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(20, 45);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(270, 27);
            txtRoomNumber.TabIndex = 1;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.Location = new Point(320, 20);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(80, 20);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Room Type";
            // 
            // cboRoomType
            // 
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Junior Suite", "Executive Suite", "Presidential Suite" });
            cboRoomType.Location = new Point(320, 45);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(280, 28);
            cboRoomType.TabIndex = 3;
            // 
            // lblNightlyRate
            // 
            lblNightlyRate.AutoSize = true;
            lblNightlyRate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNightlyRate.Location = new Point(20, 100);
            lblNightlyRate.Name = "lblNightlyRate";
            lblNightlyRate.Size = new Size(95, 20);
            lblNightlyRate.TabIndex = 4;
            lblNightlyRate.Text = "Nightly Rate";
            // 
            // nudNightlyRate
            // 
            nudNightlyRate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudNightlyRate.DecimalPlaces = 2;
            nudNightlyRate.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudNightlyRate.Location = new Point(20, 125);
            nudNightlyRate.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudNightlyRate.Name = "nudNightlyRate";
            nudNightlyRate.Size = new Size(270, 27);
            nudNightlyRate.TabIndex = 5;
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.AutoSize = true;
            lblRoomStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomStatus.Location = new Point(320, 100);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(95, 20);
            lblRoomStatus.TabIndex = 6;
            lblRoomStatus.Text = "Room Status";
            // 
            // cboRoomStatus
            // 
            cboRoomStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoomStatus.FormattingEnabled = true;
            cboRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Needs Housekeeping", "Under Maintenance" });
            cboRoomStatus.Location = new Point(320, 125);
            cboRoomStatus.Name = "cboRoomStatus";
            cboRoomStatus.Size = new Size(280, 28);
            cboRoomStatus.TabIndex = 7;
            // 
            // lblMaxCapacity
            // 
            lblMaxCapacity.AutoSize = true;
            lblMaxCapacity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxCapacity.Location = new Point(20, 180);
            lblMaxCapacity.Name = "lblMaxCapacity";
            lblMaxCapacity.Size = new Size(140, 20);
            lblMaxCapacity.TabIndex = 8;
            lblMaxCapacity.Text = "Maximum Capacity";
            // 
            // nudMaxCapacity
            // 
            nudMaxCapacity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudMaxCapacity.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxCapacity.Location = new Point(20, 205);
            nudMaxCapacity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMaxCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxCapacity.Name = "nudMaxCapacity";
            nudMaxCapacity.Size = new Size(270, 27);
            nudMaxCapacity.TabIndex = 9;
            nudMaxCapacity.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblBedType
            // 
            lblBedType.AutoSize = true;
            lblBedType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBedType.Location = new Point(320, 180);
            lblBedType.Name = "lblBedType";
            lblBedType.Size = new Size(70, 20);
            lblBedType.TabIndex = 10;
            lblBedType.Text = "Bed Type";
            // 
            // cboBedType
            // 
            cboBedType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBedType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboBedType.FormattingEnabled = true;
            cboBedType.Items.AddRange(new object[] { "Single", "Twin", "Queen", "King" });
            cboBedType.Location = new Point(320, 205);
            cboBedType.Name = "cboBedType";
            cboBedType.Size = new Size(280, 28);
            cboBedType.TabIndex = 11;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(20, 260);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(135, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Room Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescription.Location = new Point(20, 285);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(580, 130);
            rtbDescription.TabIndex = 13;
            rtbDescription.Text = "";
            // 
            // lblAmenities
            // 
            lblAmenities.AutoSize = true;
            lblAmenities.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmenities.Location = new Point(20, 430);
            lblAmenities.Name = "lblAmenities";
            lblAmenities.Size = new Size(75, 20);
            lblAmenities.TabIndex = 14;
            lblAmenities.Text = "Amenities";
            // 
            // clbAmenities
            // 
            clbAmenities.CheckOnClick = true;
            clbAmenities.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbAmenities.FormattingEnabled = true;
            clbAmenities.Items.AddRange(new object[] { "Wi-Fi", "Air Conditioning", "Television", "Mini Bar", "Safe", "Balcony", "Bathtub", "Coffee Maker" });
            clbAmenities.Location = new Point(20, 455);
            clbAmenities.Name = "clbAmenities";
            clbAmenities.Size = new Size(580, 220);
            clbAmenities.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(20, 705);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 55);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(165, 705);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 55);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(310, 705);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 55);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(455, 705);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 55);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblSearchRoom
            // 
            lblSearchRoom.AutoSize = true;
            lblSearchRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchRoom.Location = new Point(680, 75);
            lblSearchRoom.Name = "lblSearchRoom";
            lblSearchRoom.Size = new Size(100, 20);
            lblSearchRoom.TabIndex = 2;
            lblSearchRoom.Text = "Search Room";
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchRoom.Location = new Point(680, 100);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Size = new Size(735, 27);
            txtSearchRoom.TabIndex = 3;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AllowUserToAddRows = false;
            dgvRoomList.AllowUserToDeleteRows = false;
            dgvRoomList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.BackgroundColor = Color.White;
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Columns.AddRange(new DataGridViewColumn[] { colRoomNumber, colRoomType, colNightlyRate, colStatus, colCapacity, colBedType });
            dgvRoomList.Location = new Point(680, 150);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.ReadOnly = true;
            dgvRoomList.RowHeadersVisible = false;
            dgvRoomList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoomList.Size = new Size(735, 780);
            dgvRoomList.TabIndex = 4;
            // 
            // colRoomNumber
            // 
            colRoomNumber.HeaderText = "Room Number";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colRoomType
            // 
            colRoomType.HeaderText = "Room Type";
            colRoomType.Name = "colRoomType";
            colRoomType.ReadOnly = true;
            // 
            // colNightlyRate
            // 
            colNightlyRate.HeaderText = "Nightly Rate";
            colNightlyRate.Name = "colNightlyRate";
            colNightlyRate.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colCapacity
            // 
            colCapacity.HeaderText = "Capacity";
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            // 
            // colBedType
            // 
            colBedType.HeaderText = "Bed Type";
            colBedType.Name = "colBedType";
            colBedType.ReadOnly = true;
            // 
            // RoomsMaintenanceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvRoomList);
            Controls.Add(txtSearchRoom);
            Controls.Add(lblSearchRoom);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "RoomsMaintenanceUserControl";
            Size = new Size(1445, 963);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNightlyRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private Label lblTitle;
        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblRoomType;
        private ComboBox cboRoomType;
        private Label lblNightlyRate;
        private NumericUpDown nudNightlyRate;
        private Label lblRoomStatus;
        private ComboBox cboRoomStatus;
        private Label lblMaxCapacity;
        private NumericUpDown nudMaxCapacity;
        private Label lblBedType;
        private ComboBox cboBedType;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Label lblAmenities;
        private CheckedListBox clbAmenities;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblSearchRoom;
        private TextBox txtSearchRoom;
        private DataGridView dgvRoomList;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colNightlyRate;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colBedType;
    }
}