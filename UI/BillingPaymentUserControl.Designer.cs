namespace UI
{
    partial class BillingPaymentUserControl
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
            lblModuleTitle = new Label();
            panelInvoiceSummary = new Panel();
            lblSum1Title = new Label();
            lblSum1Val = new Label();
            lblSum2Title = new Label();
            lblSum2Val = new Label();
            lblSum3Title = new Label();
            lblSum3Val = new Label();
            panelItemizedBox = new Panel();
            lblItemizedTitle = new Label();
            dgvItemizedCharges = new DataGridView();
            panelPaymentMethod = new Panel();
            lblPayMethodTitle = new Label();
            rbCreditCard = new RadioButton();
            rbCash = new RadioButton();
            rbBankTransfer = new RadioButton();
            rbRoomCharge = new RadioButton();
            rbMobilePay = new RadioButton();
            panelTotalDue = new Panel();
            lblTotalDueTitle = new Label();
            txtTotalDue = new TextBox();
            panelActions = new Panel();
            btnProcessPayment = new Button();
            btnPrintInvoice = new Button();
            btnGenerateReceipt = new Button();
            panelInvoiceSummary.SuspendLayout();
            panelItemizedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemizedCharges).BeginInit();
            panelPaymentMethod.SuspendLayout();
            panelTotalDue.SuspendLayout();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblModuleTitle
            // 
            lblModuleTitle.AutoSize = true;
            lblModuleTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblModuleTitle.ForeColor = Color.FromArgb(218, 165, 32);
            lblModuleTitle.Location = new Point(20, 15);
            lblModuleTitle.Name = "lblModuleTitle";
            lblModuleTitle.Size = new Size(485, 26);
            lblModuleTitle.TabIndex = 0;
            lblModuleTitle.Text = "Hotel Reservation System - Billing & Payment";
            // 
            // panelInvoiceSummary
            // 
            panelInvoiceSummary.BackColor = Color.LightSteelBlue;
            panelInvoiceSummary.BorderStyle = BorderStyle.FixedSingle;
            panelInvoiceSummary.Controls.Add(lblSum1Title);
            panelInvoiceSummary.Controls.Add(lblSum1Val);
            panelInvoiceSummary.Controls.Add(lblSum2Title);
            panelInvoiceSummary.Controls.Add(lblSum2Val);
            panelInvoiceSummary.Controls.Add(lblSum3Title);
            panelInvoiceSummary.Controls.Add(lblSum3Val);
            panelInvoiceSummary.Location = new Point(20, 60);
            panelInvoiceSummary.Name = "panelInvoiceSummary";
            panelInvoiceSummary.Size = new Size(1407, 90);
            panelInvoiceSummary.TabIndex = 1;
            // 
            // lblSum1Title
            // 
            lblSum1Title.AutoSize = true;
            lblSum1Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSum1Title.ForeColor = Color.Goldenrod;
            lblSum1Title.Location = new Point(120, 20);
            lblSum1Title.Name = "lblSum1Title";
            lblSum1Title.Size = new Size(179, 21);
            lblSum1Title.TabIndex = 0;
            lblSum1Title.Text = "Invoice Summary Panel";
            // 
            // lblSum1Val
            // 
            lblSum1Val.AutoSize = true;
            lblSum1Val.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblSum1Val.ForeColor = Color.Black;
            lblSum1Val.Location = new Point(159, 41);
            lblSum1Val.Name = "lblSum1Val";
            lblSum1Val.Size = new Size(90, 29);
            lblSum1Val.TabIndex = 1;
            lblSum1Val.Text = "450.00";
            // 
            // lblSum2Title
            // 
            lblSum2Title.AutoSize = true;
            lblSum2Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSum2Title.ForeColor = Color.Goldenrod;
            lblSum2Title.Location = new Point(620, 20);
            lblSum2Title.Name = "lblSum2Title";
            lblSum2Title.Size = new Size(179, 21);
            lblSum2Title.TabIndex = 2;
            lblSum2Title.Text = "Invoice Summary Panel";
            // 
            // lblSum2Val
            // 
            lblSum2Val.AutoSize = true;
            lblSum2Val.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblSum2Val.ForeColor = Color.Black;
            lblSum2Val.Location = new Point(659, 41);
            lblSum2Val.Name = "lblSum2Val";
            lblSum2Val.Size = new Size(104, 29);
            lblSum2Val.TabIndex = 3;
            lblSum2Val.Text = "1200.00";
            // 
            // lblSum3Title
            // 
            lblSum3Title.AutoSize = true;
            lblSum3Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSum3Title.ForeColor = Color.Goldenrod;
            lblSum3Title.Location = new Point(1120, 20);
            lblSum3Title.Name = "lblSum3Title";
            lblSum3Title.Size = new Size(179, 21);
            lblSum3Title.TabIndex = 4;
            lblSum3Title.Text = "Invoice Summary Panel";
            // 
            // lblSum3Val
            // 
            lblSum3Val.AutoSize = true;
            lblSum3Val.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblSum3Val.ForeColor = Color.DarkGreen;
            lblSum3Val.Location = new Point(1159, 41);
            lblSum3Val.Name = "lblSum3Val";
            lblSum3Val.Size = new Size(76, 29);
            lblSum3Val.TabIndex = 5;
            lblSum3Val.Text = "$0.00";
            // 
            // panelItemizedBox
            // 
            panelItemizedBox.BackColor = Color.LightSteelBlue;
            panelItemizedBox.BorderStyle = BorderStyle.FixedSingle;
            panelItemizedBox.Controls.Add(lblItemizedTitle);
            panelItemizedBox.Controls.Add(dgvItemizedCharges);
            panelItemizedBox.Location = new Point(20, 165);
            panelItemizedBox.Name = "panelItemizedBox";
            panelItemizedBox.Size = new Size(1407, 340);
            panelItemizedBox.TabIndex = 2;
            // 
            // lblItemizedTitle
            // 
            lblItemizedTitle.AutoSize = true;
            lblItemizedTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblItemizedTitle.ForeColor = Color.Goldenrod;
            lblItemizedTitle.Location = new Point(600, 15);
            lblItemizedTitle.Name = "lblItemizedTitle";
            lblItemizedTitle.Size = new Size(163, 18);
            lblItemizedTitle.TabIndex = 0;
            lblItemizedTitle.Text = "itemized charges list";
            // 
            // dgvItemizedCharges
            // 
            dgvItemizedCharges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemizedCharges.Location = new Point(20, 50);
            dgvItemizedCharges.Name = "dgvItemizedCharges";
            dgvItemizedCharges.RowHeadersWidth = 51;
            dgvItemizedCharges.Size = new Size(1365, 270);
            dgvItemizedCharges.TabIndex = 1;
            // 
            // panelPaymentMethod
            // 
            panelPaymentMethod.BackColor = Color.LightSteelBlue;
            panelPaymentMethod.BorderStyle = BorderStyle.FixedSingle;
            panelPaymentMethod.Controls.Add(lblPayMethodTitle);
            panelPaymentMethod.Controls.Add(rbCreditCard);
            panelPaymentMethod.Controls.Add(rbCash);
            panelPaymentMethod.Controls.Add(rbBankTransfer);
            panelPaymentMethod.Controls.Add(rbRoomCharge);
            panelPaymentMethod.Controls.Add(rbMobilePay);
            panelPaymentMethod.Location = new Point(20, 520);
            panelPaymentMethod.Name = "panelPaymentMethod";
            panelPaymentMethod.Size = new Size(460, 415);
            panelPaymentMethod.TabIndex = 3;
            // 
            // lblPayMethodTitle
            // 
            lblPayMethodTitle.AutoSize = true;
            lblPayMethodTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblPayMethodTitle.ForeColor = Color.Goldenrod;
            lblPayMethodTitle.Location = new Point(120, 20);
            lblPayMethodTitle.Name = "lblPayMethodTitle";
            lblPayMethodTitle.Size = new Size(219, 20);
            lblPayMethodTitle.TabIndex = 0;
            lblPayMethodTitle.Text = "payment method selection";
            // 
            // rbCreditCard
            // 
            rbCreditCard.AutoSize = true;
            rbCreditCard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            rbCreditCard.ForeColor = Color.Goldenrod;
            rbCreditCard.Location = new Point(50, 80);
            rbCreditCard.Name = "rbCreditCard";
            rbCreditCard.Size = new Size(345, 24);
            rbCreditCard.TabIndex = 1;
            rbCreditCard.Text = "payment method selection (Credit Card)";
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            rbCash.ForeColor = Color.Goldenrod;
            rbCash.Location = new Point(50, 140);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(295, 24);
            rbCash.TabIndex = 2;
            rbCash.Text = "payment method selection (Cash)";
            // 
            // rbBankTransfer
            // 
            rbBankTransfer.AutoSize = true;
            rbBankTransfer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            rbBankTransfer.ForeColor = Color.Goldenrod;
            rbBankTransfer.Location = new Point(50, 200);
            rbBankTransfer.Name = "rbBankTransfer";
            rbBankTransfer.Size = new Size(367, 24);
            rbBankTransfer.TabIndex = 3;
            rbBankTransfer.Text = "payment method selection (Bank Transfer)";
            // 
            // rbRoomCharge
            // 
            rbRoomCharge.AutoSize = true;
            rbRoomCharge.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            rbRoomCharge.ForeColor = Color.Goldenrod;
            rbRoomCharge.Location = new Point(50, 260);
            rbRoomCharge.Name = "rbRoomCharge";
            rbRoomCharge.Size = new Size(364, 24);
            rbRoomCharge.TabIndex = 4;
            rbRoomCharge.Text = "payment method selection (Room Charge)";
            // 
            // rbMobilePay
            // 
            rbMobilePay.AutoSize = true;
            rbMobilePay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            rbMobilePay.ForeColor = Color.Goldenrod;
            rbMobilePay.Location = new Point(50, 320);
            rbMobilePay.Name = "rbMobilePay";
            rbMobilePay.Size = new Size(340, 24);
            rbMobilePay.TabIndex = 5;
            rbMobilePay.Text = "payment method selection (Mobile Pay)";
            // 
            // panelTotalDue
            // 
            panelTotalDue.BackColor = Color.LightSteelBlue;
            panelTotalDue.BorderStyle = BorderStyle.FixedSingle;
            panelTotalDue.Controls.Add(lblTotalDueTitle);
            panelTotalDue.Controls.Add(txtTotalDue);
            panelTotalDue.Location = new Point(495, 520);
            panelTotalDue.Name = "panelTotalDue";
            panelTotalDue.Size = new Size(430, 415);
            panelTotalDue.TabIndex = 4;
            // 
            // lblTotalDueTitle
            // 
            lblTotalDueTitle.AutoSize = true;
            lblTotalDueTitle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblTotalDueTitle.ForeColor = Color.FromArgb(218, 165, 32);
            lblTotalDueTitle.Location = new Point(100, 160);
            lblTotalDueTitle.Name = "lblTotalDueTitle";
            lblTotalDueTitle.Size = new Size(165, 24);
            lblTotalDueTitle.TabIndex = 0;
            lblTotalDueTitle.Text = "total amount due";
            // 
            // txtTotalDue
            // 
            txtTotalDue.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            txtTotalDue.Location = new Point(60, 210);
            txtTotalDue.Name = "txtTotalDue";
            txtTotalDue.Size = new Size(310, 29);
            txtTotalDue.TabIndex = 1;
            txtTotalDue.Text = "$910.00";
            txtTotalDue.TextAlign = HorizontalAlignment.Center;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.LightSteelBlue;
            panelActions.BorderStyle = BorderStyle.FixedSingle;
            panelActions.Controls.Add(btnProcessPayment);
            panelActions.Controls.Add(btnPrintInvoice);
            panelActions.Controls.Add(btnGenerateReceipt);
            panelActions.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            panelActions.Location = new Point(940, 520);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(487, 415);
            panelActions.TabIndex = 5;
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.BackColor = Color.FromArgb(197, 160, 89);
            btnProcessPayment.FlatStyle = FlatStyle.Flat;
            btnProcessPayment.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnProcessPayment.ForeColor = Color.FromArgb(15, 23, 42);
            btnProcessPayment.Location = new Point(50, 75);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(387, 65);
            btnProcessPayment.TabIndex = 0;
            btnProcessPayment.Text = "process payment";
            btnProcessPayment.UseVisualStyleBackColor = false;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.FromArgb(197, 160, 89);
            btnPrintInvoice.FlatStyle = FlatStyle.Flat;
            btnPrintInvoice.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnPrintInvoice.ForeColor = Color.FromArgb(15, 23, 42);
            btnPrintInvoice.Location = new Point(50, 180);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(387, 65);
            btnPrintInvoice.TabIndex = 1;
            btnPrintInvoice.Text = "print invoice";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            // 
            // btnGenerateReceipt
            // 
            btnGenerateReceipt.BackColor = Color.FromArgb(197, 160, 89);
            btnGenerateReceipt.FlatStyle = FlatStyle.Flat;
            btnGenerateReceipt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnGenerateReceipt.ForeColor = Color.FromArgb(15, 23, 42);
            btnGenerateReceipt.Location = new Point(50, 285);
            btnGenerateReceipt.Name = "btnGenerateReceipt";
            btnGenerateReceipt.Size = new Size(387, 65);
            btnGenerateReceipt.TabIndex = 2;
            btnGenerateReceipt.Text = "generate receipt";
            btnGenerateReceipt.UseVisualStyleBackColor = false;
            // 
            // BillingPaymentUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(lblModuleTitle);
            Controls.Add(panelInvoiceSummary);
            Controls.Add(panelItemizedBox);
            Controls.Add(panelPaymentMethod);
            Controls.Add(panelTotalDue);
            Controls.Add(panelActions);
            Name = "BillingPaymentUserControl";
            Size = new Size(1447, 965);
            panelInvoiceSummary.ResumeLayout(false);
            panelInvoiceSummary.PerformLayout();
            panelItemizedBox.ResumeLayout(false);
            panelItemizedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemizedCharges).EndInit();
            panelPaymentMethod.ResumeLayout(false);
            panelPaymentMethod.PerformLayout();
            panelTotalDue.ResumeLayout(false);
            panelTotalDue.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblModuleTitle;
        private System.Windows.Forms.Panel panelInvoiceSummary;
        private System.Windows.Forms.Label lblSum1Title;
        private System.Windows.Forms.Label lblSum1Val;
        private System.Windows.Forms.Label lblSum2Title;
        private System.Windows.Forms.Label lblSum2Val;
        private System.Windows.Forms.Label lblSum3Title;
        private System.Windows.Forms.Label lblSum3Val;
        private System.Windows.Forms.Panel panelItemizedBox;
        private System.Windows.Forms.Label lblItemizedTitle;
        private System.Windows.Forms.DataGridView dgvItemizedCharges;
        private System.Windows.Forms.Panel panelPaymentMethod;
        private System.Windows.Forms.Label lblPayMethodTitle;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbBankTransfer;
        private System.Windows.Forms.RadioButton rbRoomCharge;
        private System.Windows.Forms.RadioButton rbMobilePay;
        private System.Windows.Forms.Panel panelTotalDue;
        private System.Windows.Forms.Label lblTotalDueTitle;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnGenerateReceipt;
    }
}