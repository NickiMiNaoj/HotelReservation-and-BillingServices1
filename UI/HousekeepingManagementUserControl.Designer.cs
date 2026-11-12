namespace UI
{
    partial class HousekeepingManagementUserControl
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
            cboRoomNumber = new ComboBox();
            lblHousekeepingStatus = new Label();
            cboHousekeepingStatus = new ComboBox();
            lblAssignedStaff = new Label();
            cboAssignedStaff = new ComboBox();
            lblInspectionStatus = new Label();
            cboInspectionStatus = new ComboBox();
            btnUpdateStatus = new Button();
            lblHousekeepingList = new Label();
            dgvHousekeepingList = new DataGridView();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colHousekeepingStatus = new DataGridViewTextBoxColumn();
            colAssignedStaff = new DataGridViewTextBoxColumn();
            colInspectionStatus = new DataGridViewTextBoxColumn();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHousekeepingList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Housekeeping Management";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnUpdateStatus);
            pnlForm.Controls.Add(cboInspectionStatus);
            pnlForm.Controls.Add(lblInspectionStatus);
            pnlForm.Controls.Add(cboAssignedStaff);
            pnlForm.Controls.Add(lblAssignedStaff);
            pnlForm.Controls.Add(cboHousekeepingStatus);
            pnlForm.Controls.Add(lblHousekeepingStatus);
            pnlForm.Controls.Add(cboRoomNumber);
            pnlForm.Controls.Add(lblRoomNumber);
            pnlForm.Location = new Point(30, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(620, 270);
            pnlForm.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(20, 20);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(105, 20);
            lblRoomNumber.TabIndex = 0;
            lblRoomNumber.Text = "Room Number";
            // 
            // cboRoomNumber
            // 
            cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoomNumber.FormattingEnabled = true;
            cboRoomNumber.Location = new Point(20, 45);
            cboRoomNumber.Name = "cboRoomNumber";
            cboRoomNumber.Size = new Size(270, 28);
            cboRoomNumber.TabIndex = 1;
            // 
            // lblHousekeepingStatus
            // 
            lblHousekeepingStatus.AutoSize = true;
            lblHousekeepingStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHousekeepingStatus.Location = new Point(320, 20);
            lblHousekeepingStatus.Name = "lblHousekeepingStatus";
            lblHousekeepingStatus.Size = new Size(150, 20);
            lblHousekeepingStatus.TabIndex = 2;
            lblHousekeepingStatus.Text = "Housekeeping Status";
            // 
            // cboHousekeepingStatus
            // 
            cboHousekeepingStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHousekeepingStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboHousekeepingStatus.FormattingEnabled = true;
            cboHousekeepingStatus.Items.AddRange(new object[] { "Dirty", "Cleaning", "Clean", "Inspected" });
            cboHousekeepingStatus.Location = new Point(320, 45);
            cboHousekeepingStatus.Name = "cboHousekeepingStatus";
            cboHousekeepingStatus.Size = new Size(280, 28);
            cboHousekeepingStatus.TabIndex = 3;
            // 
            // lblAssignedStaff
            // 
            lblAssignedStaff.AutoSize = true;
            lblAssignedStaff.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssignedStaff.Location = new Point(20, 100);
            lblAssignedStaff.Name = "lblAssignedStaff";
            lblAssignedStaff.Size = new Size(115, 20);
            lblAssignedStaff.TabIndex = 4;
            lblAssignedStaff.Text = "Assigned Staff";
            // 
            // cboAssignedStaff
            // 
            cboAssignedStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAssignedStaff.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAssignedStaff.FormattingEnabled = true;
            cboAssignedStaff.Location = new Point(20, 125);
            cboAssignedStaff.Name = "cboAssignedStaff";
            cboAssignedStaff.Size = new Size(270, 28);
            cboAssignedStaff.TabIndex = 5;
            // 
            // lblInspectionStatus
            // 
            lblInspectionStatus.AutoSize = true;
            lblInspectionStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInspectionStatus.Location = new Point(320, 100);
            lblInspectionStatus.Name = "lblInspectionStatus";
            lblInspectionStatus.Size = new Size(135, 20);
            lblInspectionStatus.TabIndex = 6;
            lblInspectionStatus.Text = "Inspection Status";
            // 
            // cboInspectionStatus
            // 
            cboInspectionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInspectionStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboInspectionStatus.FormattingEnabled = true;
            cboInspectionStatus.Items.AddRange(new object[] { "Pending", "Passed", "Failed" });
            cboInspectionStatus.Location = new Point(320, 125);
            cboInspectionStatus.Name = "cboInspectionStatus";
            cboInspectionStatus.Size = new Size(280, 28);
            cboInspectionStatus.TabIndex = 7;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.Location = new Point(20, 190);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(580, 55);
            btnUpdateStatus.TabIndex = 8;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // lblHousekeepingList
            // 
            lblHousekeepingList.AutoSize = true;
            lblHousekeepingList.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHousekeepingList.Location = new Point(680, 75);
            lblHousekeepingList.Name = "lblHousekeepingList";
            lblHousekeepingList.Size = new Size(155, 26);
            lblHousekeepingList.TabIndex = 2;
            lblHousekeepingList.Text = "Housekeeping List";
            // 
            // dgvHousekeepingList
            // 
            dgvHousekeepingList.AllowUserToAddRows = false;
            dgvHousekeepingList.AllowUserToDeleteRows = false;
            dgvHousekeepingList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHousekeepingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHousekeepingList.BackgroundColor = Color.White;
            dgvHousekeepingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHousekeepingList.Columns.AddRange(new DataGridViewColumn[] { colRoomNumber, colHousekeepingStatus, colAssignedStaff, colInspectionStatus });
            dgvHousekeepingList.Location = new Point(680, 110);
            dgvHousekeepingList.Name = "dgvHousekeepingList";
            dgvHousekeepingList.ReadOnly = true;
            dgvHousekeepingList.RowHeadersVisible = false;
            dgvHousekeepingList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHousekeepingList.Size = new Size(735, 820);
            dgvHousekeepingList.TabIndex = 3;
            // 
            // colRoomNumber
            // 
            colRoomNumber.HeaderText = "Room Number";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colHousekeepingStatus
            // 
            colHousekeepingStatus.HeaderText = "Housekeeping Status";
            colHousekeepingStatus.Name = "colHousekeepingStatus";
            colHousekeepingStatus.ReadOnly = true;
            // 
            // colAssignedStaff
            // 
            colAssignedStaff.HeaderText = "Assigned Staff";
            colAssignedStaff.Name = "colAssignedStaff";
            colAssignedStaff.ReadOnly = true;
            // 
            // colInspectionStatus
            // 
            colInspectionStatus.HeaderText = "Inspection Status";
            colInspectionStatus.Name = "colInspectionStatus";
            colInspectionStatus.ReadOnly = true;
            // 
            // HousekeepingManagementUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvHousekeepingList);
            Controls.Add(lblHousekeepingList);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "HousekeepingManagementUserControl";
            Size = new Size(1445, 963);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHousekeepingList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private Label lblTitle;
        private Label lblRoomNumber;
        private ComboBox cboRoomNumber;
        private Label lblHousekeepingStatus;
        private ComboBox cboHousekeepingStatus;
        private Label lblAssignedStaff;
        private ComboBox cboAssignedStaff;
        private Label lblInspectionStatus;
        private ComboBox cboInspectionStatus;
        private Button btnUpdateStatus;
        private Label lblHousekeepingList;
        private DataGridView dgvHousekeepingList;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colHousekeepingStatus;
        private DataGridViewTextBoxColumn colAssignedStaff;
        private DataGridViewTextBoxColumn colInspectionStatus;
    }
}