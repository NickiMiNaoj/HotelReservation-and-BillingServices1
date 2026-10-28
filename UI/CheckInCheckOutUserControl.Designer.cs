namespace UI
{
    partial class CheckInCheckOutUserControl
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
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            pnlHandlingUC = new Panel();
            SuspendLayout();
            // 
            // btnCheckIn
            // 
            btnCheckIn.FlatStyle = FlatStyle.System;
            btnCheckIn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.Location = new Point(22, 10);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(148, 46);
            btnCheckIn.TabIndex = 0;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.FlatStyle = FlatStyle.System;
            btnCheckOut.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.Location = new Point(186, 10);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(148, 46);
            btnCheckOut.TabIndex = 1;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // pnlHandlingUC
            // 
            pnlHandlingUC.BackColor = Color.Silver;
            pnlHandlingUC.Location = new Point(11, 68);
            pnlHandlingUC.Name = "pnlHandlingUC";
            pnlHandlingUC.Size = new Size(1426, 886);
            pnlHandlingUC.TabIndex = 2;
            // 
            // CheckInCheckOutUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 196, 222);
            Controls.Add(pnlHandlingUC);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Name = "CheckInCheckOutUserControl";
            Size = new Size(1447, 965);
            Load += CheckInCheckOutUserControl_Load;
            ResumeLayout(false);
        }

        private Button btnCheckIn;
        private Button btnCheckOut;
        private Panel pnlHandlingUC;
    }
}