namespace UI
{
    partial class admindashboardform
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
            btnRoomMaintenance = new Button();
            btnReaervation = new Button();
            btnGuestMaintenance = new Button();
            btnBullingPayment = new Button();
            btnCheckinCheckout = new Button();
            btnServicesAdd = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            btnSettings = new Button();
            lblDashboard = new Label();
            listRecentTransactions = new ListView();
            listRoomAvaliablityOverview = new ListView();
            listReservations = new ListView();
            listTotalRooms = new ListView();
            lblTotalRooms = new Label();
            listOccupiedRooms = new ListView();
            lblOccupiedRooms = new Label();
            lblRoomAvaliablityOverview = new Label();
            lblRecentTransactions = new Label();
            lblReservations = new Label();
            listAvailableRooms = new ListView();
            lblAvailableRooms = new Label();
            listTodayArrivals = new ListView();
            lblTodayArrivals = new Label();
            btnAccount = new Button();
            SuspendLayout();
            // 
            // btnRoomMaintenance
            // 
            btnRoomMaintenance.Location = new Point(23, 50);
            btnRoomMaintenance.Margin = new Padding(2);
            btnRoomMaintenance.Name = "btnRoomMaintenance";
            btnRoomMaintenance.Size = new Size(143, 20);
            btnRoomMaintenance.TabIndex = 1;
            btnRoomMaintenance.Text = "Room Maintenance";
            btnRoomMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnReaervation
            // 
            btnReaervation.Location = new Point(23, 82);
            btnReaervation.Margin = new Padding(2);
            btnReaervation.Name = "btnReaervation";
            btnReaervation.Size = new Size(143, 20);
            btnReaervation.TabIndex = 2;
            btnReaervation.Text = "Reservation";
            btnReaervation.UseVisualStyleBackColor = true;
            // 
            // btnGuestMaintenance
            // 
            btnGuestMaintenance.Location = new Point(23, 119);
            btnGuestMaintenance.Margin = new Padding(2);
            btnGuestMaintenance.Name = "btnGuestMaintenance";
            btnGuestMaintenance.Size = new Size(143, 20);
            btnGuestMaintenance.TabIndex = 3;
            btnGuestMaintenance.Text = "Guest Maintenance";
            btnGuestMaintenance.UseVisualStyleBackColor = true;
            btnGuestMaintenance.Click += btnGuestMaintenance_Click;
            // 
            // btnBullingPayment
            // 
            btnBullingPayment.Location = new Point(23, 158);
            btnBullingPayment.Margin = new Padding(2);
            btnBullingPayment.Name = "btnBullingPayment";
            btnBullingPayment.Size = new Size(143, 20);
            btnBullingPayment.TabIndex = 4;
            btnBullingPayment.Text = "Bulling /Payment";
            btnBullingPayment.UseVisualStyleBackColor = true;
            // 
            // btnCheckinCheckout
            // 
            btnCheckinCheckout.Location = new Point(23, 196);
            btnCheckinCheckout.Margin = new Padding(2);
            btnCheckinCheckout.Name = "btnCheckinCheckout";
            btnCheckinCheckout.Size = new Size(143, 20);
            btnCheckinCheckout.TabIndex = 5;
            btnCheckinCheckout.Text = "Check-in /Check-Out";
            btnCheckinCheckout.UseVisualStyleBackColor = true;
            // 
            // btnServicesAdd
            // 
            btnServicesAdd.Location = new Point(23, 234);
            btnServicesAdd.Margin = new Padding(2);
            btnServicesAdd.Name = "btnServicesAdd";
            btnServicesAdd.Size = new Size(143, 20);
            btnServicesAdd.TabIndex = 6;
            btnServicesAdd.Text = "Services (Add-ons )";
            btnServicesAdd.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(23, 268);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(143, 20);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(23, 341);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(79, 20);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(23, 305);
            btnSettings.Margin = new Padding(2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(143, 20);
            btnSettings.TabIndex = 12;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(230, 20);
            lblDashboard.Margin = new Padding(2, 0, 2, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(69, 15);
            lblDashboard.TabIndex = 13;
            lblDashboard.Text = "Dashboards";
            // 
            // listRecentTransactions
            // 
            listRecentTransactions.Location = new Point(967, 208);
            listRecentTransactions.Margin = new Padding(2);
            listRecentTransactions.Name = "listRecentTransactions";
            listRecentTransactions.Size = new Size(226, 143);
            listRecentTransactions.TabIndex = 14;
            listRecentTransactions.UseCompatibleStateImageBehavior = false;
            // 
            // listRoomAvaliablityOverview
            // 
            listRoomAvaliablityOverview.Location = new Point(236, 208);
            listRoomAvaliablityOverview.Margin = new Padding(2);
            listRoomAvaliablityOverview.Name = "listRoomAvaliablityOverview";
            listRoomAvaliablityOverview.Size = new Size(226, 143);
            listRoomAvaliablityOverview.TabIndex = 16;
            listRoomAvaliablityOverview.UseCompatibleStateImageBehavior = false;
            // 
            // listReservations
            // 
            listReservations.Location = new Point(901, 82);
            listReservations.Margin = new Padding(2);
            listReservations.Name = "listReservations";
            listReservations.Size = new Size(170, 90);
            listReservations.TabIndex = 17;
            listReservations.UseCompatibleStateImageBehavior = false;
            // 
            // listTotalRooms
            // 
            listTotalRooms.Location = new Point(236, 82);
            listTotalRooms.Margin = new Padding(2);
            listTotalRooms.Name = "listTotalRooms";
            listTotalRooms.Size = new Size(170, 90);
            listTotalRooms.TabIndex = 20;
            listTotalRooms.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotalRooms
            // 
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Location = new Point(236, 78);
            lblTotalRooms.Margin = new Padding(2, 0, 2, 0);
            lblTotalRooms.Name = "lblTotalRooms";
            lblTotalRooms.Size = new Size(73, 15);
            lblTotalRooms.TabIndex = 27;
            lblTotalRooms.Text = "Total Rooms";
            // 
            // listOccupiedRooms
            // 
            listOccupiedRooms.Location = new Point(682, 82);
            listOccupiedRooms.Margin = new Padding(2);
            listOccupiedRooms.Name = "listOccupiedRooms";
            listOccupiedRooms.Size = new Size(170, 90);
            listOccupiedRooms.TabIndex = 28;
            listOccupiedRooms.UseCompatibleStateImageBehavior = false;
            // 
            // lblOccupiedRooms
            // 
            lblOccupiedRooms.AutoSize = true;
            lblOccupiedRooms.Location = new Point(682, 78);
            lblOccupiedRooms.Margin = new Padding(2, 0, 2, 0);
            lblOccupiedRooms.Name = "lblOccupiedRooms";
            lblOccupiedRooms.Size = new Size(98, 15);
            lblOccupiedRooms.TabIndex = 30;
            lblOccupiedRooms.Text = "Occupied Rooms";
            // 
            // lblRoomAvaliablityOverview
            // 
            lblRoomAvaliablityOverview.AutoSize = true;
            lblRoomAvaliablityOverview.Location = new Point(236, 202);
            lblRoomAvaliablityOverview.Margin = new Padding(2, 0, 2, 0);
            lblRoomAvaliablityOverview.Name = "lblRoomAvaliablityOverview";
            lblRoomAvaliablityOverview.Size = new Size(149, 15);
            lblRoomAvaliablityOverview.TabIndex = 31;
            lblRoomAvaliablityOverview.Text = "Room Avaliablity Overview";
            // 
            // lblRecentTransactions
            // 
            lblRecentTransactions.AutoSize = true;
            lblRecentTransactions.Location = new Point(967, 202);
            lblRecentTransactions.Margin = new Padding(2, 0, 2, 0);
            lblRecentTransactions.Name = "lblRecentTransactions";
            lblRecentTransactions.Size = new Size(112, 15);
            lblRecentTransactions.TabIndex = 33;
            lblRecentTransactions.Text = "Recent Transactions";
            // 
            // lblReservations
            // 
            lblReservations.AutoSize = true;
            lblReservations.Location = new Point(901, 75);
            lblReservations.Margin = new Padding(2, 0, 2, 0);
            lblReservations.Name = "lblReservations";
            lblReservations.Size = new Size(73, 15);
            lblReservations.TabIndex = 34;
            lblReservations.Text = "Reservations";
            // 
            // listAvailableRooms
            // 
            listAvailableRooms.Location = new Point(457, 82);
            listAvailableRooms.Margin = new Padding(2);
            listAvailableRooms.Name = "listAvailableRooms";
            listAvailableRooms.Size = new Size(170, 90);
            listAvailableRooms.TabIndex = 35;
            listAvailableRooms.UseCompatibleStateImageBehavior = false;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Location = new Point(457, 78);
            lblAvailableRooms.Margin = new Padding(2, 0, 2, 0);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(95, 15);
            lblAvailableRooms.TabIndex = 36;
            lblAvailableRooms.Text = "Available Rooms";
            // 
            // listTodayArrivals
            // 
            listTodayArrivals.Location = new Point(491, 208);
            listTodayArrivals.Margin = new Padding(2);
            listTodayArrivals.Name = "listTodayArrivals";
            listTodayArrivals.Size = new Size(443, 143);
            listTodayArrivals.TabIndex = 37;
            listTodayArrivals.UseCompatibleStateImageBehavior = false;
            // 
            // lblTodayArrivals
            // 
            lblTodayArrivals.AutoSize = true;
            lblTodayArrivals.Location = new Point(491, 202);
            lblTodayArrivals.Margin = new Padding(2, 0, 2, 0);
            lblTodayArrivals.Name = "lblTodayArrivals";
            lblTodayArrivals.Size = new Size(81, 15);
            lblTodayArrivals.TabIndex = 38;
            lblTodayArrivals.Text = "Today Arrivals";
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(1114, 14);
            btnAccount.Margin = new Padding(2);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(79, 20);
            btnAccount.TabIndex = 39;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            // 
            // admindashboardform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 508);
            Controls.Add(btnAccount);
            Controls.Add(lblTodayArrivals);
            Controls.Add(listTodayArrivals);
            Controls.Add(lblAvailableRooms);
            Controls.Add(listAvailableRooms);
            Controls.Add(lblReservations);
            Controls.Add(lblRecentTransactions);
            Controls.Add(lblRoomAvaliablityOverview);
            Controls.Add(lblOccupiedRooms);
            Controls.Add(listOccupiedRooms);
            Controls.Add(lblTotalRooms);
            Controls.Add(listTotalRooms);
            Controls.Add(listReservations);
            Controls.Add(listRoomAvaliablityOverview);
            Controls.Add(listRecentTransactions);
            Controls.Add(lblDashboard);
            Controls.Add(btnSettings);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnServicesAdd);
            Controls.Add(btnCheckinCheckout);
            Controls.Add(btnBullingPayment);
            Controls.Add(btnGuestMaintenance);
            Controls.Add(btnReaervation);
            Controls.Add(btnRoomMaintenance);
            Margin = new Padding(2);
            Name = "admindashboardform";
            Text = "admindashboardform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRoomMaintenance;
        private Button btnReaervation;
        private Button btnGuestMaintenance;
        private Button btnBullingPayment;
        private Button btnCheckinCheckout;
        private Button btnServicesAdd;
        private Button btnReports;
        private Button button10;
        private Button btnLogout;
        private Button btnSettings;
        private Label lblDashboard;
        private ListView listRecentTransactions;
        private ListView listView2;
        private ListView listRoomAvaliablityOverview;
        private ListView listReservations;
        private ListView listAvailableRooms;
        private ListView listView6;
        private ListView listTotalRooms;
        private Label lblReservations;
        private Label lblTotalRooms;
        private ListView listOccupiedRooms;
        private ListView listView8;
        private Label lblOccupiedRooms;
        private Label lblRoomAvaliablityOverview;
        private Label lblRecentTransactions;
        private Label lblAvailableRooms;
        private ListView listTodayArrivals;
        private Label lblTodayArrivals;
        private Button btnAccount;
    }
}