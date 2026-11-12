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
            panelLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationLookup).BeginInit();
            panelVerification.SuspendLayout();
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
            panelLookup.Size = new Size(657, 813);
            panelLookup.TabIndex = 3;
            // 
            // lblLookupTitle
            // 
            lblLookupTitle.AutoSize = true;
            lblLookupTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblLookupTitle.ForeColor = Color.Black;
            lblLookupTitle.Location = new Point(220, 15);
            lblLookupTitle.Name = "lblLookupTitle";
            lblLookupTitle.Size = new Size(249, 25);
            lblLookupTitle.TabIndex = 0;
            lblLookupTitle.Text = "1. Reservation Lookup";
            // 
            // lblSearchRes
            // 
            lblSearchRes.AutoSize = true;
            lblSearchRes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblSearchRes.ForeColor = Color.Black;
            lblSearchRes.Location = new Point(25, 55);
            lblSearchRes.Name = "lblSearchRes";
            lblSearchRes.Size = new Size(226, 25);
            lblSearchRes.TabIndex = 1;
            lblSearchRes.Text = "Search Reservation:";
            // 
            // cmbSearchRes
            // 
            cmbSearchRes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            cmbSearchRes.FormattingEnabled = true;
            cmbSearchRes.Location = new Point(23, 102);
            cmbSearchRes.Name = "cmbSearchRes";
            cmbSearchRes.Size = new Size(560, 33);
            cmbSearchRes.TabIndex = 2;
            // 
            // btnSearchIcon
            // 
            btnSearchIcon.BackColor = Color.FromArgb(30, 42, 56);
            btnSearchIcon.FlatStyle = FlatStyle.Flat;
            btnSearchIcon.ForeColor = Color.White;
            btnSearchIcon.Location = new Point(593, 102);
            btnSearchIcon.Name = "btnSearchIcon";
            btnSearchIcon.Size = new Size(45, 33);
            btnSearchIcon.TabIndex = 3;
            btnSearchIcon.Text = "🔍";
            btnSearchIcon.UseVisualStyleBackColor = false;
            // 
            // dgvReservationLookup
            // 
            dgvReservationLookup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationLookup.Location = new Point(23, 166);
            dgvReservationLookup.Name = "dgvReservationLookup";
            dgvReservationLookup.Size = new Size(615, 495);
            dgvReservationLookup.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 42, 56);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(184, 696);
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
            btnClearLookup.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnClearLookup.ForeColor = Color.White;
            btnClearLookup.Location = new Point(349, 696);
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
            panelVerification.Size = new Size(684, 813);
            panelVerification.TabIndex = 2;
            // 
            // lblVerifTitle
            // 
            lblVerifTitle.AutoSize = true;
            lblVerifTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblVerifTitle.ForeColor = Color.Black;
            lblVerifTitle.Location = new Point(261, 115);
            lblVerifTitle.Name = "lblVerifTitle";
            lblVerifTitle.Size = new Size(269, 25);
            lblVerifTitle.TabIndex = 0;
            lblVerifTitle.Text = "2. Verification & Key Card";
            // 
            // txtGuestName
            // 
            txtGuestName.BackColor = Color.FromArgb(220, 220, 220);
            txtGuestName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtGuestName.Location = new Point(37, 166);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(635, 31);
            txtGuestName.TabIndex = 1;
            txtGuestName.Text = "Guest Name";
            txtGuestName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblKeyCard
            // 
            lblKeyCard.AutoSize = true;
            lblKeyCard.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeyCard.ForeColor = Color.Black;
            lblKeyCard.Location = new Point(37, 256);
            lblKeyCard.Name = "lblKeyCard";
            lblKeyCard.Size = new Size(190, 30);
            lblKeyCard.TabIndex = 2;
            lblKeyCard.Text = "Key Card Number:";
            // 
            // txtKeyCard
            // 
            txtKeyCard.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtKeyCard.Location = new Point(37, 289);
            txtKeyCard.Name = "txtKeyCard";
            txtKeyCard.Size = new Size(635, 31);
            txtKeyCard.TabIndex = 3;
            // 
            // chkIdVerified
            // 
            chkIdVerified.AutoSize = true;
            chkIdVerified.Checked = true;
            chkIdVerified.CheckState = CheckState.Checked;
            chkIdVerified.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIdVerified.ForeColor = Color.Black;
            chkIdVerified.Location = new Point(72, 440);
            chkIdVerified.Name = "chkIdVerified";
            chkIdVerified.Size = new Size(198, 34);
            chkIdVerified.TabIndex = 4;
            chkIdVerified.Text = "Guest ID Verified";
            // 
            // chkKeyIssued
            // 
            chkKeyIssued.AutoSize = true;
            chkKeyIssued.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            chkKeyIssued.ForeColor = Color.Black;
            chkKeyIssued.Location = new Point(417, 440);
            chkKeyIssued.Name = "chkKeyIssued";
            chkKeyIssued.Size = new Size(214, 29);
            chkKeyIssued.TabIndex = 5;
            chkKeyIssued.Text = "Room Key Issued";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblPaymentStatus.ForeColor = Color.LawnGreen;
            lblPaymentStatus.Location = new Point(130, 561);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(455, 25);
            lblPaymentStatus.TabIndex = 6;
            lblPaymentStatus.Text = "Payment Clearance Status:   CLEARED ✔";
            // 
            // btnConfirmCheckIn
            // 
            btnConfirmCheckIn.BackColor = Color.FromArgb(85, 107, 47);
            btnConfirmCheckIn.FlatStyle = FlatStyle.Flat;
            btnConfirmCheckIn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnConfirmCheckIn.ForeColor = Color.White;
            btnConfirmCheckIn.Location = new Point(180, 660);
            btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            btnConfirmCheckIn.Size = new Size(350, 42);
            btnConfirmCheckIn.TabIndex = 7;
            btnConfirmCheckIn.Text = "Confirm Check-In";
            btnConfirmCheckIn.UseVisualStyleBackColor = false;
            // 
            // CheckInUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 196, 222);
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
    }
}