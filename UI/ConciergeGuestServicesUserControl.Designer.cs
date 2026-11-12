namespace UI
{
    partial class ConciergeGuestServicesUserControl
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
            lblGuestName = new Label();
            cboGuestName = new ComboBox();
            lblServiceType = new Label();
            cboServiceType = new ComboBox();
            lblPriority = new Label();
            cboPriority = new ComboBox();
            lblAssignStaff = new Label();
            cboAssignStaff = new ComboBox();
            lblRequestDetails = new Label();
            rtbRequestDetails = new RichTextBox();
            btnSubmitRequest = new Button();
            lblServiceRequestList = new Label();
            dgvServiceRequestList = new DataGridView();
            colRequestID = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colServiceType = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            colAssignedStaff = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiceRequestList).BeginInit();
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
            lblTitle.Text = "Concierge and Guest Services";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnSubmitRequest);
            pnlForm.Controls.Add(rtbRequestDetails);
            pnlForm.Controls.Add(lblRequestDetails);
            pnlForm.Controls.Add(cboAssignStaff);
            pnlForm.Controls.Add(lblAssignStaff);
            pnlForm.Controls.Add(cboPriority);
            pnlForm.Controls.Add(lblPriority);
            pnlForm.Controls.Add(cboServiceType);
            pnlForm.Controls.Add(lblServiceType);
            pnlForm.Controls.Add(cboGuestName);
            pnlForm.Controls.Add(lblGuestName);
            pnlForm.Location = new Point(30, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(620, 470);
            pnlForm.TabIndex = 1;
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestName.Location = new Point(20, 20);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(90, 20);
            lblGuestName.TabIndex = 0;
            lblGuestName.Text = "Guest Name";
            // 
            // cboGuestName
            // 
            cboGuestName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGuestName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGuestName.FormattingEnabled = true;
            cboGuestName.Location = new Point(20, 45);
            cboGuestName.Name = "cboGuestName";
            cboGuestName.Size = new Size(270, 28);
            cboGuestName.TabIndex = 1;
            // 
            // lblServiceType
            // 
            lblServiceType.AutoSize = true;
            lblServiceType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServiceType.Location = new Point(320, 20);
            lblServiceType.Name = "lblServiceType";
            lblServiceType.Size = new Size(100, 20);
            lblServiceType.TabIndex = 2;
            lblServiceType.Text = "Service Type";
            // 
            // cboServiceType
            // 
            cboServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServiceType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboServiceType.FormattingEnabled = true;
            cboServiceType.Items.AddRange(new object[] { "Airport Transfer", "Concierge", "Room Service" });
            cboServiceType.Location = new Point(320, 45);
            cboServiceType.Name = "cboServiceType";
            cboServiceType.Size = new Size(280, 28);
            cboServiceType.TabIndex = 3;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(20, 100);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(60, 20);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority";
            // 
            // cboPriority
            // 
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriority.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPriority.FormattingEnabled = true;
            cboPriority.Items.AddRange(new object[] { "Low", "Normal", "High", "Urgent" });
            cboPriority.Location = new Point(20, 125);
            cboPriority.Name = "cboPriority";
            cboPriority.Size = new Size(270, 28);
            cboPriority.TabIndex = 5;
            // 
            // lblAssignStaff
            // 
            lblAssignStaff.AutoSize = true;
            lblAssignStaff.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssignStaff.Location = new Point(320, 100);
            lblAssignStaff.Name = "lblAssignStaff";
            lblAssignStaff.Size = new Size(100, 20);
            lblAssignStaff.TabIndex = 6;
            lblAssignStaff.Text = "Assign Staff";
            // 
            // cboAssignStaff
            // 
            cboAssignStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAssignStaff.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAssignStaff.FormattingEnabled = true;
            cboAssignStaff.Location = new Point(320, 125);
            cboAssignStaff.Name = "cboAssignStaff";
            cboAssignStaff.Size = new Size(280, 28);
            cboAssignStaff.TabIndex = 7;
            // 
            // lblRequestDetails
            // 
            lblRequestDetails.AutoSize = true;
            lblRequestDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequestDetails.Location = new Point(20, 180);
            lblRequestDetails.Name = "lblRequestDetails";
            lblRequestDetails.Size = new Size(125, 20);
            lblRequestDetails.TabIndex = 8;
            lblRequestDetails.Text = "Request Details";
            // 
            // rtbRequestDetails
            // 
            rtbRequestDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbRequestDetails.Location = new Point(20, 205);
            rtbRequestDetails.Name = "rtbRequestDetails";
            rtbRequestDetails.Size = new Size(580, 160);
            rtbRequestDetails.TabIndex = 9;
            rtbRequestDetails.Text = "";
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRequest.Location = new Point(20, 390);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(580, 55);
            btnSubmitRequest.TabIndex = 10;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            // 
            // lblServiceRequestList
            // 
            lblServiceRequestList.AutoSize = true;
            lblServiceRequestList.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServiceRequestList.Location = new Point(680, 75);
            lblServiceRequestList.Name = "lblServiceRequestList";
            lblServiceRequestList.Size = new Size(180, 26);
            lblServiceRequestList.TabIndex = 2;
            lblServiceRequestList.Text = "Service Request List";
            // 
            // dgvServiceRequestList
            // 
            dgvServiceRequestList.AllowUserToAddRows = false;
            dgvServiceRequestList.AllowUserToDeleteRows = false;
            dgvServiceRequestList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServiceRequestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceRequestList.BackgroundColor = Color.White;
            dgvServiceRequestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceRequestList.Columns.AddRange(new DataGridViewColumn[] { colRequestID, colGuestName, colServiceType, colPriority, colAssignedStaff, colStatus });
            dgvServiceRequestList.Location = new Point(680, 110);
            dgvServiceRequestList.Name = "dgvServiceRequestList";
            dgvServiceRequestList.ReadOnly = true;
            dgvServiceRequestList.RowHeadersVisible = false;
            dgvServiceRequestList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceRequestList.Size = new Size(735, 820);
            dgvServiceRequestList.TabIndex = 3;
            // 
            // colRequestID
            // 
            colRequestID.HeaderText = "Request ID";
            colRequestID.Name = "colRequestID";
            colRequestID.ReadOnly = true;
            // 
            // colGuestName
            // 
            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.ReadOnly = true;
            // 
            // colServiceType
            // 
            colServiceType.HeaderText = "Service Type";
            colServiceType.Name = "colServiceType";
            colServiceType.ReadOnly = true;
            // 
            // colPriority
            // 
            colPriority.HeaderText = "Priority";
            colPriority.Name = "colPriority";
            colPriority.ReadOnly = true;
            // 
            // colAssignedStaff
            // 
            colAssignedStaff.HeaderText = "Assigned Staff";
            colAssignedStaff.Name = "colAssignedStaff";
            colAssignedStaff.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ConciergeGuestServicesUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvServiceRequestList);
            Controls.Add(lblServiceRequestList);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "ConciergeGuestServicesUserControl";
            Size = new Size(1445, 963);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiceRequestList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private Label lblTitle;
        private Label lblGuestName;
        private ComboBox cboGuestName;
        private Label lblServiceType;
        private ComboBox cboServiceType;
        private Label lblPriority;
        private ComboBox cboPriority;
        private Label lblAssignStaff;
        private ComboBox cboAssignStaff;
        private Label lblRequestDetails;
        private RichTextBox rtbRequestDetails;
        private Button btnSubmitRequest;
        private Label lblServiceRequestList;
        private DataGridView dgvServiceRequestList;
        private DataGridViewTextBoxColumn colRequestID;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colServiceType;
        private DataGridViewTextBoxColumn colPriority;
        private DataGridViewTextBoxColumn colAssignedStaff;
        private DataGridViewTextBoxColumn colStatus;
    }
}