namespace UI
{
    partial class ReportsAnalyticsUserControl
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
            pnlFilters = new Panel();
            lblTitle = new Label();
            lblReportType = new Label();
            cboReportType = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            btnExportToPDF = new Button();
            btnPrintReport = new Button();
            lblRevenueSummary = new Label();
            lblReservationReport = new Label();
            dgvReservationReport = new DataGridView();
            colReservationID = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationReport).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports and Analytics";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(btnPrintReport);
            pnlFilters.Controls.Add(btnExportToPDF);
            pnlFilters.Controls.Add(btnGenerateReport);
            pnlFilters.Controls.Add(dtpEndDate);
            pnlFilters.Controls.Add(lblEndDate);
            pnlFilters.Controls.Add(dtpStartDate);
            pnlFilters.Controls.Add(lblStartDate);
            pnlFilters.Controls.Add(cboReportType);
            pnlFilters.Controls.Add(lblReportType);
            pnlFilters.Location = new Point(30, 70);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1385, 100);
            pnlFilters.TabIndex = 1;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportType.Location = new Point(20, 15);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(95, 20);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "Report Type";
            // 
            // cboReportType
            // 
            cboReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReportType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboReportType.FormattingEnabled = true;
            cboReportType.Items.AddRange(new object[] { "Revenue Report", "Reservation Report", "Occupancy Report", "Guest Report" });
            cboReportType.Location = new Point(20, 40);
            cboReportType.Name = "cboReportType";
            cboReportType.Size = new Size(280, 28);
            cboReportType.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(330, 15);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(80, 20);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(330, 40);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(190, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(550, 15);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(70, 20);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(550, 40);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(190, 27);
            dtpEndDate.TabIndex = 5;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(770, 30);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(190, 50);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnExportToPDF
            // 
            btnExportToPDF.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportToPDF.Location = new Point(975, 30);
            btnExportToPDF.Name = "btnExportToPDF";
            btnExportToPDF.Size = new Size(190, 50);
            btnExportToPDF.TabIndex = 7;
            btnExportToPDF.Text = "Export to PDF";
            btnExportToPDF.UseVisualStyleBackColor = true;
            // 
            // btnPrintReport
            // 
            btnPrintReport.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReport.Location = new Point(1180, 30);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(185, 50);
            btnPrintReport.TabIndex = 8;
            btnPrintReport.Text = "Print Report";
            btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // lblRevenueSummary
            // 
            lblRevenueSummary.AutoSize = true;
            lblRevenueSummary.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueSummary.Location = new Point(30, 190);
            lblRevenueSummary.Name = "lblRevenueSummary";
            lblRevenueSummary.Size = new Size(160, 26);
            lblRevenueSummary.TabIndex = 2;
            lblRevenueSummary.Text = "Revenue Summary";
            // 
            // lblReservationReport
            // 
            lblReservationReport.AutoSize = true;
            lblReservationReport.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationReport.Location = new Point(680, 190);
            lblReservationReport.Name = "lblReservationReport";
            lblReservationReport.Size = new Size(175, 26);
            lblReservationReport.TabIndex = 4;
            lblReservationReport.Text = "Reservation Report";
            // 
            // dgvReservationReport
            // 
            dgvReservationReport.AllowUserToAddRows = false;
            dgvReservationReport.AllowUserToDeleteRows = false;
            dgvReservationReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservationReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationReport.BackgroundColor = Color.White;
            dgvReservationReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationReport.Columns.AddRange(new DataGridViewColumn[] { colReservationID, colGuestName, colRoomNumber, colCheckIn, colCheckOut, colTotalAmount });
            dgvReservationReport.Location = new Point(680, 225);
            dgvReservationReport.Name = "dgvReservationReport";
            dgvReservationReport.ReadOnly = true;
            dgvReservationReport.RowHeadersVisible = false;
            dgvReservationReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservationReport.Size = new Size(735, 705);
            dgvReservationReport.TabIndex = 5;
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
            // colCheckIn
            // 
            colCheckIn.HeaderText = "Check-In";
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            colCheckOut.HeaderText = "Check-Out";
            colCheckOut.Name = "colCheckOut";
            colCheckOut.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.HeaderText = "Total Amount";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // ReportsAnalyticsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvReservationReport);
            Controls.Add(lblReservationReport);
            Controls.Add(lblRevenueSummary);
            Controls.Add(pnlFilters);
            Controls.Add(lblTitle);
            Name = "ReportsAnalyticsUserControl";
            Size = new Size(1445, 963);
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFilters;
        private Label lblTitle;
        private Label lblReportType;
        private ComboBox cboReportType;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Button btnGenerateReport;
        private Button btnExportToPDF;
        private Button btnPrintReport;
        private Label lblRevenueSummary;
        private Label lblReservationReport;
        private DataGridView dgvReservationReport;
        private DataGridViewTextBoxColumn colReservationID;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colCheckIn;
        private DataGridViewTextBoxColumn colCheckOut;
        private DataGridViewTextBoxColumn colTotalAmount;
    }
}