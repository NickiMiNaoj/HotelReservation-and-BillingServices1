namespace UI
{
    partial class LandingPageForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPageForm));
            btnLogout = new Button();
            panel1 = new Panel();
            button12 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            btnRoomReservation = new Button();
            btnRooms = new Button();
            button2 = new Button();
            button3 = new Button();
            btnDashboard = new Button();
            pnlHandlingUC = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1715, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 41);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1923, 104);
            panel1.TabIndex = 1;
            // 
            // button12
            // 
            button12.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(1525, 26);
            button12.Name = "button12";
            button12.Size = new Size(160, 41);
            button12.TabIndex = 12;
            button12.Text = "Settings";
            button12.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(318, 52);
            label2.Name = "label2";
            label2.Size = new Size(240, 32);
            label2.TabIndex = 4;
            label2.Text = "Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Felix Titling", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 8);
            label1.Name = "label1";
            label1.Size = new Size(399, 44);
            label1.TabIndex = 3;
            label1.Text = "HOTEL RSERVATION";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(btnRoomReservation);
            panel2.Controls.Add(btnRooms);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 975);
            panel2.TabIndex = 2;
            // 
            // button11
            // 
            button11.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(56, 887);
            button11.Name = "button11";
            button11.Size = new Size(306, 66);
            button11.TabIndex = 11;
            button11.Text = "Reports";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(56, 796);
            button10.Name = "button10";
            button10.Size = new Size(306, 66);
            button10.TabIndex = 10;
            button10.Text = "User & Roles";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(56, 707);
            button9.Name = "button9";
            button9.Size = new Size(306, 66);
            button9.TabIndex = 9;
            button9.Text = "Services (Add-ons)";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(56, 617);
            button8.Name = "button8";
            button8.Size = new Size(306, 66);
            button8.TabIndex = 8;
            button8.Text = "Check-in/Check-out";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(56, 530);
            button7.Name = "button7";
            button7.Size = new Size(306, 66);
            button7.TabIndex = 7;
            button7.Text = "Bulling/Payment";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(56, 441);
            button6.Name = "button6";
            button6.Size = new Size(306, 66);
            button6.TabIndex = 6;
            button6.Text = "Guests";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnRoomReservation
            // 
            btnRoomReservation.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomReservation.Location = new Point(56, 355);
            btnRoomReservation.Name = "btnRoomReservation";
            btnRoomReservation.Size = new Size(306, 66);
            btnRoomReservation.TabIndex = 5;
            btnRoomReservation.Text = "Raservation";
            btnRoomReservation.UseVisualStyleBackColor = true;
            btnRoomReservation.Click += btnRoomReservation_Click;
            // 
            // btnRooms
            // 
            btnRooms.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.Location = new Point(56, 101);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(306, 66);
            btnRooms.TabIndex = 4;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(56, 271);
            button2.Name = "button2";
            button2.Size = new Size(306, 66);
            button2.TabIndex = 3;
            button2.Text = "Rooms Maintenance";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(56, 184);
            button3.Name = "button3";
            button3.Size = new Size(306, 66);
            button3.TabIndex = 2;
            button3.Text = "Rooms Types & Rates";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Calisto MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(56, 17);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(306, 66);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlHandlingUC
            // 
            pnlHandlingUC.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHandlingUC.BorderStyle = BorderStyle.FixedSingle;
            pnlHandlingUC.Location = new Point(470, 110);
            pnlHandlingUC.Name = "pnlHandlingUC";
            pnlHandlingUC.Size = new Size(1447, 965);
            pnlHandlingUC.TabIndex = 3;
            // 
            // LandingPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pnlHandlingUC);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LandingPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingPageForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button btnDashboard;
        private Button btnRooms;
        private Button button2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button btnRoomReservation;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button12;
        private PictureBox pictureBox1;
        private Panel pnlHandlingUC;
    }
}