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
            panelActiveStays.Location = new Point(20, 57);
            panelActiveStays.Name = "panelActiveStays";
            panelActiveStays.Size = new Size(680, 815);
            panelActiveStays.TabIndex = 1;
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.AutoSize = true;
            lblActiveTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblActiveTitle.ForeColor = Color.Black;
            lblActiveTitle.Location = new Point(220, 15);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(234, 25);
            lblActiveTitle.TabIndex = 0;
            lblActiveTitle.Text = "Check-Out Execution";
            // 
            // lblSearchActive
            // 
            lblSearchActive.AutoSize = true;
            lblSearchActive.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblSearchActive.ForeColor = Color.Black;
            lblSearchActive.Location = new Point(25, 48);
            lblSearchActive.Name = "lblSearchActive";
            lblSearchActive.Size = new Size(219, 25);
            lblSearchActive.TabIndex = 1;
            lblSearchActive.Text = "Search Active Stay:";
            // 
            // txtSearchActive
            // 
            txtSearchActive.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtSearchActive.Location = new Point(25, 89);
            txtSearchActive.Name = "txtSearchActive";
            txtSearchActive.Size = new Size(560, 31);
            txtSearchActive.TabIndex = 2;
            // 
            // btnSearchActiveIcon
            // 
            btnSearchActiveIcon.BackColor = Color.FromArgb(30, 42, 56);
            btnSearchActiveIcon.FlatStyle = FlatStyle.Flat;
            btnSearchActiveIcon.ForeColor = Color.White;
            btnSearchActiveIcon.Location = new Point(595, 89);
            btnSearchActiveIcon.Name = "btnSearchActiveIcon";
            btnSearchActiveIcon.Size = new Size(45, 31);
            btnSearchActiveIcon.TabIndex = 3;
            btnSearchActiveIcon.Text = "🔍";
            btnSearchActiveIcon.UseVisualStyleBackColor = false;
            // 
            // dgvActiveStays
            // 
            dgvActiveStays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveStays.Location = new Point(25, 153);
            dgvActiveStays.Name = "dgvActiveStays";
            dgvActiveStays.Size = new Size(615, 560);
            dgvActiveStays.TabIndex = 4;
            // 
            // btnSearchActive
            // 
            btnSearchActive.BackColor = Color.FromArgb(30, 42, 56);
            btnSearchActive.FlatStyle = FlatStyle.Flat;
            btnSearchActive.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnSearchActive.ForeColor = Color.White;
            btnSearchActive.Location = new Point(181, 749);
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
            btnClearActive.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnClearActive.ForeColor = Color.White;
            btnClearActive.Location = new Point(346, 749);
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
            panelExecution.Location = new Point(720, 57);
            panelExecution.Name = "panelExecution";
            panelExecution.Size = new Size(691, 815);
            panelExecution.TabIndex = 0;
            // 
            // lblExecTitle
            // 
            lblExecTitle.AutoSize = true;
            lblExecTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblExecTitle.ForeColor = Color.Black;
            lblExecTitle.Location = new Point(218, 70);
            lblExecTitle.Name = "lblExecTitle";
            lblExecTitle.Size = new Size(261, 25);
            lblExecTitle.TabIndex = 0;
            lblExecTitle.Text = "4. Check-Out Execution";
            // 
            // lblTimeSelection
            // 
            lblTimeSelection.AutoSize = true;
            lblTimeSelection.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTimeSelection.ForeColor = Color.Black;
            lblTimeSelection.Location = new Point(35, 174);
            lblTimeSelection.Name = "lblTimeSelection";
            lblTimeSelection.Size = new Size(286, 25);
            lblTimeSelection.TabIndex = 1;
            lblTimeSelection.Text = "Check-Out Time Selection";
            // 
            // dtpTimeSelection
            // 
            dtpTimeSelection.CustomFormat = "D/M/Y 2022 HH:MM";
            dtpTimeSelection.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dtpTimeSelection.Format = DateTimePickerFormat.Custom;
            dtpTimeSelection.Location = new Point(35, 202);
            dtpTimeSelection.Name = "dtpTimeSelection";
            dtpTimeSelection.Size = new Size(300, 31);
            dtpTimeSelection.TabIndex = 2;
            // 
            // lblActualOut
            // 
            lblActualOut.AutoSize = true;
            lblActualOut.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblActualOut.ForeColor = Color.Black;
            lblActualOut.Location = new Point(365, 174);
            lblActualOut.Name = "lblActualOut";
            lblActualOut.Size = new Size(254, 25);
            lblActualOut.TabIndex = 3;
            lblActualOut.Text = "Actual Check-Out Time";
            // 
            // dtpActualOut
            // 
            dtpActualOut.CustomFormat = "D/M/Y 2022 HH:MM";
            dtpActualOut.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dtpActualOut.Format = DateTimePickerFormat.Custom;
            dtpActualOut.Location = new Point(365, 202);
            dtpActualOut.Name = "dtpActualOut";
            dtpActualOut.Size = new Size(305, 31);
            dtpActualOut.TabIndex = 4;
            // 
            // lblFinVerif
            // 
            lblFinVerif.AutoSize = true;
            lblFinVerif.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblFinVerif.ForeColor = Color.Black;
            lblFinVerif.Location = new Point(35, 307);
            lblFinVerif.Name = "lblFinVerif";
            lblFinVerif.Size = new Size(261, 25);
            lblFinVerif.TabIndex = 5;
            lblFinVerif.Text = "3. Financial Verification";
            // 
            // txtFinVerif
            // 
            txtFinVerif.BackColor = Color.FromArgb(220, 220, 220);
            txtFinVerif.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtFinVerif.Location = new Point(35, 335);
            txtFinVerif.Name = "txtFinVerif";
            txtFinVerif.Size = new Size(300, 31);
            txtFinVerif.TabIndex = 6;
            txtFinVerif.Text = "0.00";
            // 
            // lblChangeDue
            // 
            lblChangeDue.AutoSize = true;
            lblChangeDue.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblChangeDue.ForeColor = Color.Black;
            lblChangeDue.Location = new Point(365, 307);
            lblChangeDue.Name = "lblChangeDue";
            lblChangeDue.Size = new Size(142, 25);
            lblChangeDue.TabIndex = 7;
            lblChangeDue.Text = "Change Due";
            // 
            // txtChangeDue
            // 
            txtChangeDue.BackColor = Color.FromArgb(220, 220, 220);
            txtChangeDue.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtChangeDue.Location = new Point(365, 335);
            txtChangeDue.Name = "txtChangeDue";
            txtChangeDue.Size = new Size(305, 31);
            txtChangeDue.TabIndex = 8;
            txtChangeDue.Text = "0.00";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemarks.ForeColor = Color.Black;
            lblRemarks.Location = new Point(35, 430);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(205, 30);
            lblRemarks.TabIndex = 9;
            lblRemarks.Text = "Check-Out Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtRemarks.Location = new Point(35, 463);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(635, 31);
            txtRemarks.TabIndex = 10;
            // 
            // btnFinalizeCheckout
            // 
            btnFinalizeCheckout.BackColor = Color.FromArgb(197, 160, 89);
            btnFinalizeCheckout.FlatStyle = FlatStyle.Flat;
            btnFinalizeCheckout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnFinalizeCheckout.Location = new Point(189, 618);
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
            btnPrintInvoice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(24, 678);
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
            btnGenerateReceipt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnGenerateReceipt.ForeColor = Color.White;
            btnGenerateReceipt.Location = new Point(354, 678);
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
            Controls.Add(lblTitle);
            Name = "CheckOutUserControl";
            Size = new Size(1426, 886);
            panelActiveStays.ResumeLayout(false);
            panelActiveStays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveStays).EndInit();
            panelExecution.ResumeLayout(false);
            panelExecution.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
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