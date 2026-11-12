namespace UI
{
    partial class CheckOutUserControl
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
            btnSearchLookup = new Button();
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
            panelActiveStays = new Panel();
            lblActiveTitle = new Label();
            lblSearchActive = new Label();
            txtSearchActive = new TextBox();
            btnSearchActiveIcon = new Button();
            dgvActiveStays = new DataGridView();
            btnSearchActive = new Button();
            btnClearActive = new Button();
            panelExecution = new Panel();
            lblExecTitle = new Label();
            lblTimeSelection = new Label();
            dtpTimeSelection = new DateTimePicker();
            lblActualOut = new Label();
            dtpActualOut = new DateTimePicker();
            lblFinVerif = new Label();
            txtFinVerif = new TextBox();
            lblChangeDue = new Label();
            txtChangeDue = new TextBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            btnFinalizeCheckout = new Button();
            btnPrintInvoice = new Button();
            btnGenerateReceipt = new Button();
            panelLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationLookup).BeginInit();
            panelVerification.SuspendLayout();
            panelActiveStays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveStays).BeginInit();
            panelExecution.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(570, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(218, 26);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Check-Out Execution";
            // 
            // panelLookup
            // 
            panelLookup.BackColor = Color.FromArgb(70, 130, 180);
            panelLookup.Controls.Add(lblLookupTitle);
            panelLookup.Controls.Add(lblSearchRes);
            panelLookup.Controls.Add(cmbSearchRes);
            panelLookup.Controls.Add(btnSearchIcon);
            panelLookup.Controls.Add(dgvReservationLookup);
            panelLookup.Controls.Add(btnSearchLookup);
            panelLookup.Controls.Add(btnClearLookup);
            panelLookup.Location = new Point(20, 60);
            panelLookup.Name = "panelLookup";
            panelLookup.Size = new Size(680, 347);
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
            dgvReservationLookup.Size = new Size(615, 169);
            dgvReservationLookup.TabIndex = 4;
            // 
            // btnSearchLookup
            // 
            btnSearchLookup.BackColor = Color.FromArgb(30, 42, 56);
            btnSearchLookup.FlatStyle = FlatStyle.Flat;
            btnSearchLookup.ForeColor = Color.White;
            btnSearchLookup.Location = new Point(180, 297);
            btnSearchLookup.Name = "btnSearchLookup";
            btnSearchLookup.Size = new Size(150, 35);
            btnSearchLookup.TabIndex = 5;
            btnSearchLookup.Text = "Search";
            btnSearchLookup.UseVisualStyleBackColor = false;
            // 
            // btnClearLookup
            // 
            btnClearLookup.BackColor = Color.FromArgb(30, 42, 56);
            btnClearLookup.FlatStyle = FlatStyle.Flat;
            btnClearLookup.ForeColor = Color.White;
            btnClearLookup.Location = new Point(345, 297);
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
            panelVerification.Location = new Point(720, 60);
            panelVerification.Name = "panelVerification";
            panelVerification.Size = new Size(691, 347);
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
            txtGuestName.Location = new Point(35, 55);
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
            lblKeyCard.Location = new Point(35, 105);
            lblKeyCard.Name = "lblKeyCard";
            lblKeyCard.Size = new Size(104, 15);
            lblKeyCard.TabIndex = 2;
            lblKeyCard.Text = "Key Card Number:";
            // 
            // txtKeyCard
            // 
            txtKeyCard.Location = new Point(35, 130);
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
            chkIdVerified.Location = new Point(35, 180);
            chkIdVerified.Name = "chkIdVerified";
            chkIdVerified.Size = new Size(112, 19);
            chkIdVerified.TabIndex = 4;
            chkIdVerified.Text = "Guest ID Verified";
            // 
            // chkKeyIssued
            // 
            chkKeyIssued.AutoSize = true;
            chkKeyIssued.ForeColor = Color.Black;
            chkKeyIssued.Location = new Point(380, 180);
            chkKeyIssued.Name = "chkKeyIssued";
            chkKeyIssued.Size = new Size(116, 19);
            chkKeyIssued.TabIndex = 5;
            chkKeyIssued.Text = "Room Key Issued";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblPaymentStatus.ForeColor = Color.Green;
            lblPaymentStatus.Location = new Point(74, 229);
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
            btnConfirmCheckIn.Location = new Point(173, 267);
            btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            btnConfirmCheckIn.Size = new Size(350, 42);
            btnConfirmCheckIn.TabIndex = 7;
            btnConfirmCheckIn.Text = "Confirm Check-In";
            btnConfirmCheckIn.UseVisualStyleBackColor = false;
            // 
            // panelActiveStays
            // 
            panelActiveStays.BackColor = Color.FromArgb(70, 130, 180);
            panelActiveStays.Controls.Add(lblActiveTitle);
            panelActiveStays.Controls.Add(lblSearchActive);
            panelActiveStays.Controls.Add(txtSearchActive);
            panelActiveStays.Controls.Add(btnSearchActiveIcon);
            panelActiveStays.Controls.Add(dgvActiveStays);
            panelActiveStays.Controls.Add(btnSearchActive);
            panelActiveStays.Controls.Add(btnClearActive);
            panelActiveStays.Location = new Point(20, 422);
            panelActiveStays.Name = "panelActiveStays";
            panelActiveStays.Size = new Size(680, 450);
            panelActiveStays.TabIndex = 1;
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.AutoSize = true;
            lblActiveTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblActiveTitle.ForeColor = Color.Black;
            lblActiveTitle.Location = new Point(220, 15);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(159, 20);
            lblActiveTitle.TabIndex = 0;
            lblActiveTitle.Text = "Check-Out Execution";
            // 
            // lblSearchActive
            // 
            lblSearchActive.AutoSize = true;
            lblSearchActive.ForeColor = Color.Black;
            lblSearchActive.Location = new Point(25, 48);
            lblSearchActive.Name = "lblSearchActive";
            lblSearchActive.Size = new Size(106, 15);
            lblSearchActive.TabIndex = 1;
            lblSearchActive.Text = "Search Active Stay:";
            // 
            // txtSearchActive
            // 
            txtSearchActive.Location = new Point(25, 70);
            txtSearchActive.Name = "txtSearchActive";
            txtSearchActive.Size = new Size(560, 23);
            txtSearchActive.TabIndex = 2;
            // 
            // btnSearchActiveIcon
            // 
            btnSearchActiveIcon.BackColor = Color.FromArgb(30, 42, 56);
            btnSearchActiveIcon.FlatStyle = FlatStyle.Flat;
            btnSearchActiveIcon.ForeColor = Color.White;
            btnSearchActiveIcon.Location = new Point(595, 68);
            btnSearchActiveIcon.Name = "btnSearchActiveIcon";
            btnSearchActiveIcon.Size = new Size(45, 26);
            btnSearchActiveIcon.TabIndex = 3;
            btnSearchActiveIcon.Text = "🔍";
            btnSearchActiveIcon.UseVisualStyleBackColor = false;
            // 
            // dgvActiveStays
            // 
            dgvActiveStays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveStays.Location = new Point(25, 105);
            dgvActiveStays.Name = "dgvActiveStays";
            dgvActiveStays.Size = new Size(615, 240);
            dgvActiveStays.TabIndex = 4;
            // 
            // btnSearchActive
            // 
            btnSearchActive.BackColor = Color.FromArgb(30, 42, 56);
            btnSearchActive.FlatStyle = FlatStyle.Flat;
            btnSearchActive.ForeColor = Color.White;
            btnSearchActive.Location = new Point(180, 375);
            btnSearchActive.Name = "btnSearchActive";
            btnSearchActive.Size = new Size(150, 35);
            btnSearchActive.TabIndex = 5;
            btnSearchActive.Text = "Search";
            btnSearchActive.UseVisualStyleBackColor = false;
            // 
            // btnClearActive
            // 
            btnClearActive.BackColor = Color.FromArgb(30, 42, 56);
            btnClearActive.FlatStyle = FlatStyle.Flat;
            btnClearActive.ForeColor = Color.White;
            btnClearActive.Location = new Point(345, 375);
            btnClearActive.Name = "btnClearActive";
            btnClearActive.Size = new Size(120, 35);
            btnClearActive.TabIndex = 6;
            btnClearActive.Text = "Clear";
            btnClearActive.UseVisualStyleBackColor = false;
            // 
            // panelExecution
            // 
            panelExecution.BackColor = Color.FromArgb(70, 130, 180);
            panelExecution.Controls.Add(lblExecTitle);
            panelExecution.Controls.Add(lblTimeSelection);
            panelExecution.Controls.Add(dtpTimeSelection);
            panelExecution.Controls.Add(lblActualOut);
            panelExecution.Controls.Add(dtpActualOut);
            panelExecution.Controls.Add(lblFinVerif);
            panelExecution.Controls.Add(txtFinVerif);
            panelExecution.Controls.Add(lblChangeDue);
            panelExecution.Controls.Add(txtChangeDue);
            panelExecution.Controls.Add(lblRemarks);
            panelExecution.Controls.Add(txtRemarks);
            panelExecution.Controls.Add(btnFinalizeCheckout);
            panelExecution.Controls.Add(btnPrintInvoice);
            panelExecution.Controls.Add(btnGenerateReceipt);
            panelExecution.Location = new Point(720, 422);
            panelExecution.Name = "panelExecution";
            panelExecution.Size = new Size(691, 450);
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
            // lblTimeSelection
            // 
            lblTimeSelection.AutoSize = true;
            lblTimeSelection.ForeColor = Color.Black;
            lblTimeSelection.Location = new Point(35, 45);
            lblTimeSelection.Name = "lblTimeSelection";
            lblTimeSelection.Size = new Size(146, 15);
            lblTimeSelection.TabIndex = 1;
            lblTimeSelection.Text = "Check-Out Time Selection";
            // 
            // dtpTimeSelection
            // 
            dtpTimeSelection.CustomFormat = "D/M/Y 2022 HH:MM";
            dtpTimeSelection.Format = DateTimePickerFormat.Custom;
            dtpTimeSelection.Location = new Point(35, 68);
            dtpTimeSelection.Name = "dtpTimeSelection";
            dtpTimeSelection.Size = new Size(300, 23);
            dtpTimeSelection.TabIndex = 2;
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
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.ForeColor = Color.Black;
            lblRemarks.Location = new Point(35, 165);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(113, 15);
            lblRemarks.TabIndex = 9;
            lblRemarks.Text = "Check-Out Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(35, 188);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(635, 23);
            txtRemarks.TabIndex = 10;
            // 
            // btnFinalizeCheckout
            // 
            btnFinalizeCheckout.BackColor = Color.FromArgb(197, 160, 89);
            btnFinalizeCheckout.FlatStyle = FlatStyle.Flat;
            btnFinalizeCheckout.Font = new Font("Microsoft Sans Serif", 9F);
            btnFinalizeCheckout.Location = new Point(200, 240);
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
            btnPrintInvoice.Location = new Point(35, 300);
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
            btnGenerateReceipt.Location = new Point(365, 300);
            btnGenerateReceipt.Name = "btnGenerateReceipt";
            btnGenerateReceipt.Size = new Size(305, 35);
            btnGenerateReceipt.TabIndex = 13;
            btnGenerateReceipt.Text = "Generate Receipt";
            btnGenerateReceipt.UseVisualStyleBackColor = false;
            // 
            // CheckOutUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 196, 222);
            Controls.Add(panelExecution);
            Controls.Add(panelActiveStays);
            Controls.Add(panelVerification);
            Controls.Add(panelLookup);
            Controls.Add(lblTitle);
            Name = "CheckOutUserControl";
            Size = new Size(1426, 886);
            panelLookup.ResumeLayout(false);
            panelLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationLookup).EndInit();
            panelVerification.ResumeLayout(false);
            panelVerification.PerformLayout();
            panelActiveStays.ResumeLayout(false);
            panelActiveStays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveStays).EndInit();
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
        private System.Windows.Forms.Button btnSearchLookup;
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
        private System.Windows.Forms.Panel panelActiveStays;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblSearchActive;
        private System.Windows.Forms.TextBox txtSearchActive;
        private System.Windows.Forms.Button btnSearchActiveIcon;
        private System.Windows.Forms.DataGridView dgvActiveStays;
        private System.Windows.Forms.Button btnSearchActive;
        private System.Windows.Forms.Button btnClearActive;
        private System.Windows.Forms.Panel panelExecution;
        private System.Windows.Forms.Label lblExecTitle;
        private System.Windows.Forms.Label lblTimeSelection;
        private System.Windows.Forms.DateTimePicker dtpTimeSelection;
        private System.Windows.Forms.Label lblActualOut;
        private System.Windows.Forms.DateTimePicker dtpActualOut;
        private System.Windows.Forms.Label lblFinVerif;
        private System.Windows.Forms.TextBox txtFinVerif;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.TextBox txtChangeDue;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnFinalizeCheckout;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnGenerateReceipt;
    }
}