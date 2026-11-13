namespace UI
{
    partial class ReservationStatusManagementUserControl
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
            lblReservationID = new Label();
            txtReservationID = new TextBox();
            lblGuestName = new Label();
            txtGuestName = new TextBox();
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblReservationStatus = new Label();
            cboReservationStatus = new ComboBox();
            lblRoomStatus = new Label();
            cboRoomStatus = new ComboBox();
            lblRemarks = new Label();
            rtbRemarks = new RichTextBox();
            btnUpdateStatus = new Button();
            btnSearchReservation = new Button();
            lblReservationList = new Label();
            dgvReservationList = new DataGridView();
            colReservationID = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colReservationStatus = new DataGridViewTextBoxColumn();
            colRoomStatus = new DataGridViewTextBoxColumn();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reservation Status Management";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnSearchReservation);
            pnlForm.Controls.Add(btnUpdateStatus);
            pnlForm.Controls.Add(rtbRemarks);
            pnlForm.Controls.Add(lblRemarks);
            pnlForm.Controls.Add(cboRoomStatus);
            pnlForm.Controls.Add(lblRoomStatus);
            pnlForm.Controls.Add(cboReservationStatus);
            pnlForm.Controls.Add(lblReservationStatus);
            pnlForm.Controls.Add(txtRoomNumber);
            pnlForm.Controls.Add(lblRoomNumber);
            pnlForm.Controls.Add(txtGuestName);
            pnlForm.Controls.Add(lblGuestName);
            pnlForm.Controls.Add(txtReservationID);
            pnlForm.Controls.Add(lblReservationID);
            pnlForm.Location = new Point(30, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(620, 520);
            pnlForm.TabIndex = 1;
            // 
            // lblReservationID
            // 
            lblReservationID.AutoSize = true;
            lblReservationID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationID.Location = new Point(20, 20);
            lblReservationID.Name = "lblReservationID";
            lblReservationID.Size = new Size(115, 20);
            lblReservationID.TabIndex = 0;
            lblReservationID.Text = "Reservation ID";
            // 
            // txtReservationID
            // 
            txtReservationID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReservationID.Location = new Point(20, 45);
            txtReservationID.Name = "txtReservationID";
            txtReservationID.Size = new Size(270, 27);
            txtReservationID.TabIndex = 1;
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestName.Location = new Point(320, 20);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(90, 20);
            lblGuestName.TabIndex = 2;
            lblGuestName.Text = "Guest Name";
            // 
            // txtGuestName
            // 
            txtGuestName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestName.Location = new Point(320, 45);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(280, 27);
            txtGuestName.TabIndex = 3;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(20, 100);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(105, 20);
            lblRoomNumber.TabIndex = 4;
            lblRoomNumber.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(20, 125);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(270, 27);
            txtRoomNumber.TabIndex = 5;
            // 
            // lblReservationStatus
            // 
            lblReservationStatus.AutoSize = true;
            lblReservationStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationStatus.Location = new Point(320, 100);
            lblReservationStatus.Name = "lblReservationStatus";
            lblReservationStatus.Size = new Size(140, 20);
            lblReservationStatus.TabIndex = 6;
            lblReservationStatus.Text = "Reservation Status";
            // 
            // cboReservationStatus
            // 
            cboReservationStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReservationStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboReservationStatus.FormattingEnabled = true;
            cboReservationStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Cancelled" });
            cboReservationStatus.Location = new Point(320, 125);
            cboReservationStatus.Name = "cboReservationStatus";
            cboReservationStatus.Size = new Size(280, 28);
            cboReservationStatus.TabIndex = 7;
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.AutoSize = true;
            lblRoomStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomStatus.Location = new Point(20, 180);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(95, 20);
            lblRoomStatus.TabIndex = 8;
            lblRoomStatus.Text = "Room Status";
            // 
            // cboRoomStatus
            // 
            cboRoomStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoomStatus.FormattingEnabled = true;
            cboRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Needs Housekeeping", "Under Maintenance" });
            cboRoomStatus.Location = new Point(20, 205);
            cboRoomStatus.Name = "cboRoomStatus";
            cboRoomStatus.Size = new Size(270, 28);
            cboRoomStatus.TabIndex = 9;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemarks.Location = new Point(20, 260);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(65, 20);
            lblRemarks.TabIndex = 10;
            lblRemarks.Text = "Remarks";
            // 
            // rtbRemarks
            // 
            rtbRemarks.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbRemarks.Location = new Point(20, 285);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(580, 130);
            rtbRemarks.TabIndex = 11;
            rtbRemarks.Text = "";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.Location = new Point(20, 440);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(285, 55);
            btnUpdateStatus.TabIndex = 12;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnSearchReservation
            // 
            btnSearchReservation.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchReservation.Location = new Point(315, 440);
            btnSearchReservation.Name = "btnSearchReservation";
            btnSearchReservation.Size = new Size(285, 55);
            btnSearchReservation.TabIndex = 13;
            btnSearchReservation.Text = "Search Reservation";
            btnSearchReservation.UseVisualStyleBackColor = true;
            // 
            // lblReservationList
            // 
            lblReservationList.AutoSize = true;
            lblReservationList.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationList.Location = new Point(680, 75);
            lblReservationList.Name = "lblReservationList";
            lblReservationList.Size = new Size(140, 26);
            lblReservationList.TabIndex = 2;
            lblReservationList.Text = "Reservation List";
            // 
            // dgvReservationList
            // 
            dgvReservationList.AllowUserToAddRows = false;
            dgvReservationList.AllowUserToDeleteRows = false;
            dgvReservationList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationList.BackgroundColor = Color.White;
            dgvReservationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationList.Columns.AddRange(new DataGridViewColumn[] { colReservationID, colGuestName, colRoomNumber, colReservationStatus, colRoomStatus });
            dgvReservationList.Location = new Point(680, 110);
            dgvReservationList.Name = "dgvReservationList";
            dgvReservationList.ReadOnly = true;
            dgvReservationList.RowHeadersVisible = false;
            dgvReservationList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservationList.Size = new Size(735, 820);
            dgvReservationList.TabIndex = 3;
            // 
            // colReservationID
            // 
            colReservationID.HeaderText = "Reservation ID";
            colReservationID.Name = "colReservationID";
            colReservationID.ReadOnly = true;
            // 
            // colGuestName
            // 
            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.ReadOnly = true;
            // 
            // colRoomNumber
            // 
            colRoomNumber.HeaderText = "Room Number";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colReservationStatus
            // 
            colReservationStatus.HeaderText = "Reservation Status";
            colReservationStatus.Name = "colReservationStatus";
            colReservationStatus.ReadOnly = true;
            // 
            // colRoomStatus
            // 
            colRoomStatus.HeaderText = "Room Status";
            colRoomStatus.Name = "colRoomStatus";
            colRoomStatus.ReadOnly = true;
            // 
            // ReservationStatusManagementUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvReservationList);
            Controls.Add(lblReservationList);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "ReservationStatusManagementUserControl";
            Size = new Size(1445, 963);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private Label lblTitle;
        private Label lblReservationID;
        private TextBox txtReservationID;
        private Label lblGuestName;
        private TextBox txtGuestName;
        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblReservationStatus;
        private ComboBox cboReservationStatus;
        private Label lblRoomStatus;
        private ComboBox cboRoomStatus;
        private Label lblRemarks;
        private RichTextBox rtbRemarks;
        private Button btnUpdateStatus;
        private Button btnSearchReservation;
        private Label lblReservationList;
        private DataGridView dgvReservationList;
        private DataGridViewTextBoxColumn colReservationID;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colReservationStatus;
        private DataGridViewTextBoxColumn colRoomStatus;
    }
}