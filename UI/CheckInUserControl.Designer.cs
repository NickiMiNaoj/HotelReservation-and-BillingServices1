namespace UI
{
    partial class CheckInUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            panelLookup = new Panel();
            lblLookupTitle = new Label();
            lblSearchRes = new Label();
            cmbSearchRes = new ComboBox();
            btnSearchIcon = new Button();
            dgvReservationLookup = new DataGridView();
            btnSearch = new Button();
            btnClearLookup = new Button();
            panelVerification = new Panel();
            lblVerifTitle = new Label();
            txtGuestName = new TextBox();
            lblKeyCard = new Label();
            txtKeyCard = new TextBox();
            chkIdVerified = new CheckBox();
            chkKeyIssued = new CheckBox();
            lblPaymentStatus = new Label();
            btnConfirmCheckIn = new Button();
            panelArrival = new Panel();
            lblArrivalTitle = new Label();
            lblCheckInTime = new Label();
            dtpCheckInTime = new DateTimePicker();
            lblConfirmOutTime = new Label();
            dtpConfirmOutTime = new DateTimePicker();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            panelExecution = new Panel();
            lblExecTitle = new Label();
            lblExpectedOut = new Label();
            dtpExpectedOut = new DateTimePicker();
            lblActualOut = new Label();
            dtpActualOut = new DateTimePicker();
            lblFinVerif = new Label();
            txtFinVerif = new TextBox();
            lblChangeDue = new Label();
            txtChangeDue = new TextBox();
            lblExecRemarks = new Label();
            txtExecRemarks = new TextBox();
            btnFinalizeCheckout = new Button();
            btnPrintInvoice = new Button();
            btnGenerateReceipt = new Button();
            panelLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationLookup).BeginInit();
            panelVerification.SuspendLayout();
            panelArrival.SuspendLayout();
            panelExecution.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(589, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 26);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Check-In Execution";
            // 
            // panelLookup
            // 
            panelLookup.BackColor = Color.FromArgb(70, 130, 180);
            panelLookup.Controls.Add(lblLookupTitle);
            panelLookup.Controls.Add(lblSearchRes);
            panelLookup.Controls.Add(cmbSearchRes);
            panelLookup.Controls.Add(btnSearchIcon);
            panelLookup.Controls.Add(dgvReservationLookup);
            panelLookup.Controls.Add(btnSearch);
            panelLookup.Controls.Add(btnClearLookup);
            panelLookup.Location = new Point(29, 55);
            panelLookup.Name = "panelLookup";
            panelLookup.Size = new Size(657, 409);
            panelLookup.TabIndex = 3;
            // 
            // lblLookupTitle
            // 
            lblLookupTitle.AutoSize = true;
            lblLookupTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblLookupTitle.ForeColor = Color.Black;
            lblLookupTitle.Location = new Point(220, 15);
            lblLookupTitle.Name = "lblLookupTitle";
            lblLookupTitle.Size = new Size(168, 20);
            lblLookupTitle.TabIndex = 0;
            lblLookupTitle.Text = "1. Reservation Lookup";
            // 
            // lblSearchRes
            // 
            lblSearchRes.AutoSize = true;
            lblSearchRes.ForeColor = Color.Black;
            lblSearchRes.Location = new Point(25, 55);
            lblSearchRes.Name = "lblSearchRes";
            lblSearchRes.Size = new Size(109, 15);
            lblSearchRes.TabIndex = 1;
            lblSearchRes.Text = "Search Reservation:";
            // 
            // cmbSearchRes
            // 
            cmbSearchRes.FormattingEnabled = true;
            cmbSearchRes.Location = new Point(25, 78);
            cmbSearchRes.Name = "cmbSearchRes";
            cmbSearchRes.Size = new Size(560, 23);
            cmbSearchRes.TabIndex = 2;
            // 
            // btnSearchIcon
            // 
            btnSearchIcon.BackColor = Color.FromArgb(30, 42, 56);
            btnSearchIcon.FlatStyle = FlatStyle.Flat;
            btnSearchIcon.ForeColor = Color.White;
            btnSearchIcon.Location = new Point(595, 75);
            btnSearchIcon.Name = "btnSearchIcon";
            btnSearchIcon.Size = new Size(45, 28);
            btnSearchIcon.TabIndex = 3;
            btnSearchIcon.Text = "🔍";
            btnSearchIcon.UseVisualStyleBackColor = false;
            // 
            // dgvReservationLookup
            // 
            dgvReservationLookup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationLookup.Location = new Point(25, 115);
            dgvReservationLookup.Name = "dgvReservationLookup";
            dgvReservationLookup.Size = new Size(615, 230);
            dgvReservationLookup.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 42, 56);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(180, 360);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 35);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClearLookup
            // 
            btnClearLookup.BackColor = Color.FromArgb(30, 42, 56);
            btnClearLookup.FlatStyle = FlatStyle.Flat;
            btnClearLookup.ForeColor = Color.White;
            btnClearLookup.Location = new Point(345, 360);
            btnClearLookup.Name = "btnClearLookup";
            btnClearLookup.Size = new Size(120, 35);
            btnClearLookup.TabIndex = 6;
            btnClearLookup.Text = "Clear";
            btnClearLookup.UseVisualStyleBackColor = false;
            // 
            // panelVerification
            // 
            panelVerification.BackColor = Color.FromArgb(70, 130, 180);
            panelVerification.Controls.Add(lblVerifTitle);
            panelVerification.Controls.Add(txtGuestName);
            panelVerification.Controls.Add(lblKeyCard);
            panelVerification.Controls.Add(txtKeyCard);
            panelVerification.Controls.Add(chkIdVerified);
            panelVerification.Controls.Add(chkKeyIssued);
            panelVerification.Controls.Add(lblPaymentStatus);
            panelVerification.Controls.Add(btnConfirmCheckIn);
            panelVerification.Location = new Point(714, 55);
            panelVerification.Name = "panelVerification";
            panelVerification.Size = new Size(684, 409);
            panelVerification.TabIndex = 2;
            // 
            // lblVerifTitle
            // 
            lblVerifTitle.AutoSize = true;
            lblVerifTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblVerifTitle.ForeColor = Color.Black;
            lblVerifTitle.Location = new Point(220, 15);
            lblVerifTitle.Name = "lblVerifTitle";
            lblVerifTitle.Size = new Size(177, 20);
            lblVerifTitle.TabIndex = 0;
            lblVerifTitle.Text = "2. Verification & Key Card";
            // 
            // txtGuestName
            // 
            txtGuestName.BackColor = Color.FromArgb(220, 220, 220);
            txtGuestName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
            txtGuestName.Location = new Point(35, 64);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(635, 24);
            txtGuestName.TabIndex = 1;
            txtGuestName.Text = "Guest Name";
            txtGuestName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblKeyCard
            // 
            lblKeyCard.AutoSize = true;
            lblKeyCard.ForeColor = Color.Black;
            lblKeyCard.Location = new Point(35, 114);
            lblKeyCard.Name = "lblKeyCard";
            lblKeyCard.Size = new Size(104, 15);
            lblKeyCard.TabIndex = 2;
            lblKeyCard.Text = "Key Card Number:";
            // 
            // txtKeyCard
            // 
            txtKeyCard.Location = new Point(35, 139);
            txtKeyCard.Name = "txtKeyCard";
            txtKeyCard.Size = new Size(635, 23);
            txtKeyCard.TabIndex = 3;
            // 
            // chkIdVerified
            // 
            chkIdVerified.AutoSize = true;
            chkIdVerified.Checked = true;
            chkIdVerified.CheckState = CheckState.Checked;
            chkIdVerified.ForeColor = Color.Black;
            chkIdVerified.Location = new Point(36, 209);
            chkIdVerified.Name = "chkIdVerified";
            chkIdVerified.Size = new Size(112, 19);
            chkIdVerified.TabIndex = 4;
            chkIdVerified.Text = "Guest ID Verified";
            // 
            // chkKeyIssued
            // 
            chkKeyIssued.AutoSize = true;
            chkKeyIssued.ForeColor = Color.Black;
            chkKeyIssued.Location = new Point(381, 209);
            chkKeyIssued.Name = "chkKeyIssued";
            chkKeyIssued.Size = new Size(116, 19);
            chkKeyIssued.TabIndex = 5;
            chkKeyIssued.Text = "Room Key Issued";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblPaymentStatus.ForeColor = Color.LawnGreen;
            lblPaymentStatus.Location = new Point(94, 267);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(312, 17);
            lblPaymentStatus.TabIndex = 6;
            lblPaymentStatus.Text = "Payment Clearance Status:   CLEARED ✔";
            // 
            // btnConfirmCheckIn
            // 
            btnConfirmCheckIn.BackColor = Color.FromArgb(85, 107, 47);
            btnConfirmCheckIn.FlatStyle = FlatStyle.Flat;
            btnConfirmCheckIn.Font = new Font("Microsoft Sans Serif", 10F);
            btnConfirmCheckIn.ForeColor = Color.White;
            btnConfirmCheckIn.Location = new Point(176, 330);
            btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            btnConfirmCheckIn.Size = new Size(350, 42);
            btnConfirmCheckIn.TabIndex = 7;
            btnConfirmCheckIn.Text = "Confirm Check-In";
            btnConfirmCheckIn.UseVisualStyleBackColor = false;
            // 
            // panelArrival
            // 
            panelArrival.BackColor = Color.FromArgb(70, 130, 180);
            panelArrival.Controls.Add(lblArrivalTitle);
            panelArrival.Controls.Add(lblCheckInTime);
            panelArrival.Controls.Add(dtpCheckInTime);
            panelArrival.Controls.Add(lblConfirmOutTime);
            panelArrival.Controls.Add(dtpConfirmOutTime);
            panelArrival.Controls.Add(lblRemarks);
            panelArrival.Controls.Add(txtRemarks);
            panelArrival.Location = new Point(29, 472);
            panelArrival.Name = "panelArrival";
            panelArrival.Size = new Size(657, 384);
            panelArrival.TabIndex = 1;
            // 
            // lblArrivalTitle
            // 
            lblArrivalTitle.AutoSize = true;
            lblArrivalTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblArrivalTitle.ForeColor = Color.Black;
            lblArrivalTitle.Location = new Point(220, 15);
            lblArrivalTitle.Name = "lblArrivalTitle";
            lblArrivalTitle.Size = new Size(159, 20);
            lblArrivalTitle.TabIndex = 0;
            lblArrivalTitle.Text = "Check-Out Execution";
            // 
            // lblCheckInTime
            // 
            lblCheckInTime.AutoSize = true;
            lblCheckInTime.ForeColor = Color.Black;
            lblCheckInTime.Location = new Point(25, 50);
            lblCheckInTime.Name = "lblCheckInTime";
            lblCheckInTime.Size = new Size(106, 15);
            lblCheckInTime.TabIndex = 1;
            lblCheckInTime.Text = "Search Active Stay:";
            // 
            // dtpCheckInTime
            // 
            dtpCheckInTime.CustomFormat = "D/M/Y 2022 HH:MM";
            dtpCheckInTime.Format = DateTimePickerFormat.Custom;
            dtpCheckInTime.Location = new Point(25, 75);
            dtpCheckInTime.Name = "dtpCheckInTime";
            dtpCheckInTime.Size = new Size(280, 23);
            dtpCheckInTime.TabIndex = 2;
            // 
            // lblConfirmOutTime
            // 
            lblConfirmOutTime.AutoSize = true;
            lblConfirmOutTime.ForeColor = Color.Black;
            lblConfirmOutTime.Location = new Point(340, 50);
            lblConfirmOutTime.Name = "lblConfirmOutTime";
            lblConfirmOutTime.Size = new Size(142, 15);
            lblConfirmOutTime.TabIndex = 3;
            lblConfirmOutTime.Text = "Confirm Check-Out Time";
            // 
            // dtpConfirmOutTime
            // 
            dtpConfirmOutTime.CustomFormat = "D/M/Y 2022 HH:MM";
            dtpConfirmOutTime.Format = DateTimePickerFormat.Custom;
            dtpConfirmOutTime.Location = new Point(340, 75);
            dtpConfirmOutTime.Name = "dtpConfirmOutTime";
            dtpConfirmOutTime.Size = new Size(300, 23);
            dtpConfirmOutTime.TabIndex = 4;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.ForeColor = Color.Black;
            lblRemarks.Location = new Point(25, 120);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(105, 15);
            lblRemarks.TabIndex = 5;
            lblRemarks.Text = "Remarks (Options)";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(25, 145);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(615, 200);
            txtRemarks.TabIndex = 6;
            // 
            // panelExecution
            // 
            panelExecution.BackColor = Color.FromArgb(70, 130, 180);
            panelExecution.Controls.Add(lblExecTitle);
            panelExecution.Controls.Add(lblExpectedOut);
            panelExecution.Controls.Add(dtpExpectedOut);
            panelExecution.Controls.Add(lblActualOut);
            panelExecution.Controls.Add(dtpActualOut);
            panelExecution.Controls.Add(lblFinVerif);
            panelExecution.Controls.Add(txtFinVerif);
            panelExecution.Controls.Add(lblChangeDue);
            panelExecution.Controls.Add(txtChangeDue);
            panelExecution.Controls.Add(lblExecRemarks);
            panelExecution.Controls.Add(txtExecRemarks);
            panelExecution.Controls.Add(btnFinalizeCheckout);
            panelExecution.Controls.Add(btnPrintInvoice);
            panelExecution.Controls.Add(btnGenerateReceipt);
            panelExecution.Location = new Point(714, 471);
            panelExecution.Name = "panelExecution";
            panelExecution.Size = new Size(684, 385);
            panelExecution.TabIndex = 0;
            // 
            // lblExecTitle
            // 
            lblExecTitle.AutoSize = true;
            lblExecTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblExecTitle.ForeColor = Color.Black;
            lblExecTitle.Location = new Point(220, 15);
            lblExecTitle.Name = "lblExecTitle";
            lblExecTitle.Size = new Size(176, 20);
            lblExecTitle.TabIndex = 0;
            lblExecTitle.Text = "4. Check-Out Execution";
            // 
            // lblExpectedOut
            // 
            lblExpectedOut.AutoSize = true;
            lblExpectedOut.ForeColor = Color.Black;
            lblExpectedOut.Location = new Point(35, 45);
            lblExpectedOut.Name = "lblExpectedOut";
            lblExpectedOut.Size = new Size(146, 15);
            lblExpectedOut.TabIndex = 1;
            lblExpectedOut.Text = "Check-Out Time Selection";
            // 
            // dtpExpectedOut
            // 
            dtpExpectedOut.CustomFormat = "D/M/Y 2022 HH:MM";
            dtpExpectedOut.Format = DateTimePickerFormat.Custom;
            dtpExpectedOut.Location = new Point(35, 68);
            dtpExpectedOut.Name = "dtpExpectedOut";
            dtpExpectedOut.Size = new Size(300, 23);
            dtpExpectedOut.TabIndex = 2;
            // 
            // lblActualOut
            // 
            lblActualOut.AutoSize = true;
            lblActualOut.ForeColor = Color.Black;
            lblActualOut.Location = new Point(365, 45);
            lblActualOut.Name = "lblActualOut";
            lblActualOut.Size = new Size(132, 15);
            lblActualOut.TabIndex = 3;
            lblActualOut.Text = "Actual Check-Out Time";
            // 
            // dtpActualOut
            // 
            dtpActualOut.CustomFormat = "D/M/Y 2022 HH:MM";
            dtpActualOut.Format = DateTimePickerFormat.Custom;
            dtpActualOut.Location = new Point(365, 68);
            dtpActualOut.Name = "dtpActualOut";
            dtpActualOut.Size = new Size(305, 23);
            dtpActualOut.TabIndex = 4;
            // 
            // lblFinVerif
            // 
            lblFinVerif.AutoSize = true;
            lblFinVerif.ForeColor = Color.Black;
            lblFinVerif.Location = new Point(35, 105);
            lblFinVerif.Name = "lblFinVerif";
            lblFinVerif.Size = new Size(128, 15);
            lblFinVerif.TabIndex = 5;
            lblFinVerif.Text = "3. Financial Verification";
            // 
            // txtFinVerif
            // 
            txtFinVerif.BackColor = Color.FromArgb(220, 220, 220);
            txtFinVerif.Location = new Point(35, 128);
            txtFinVerif.Name = "txtFinVerif";
            txtFinVerif.Size = new Size(300, 23);
            txtFinVerif.TabIndex = 6;
            txtFinVerif.Text = "0.00";
            // 
            // lblChangeDue
            // 
            lblChangeDue.AutoSize = true;
            lblChangeDue.ForeColor = Color.Black;
            lblChangeDue.Location = new Point(365, 105);
            lblChangeDue.Name = "lblChangeDue";
            lblChangeDue.Size = new Size(72, 15);
            lblChangeDue.TabIndex = 7;
            lblChangeDue.Text = "Change Due";
            // 
            // txtChangeDue
            // 
            txtChangeDue.BackColor = Color.FromArgb(220, 220, 220);
            txtChangeDue.Location = new Point(365, 128);
            txtChangeDue.Name = "txtChangeDue";
            txtChangeDue.Size = new Size(305, 23);
            txtChangeDue.TabIndex = 8;
            txtChangeDue.Text = "0.00";
            // 
            // lblExecRemarks
            // 
            lblExecRemarks.AutoSize = true;
            lblExecRemarks.ForeColor = Color.Black;
            lblExecRemarks.Location = new Point(35, 165);
            lblExecRemarks.Name = "lblExecRemarks";
            lblExecRemarks.Size = new Size(113, 15);
            lblExecRemarks.TabIndex = 9;
            lblExecRemarks.Text = "Check-Out Remarks";
            // 
            // txtExecRemarks
            // 
            txtExecRemarks.Location = new Point(35, 188);
            txtExecRemarks.Name = "txtExecRemarks";
            txtExecRemarks.Size = new Size(635, 23);
            txtExecRemarks.TabIndex = 10;
            // 
            // btnFinalizeCheckout
            // 
            btnFinalizeCheckout.BackColor = Color.FromArgb(197, 160, 89);
            btnFinalizeCheckout.FlatStyle = FlatStyle.Flat;
            btnFinalizeCheckout.Font = new Font("Microsoft Sans Serif", 9F);
            btnFinalizeCheckout.Location = new Point(200, 255);
            btnFinalizeCheckout.Name = "btnFinalizeCheckout";
            btnFinalizeCheckout.Size = new Size(300, 35);
            btnFinalizeCheckout.TabIndex = 11;
            btnFinalizeCheckout.Text = "Finalize Check-Out";
            btnFinalizeCheckout.UseVisualStyleBackColor = false;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.FromArgb(30, 42, 56);
            btnPrintInvoice.FlatStyle = FlatStyle.Flat;
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(35, 315);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(300, 35);
            btnPrintInvoice.TabIndex = 12;
            btnPrintInvoice.Text = "Print Final Invoice";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            // 
            // btnGenerateReceipt
            // 
            btnGenerateReceipt.BackColor = Color.FromArgb(30, 42, 56);
            btnGenerateReceipt.FlatStyle = FlatStyle.Flat;
            btnGenerateReceipt.ForeColor = Color.White;
            btnGenerateReceipt.Location = new Point(365, 315);
            btnGenerateReceipt.Name = "btnGenerateReceipt";
            btnGenerateReceipt.Size = new Size(305, 35);
            btnGenerateReceipt.TabIndex = 13;
            btnGenerateReceipt.Text = "Generate Receipt";
            btnGenerateReceipt.UseVisualStyleBackColor = false;
            // 
            // CheckInUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 196, 222);
            Controls.Add(panelExecution);
            Controls.Add(panelArrival);
            Controls.Add(panelVerification);
            Controls.Add(panelLookup);
            Controls.Add(lblTitle);
            Name = "CheckInUserControl";
            Size = new Size(1426, 886);
            panelLookup.ResumeLayout(false);
            panelLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationLookup).EndInit();
            panelVerification.ResumeLayout(false);
            panelVerification.PerformLayout();
            panelArrival.ResumeLayout(false);
            panelArrival.PerformLayout();
            panelExecution.ResumeLayout(false);
            panelExecution.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLookup;
        private System.Windows.Forms.Label lblLookupTitle;
        private System.Windows.Forms.Label lblSearchRes;
        private System.Windows.Forms.ComboBox cmbSearchRes;
        private System.Windows.Forms.Button btnSearchIcon;
        private System.Windows.Forms.DataGridView dgvReservationLookup;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearLookup;
        private System.Windows.Forms.Panel panelVerification;
        private System.Windows.Forms.Label lblVerifTitle;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblKeyCard;
        private System.Windows.Forms.TextBox txtKeyCard;
        private System.Windows.Forms.CheckBox chkIdVerified;
        private System.Windows.Forms.CheckBox chkKeyIssued;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Button btnConfirmCheckIn;
        private System.Windows.Forms.Panel panelArrival;
        private System.Windows.Forms.Label lblArrivalTitle;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.Label lblConfirmOutTime;
        private System.Windows.Forms.DateTimePicker dtpConfirmOutTime;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Panel panelExecution;
        private System.Windows.Forms.Label lblExecTitle;
        private System.Windows.Forms.Label lblExpectedOut;
        private System.Windows.Forms.DateTimePicker dtpExpectedOut;
        private System.Windows.Forms.Label lblActualOut;
        private System.Windows.Forms.DateTimePicker dtpActualOut;
        private System.Windows.Forms.Label lblFinVerif;
        private System.Windows.Forms.TextBox txtFinVerif;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.TextBox txtChangeDue;
        private System.Windows.Forms.Label lblExecRemarks;
        private System.Windows.Forms.TextBox txtExecRemarks;
        private System.Windows.Forms.Button btnFinalizeCheckout;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnGenerateReceipt;
    }
}