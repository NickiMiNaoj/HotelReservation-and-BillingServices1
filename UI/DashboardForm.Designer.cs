namespace UI
{
    partial class DashboardForm
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
            lblWelcome = new Label();
            lblDateTime = new Label();
            pnlTotalRooms = new Panel();
            lblTotalRooms = new Label();
            lblTotalRoomsTitle = new Label();
            pnlAvailableRooms = new Panel();
            lblAvailableRooms = new Label();
            lblAvailableRoomsTitle = new Label();
            pnlOccupiedRooms = new Panel();
            lblOccupiedRooms = new Label();
            lblOccupiedRoomsTitle = new Label();
            pnlReservedRooms = new Panel();
            lblReservedRooms = new Label();
            lblReservedRoomsTitle = new Label();
            pnlOccupancyRate = new Panel();
            lblOccupancyRate = new Label();
            lblOccupancyRateTitle = new Label();
            pnlTodayCheckIns = new Panel();
            lblTodayCheckIns = new Label();
            lblTodayCheckInsTitle = new Label();
            pnlTodayCheckOuts = new Panel();
            lblTodayCheckOuts = new Label();
            lblTodayCheckOutsTitle = new Label();
            pnlTotalGuests = new Panel();
            lblTotalGuests = new Label();
            lblTotalGuestsTitle = new Label();
            pnlRevenueToday = new Panel();
            lblRevenueToday = new Label();
            lblRevenueTodayTitle = new Label();
            lblRecent = new Label();
            dgvRecentReservations = new DataGridView();
            colReservationID = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlTotalRooms.SuspendLayout();
            pnlAvailableRooms.SuspendLayout();
            pnlOccupiedRooms.SuspendLayout();
            pnlReservedRooms.SuspendLayout();
            pnlOccupancyRate.SuspendLayout();
            pnlTodayCheckIns.SuspendLayout();
            pnlTodayCheckOuts.SuspendLayout();
            pnlTotalGuests.SuspendLayout();
            pnlRevenueToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentReservations).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(36, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(235, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(1066, 30);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(292, 21);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Tuesday, November 69, 2026   66:99 AM";
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlTotalRooms
            // 
            pnlTotalRooms.BackColor = Color.White;
            pnlTotalRooms.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalRooms.Controls.Add(lblTotalRooms);
            pnlTotalRooms.Controls.Add(lblTotalRoomsTitle);
            pnlTotalRooms.Location = new Point(36, 90);
            pnlTotalRooms.Name = "pnlTotalRooms";
            pnlTotalRooms.Size = new Size(260, 110);
            pnlTotalRooms.TabIndex = 2;
            // 
            // lblTotalRooms
            // 
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRooms.Location = new Point(13, 48);
            lblTotalRooms.Name = "lblTotalRooms";
            lblTotalRooms.Size = new Size(38, 45);
            lblTotalRooms.TabIndex = 1;
            lblTotalRooms.Text = "0";
            // 
            // lblTotalRoomsTitle
            // 
            lblTotalRoomsTitle.AutoSize = true;
            lblTotalRoomsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRoomsTitle.ForeColor = SystemColors.GrayText;
            lblTotalRoomsTitle.Location = new Point(15, 14);
            lblTotalRoomsTitle.Name = "lblTotalRoomsTitle";
            lblTotalRoomsTitle.Size = new Size(92, 19);
            lblTotalRoomsTitle.TabIndex = 0;
            lblTotalRoomsTitle.Text = "Total Rooms";
            // 
            // pnlAvailableRooms
            // 
            pnlAvailableRooms.BackColor = Color.White;
            pnlAvailableRooms.BorderStyle = BorderStyle.FixedSingle;
            pnlAvailableRooms.Controls.Add(lblAvailableRooms);
            pnlAvailableRooms.Controls.Add(lblAvailableRoomsTitle);
            pnlAvailableRooms.Location = new Point(316, 90);
            pnlAvailableRooms.Name = "pnlAvailableRooms";
            pnlAvailableRooms.Size = new Size(260, 110);
            pnlAvailableRooms.TabIndex = 3;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableRooms.Location = new Point(13, 48);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(38, 45);
            lblAvailableRooms.TabIndex = 1;
            lblAvailableRooms.Text = "0";
            // 
            // lblAvailableRoomsTitle
            // 
            lblAvailableRoomsTitle.AutoSize = true;
            lblAvailableRoomsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableRoomsTitle.ForeColor = SystemColors.GrayText;
            lblAvailableRoomsTitle.Location = new Point(15, 14);
            lblAvailableRoomsTitle.Name = "lblAvailableRoomsTitle";
            lblAvailableRoomsTitle.Size = new Size(122, 19);
            lblAvailableRoomsTitle.TabIndex = 0;
            lblAvailableRoomsTitle.Text = "Available Rooms";
            // 
            // pnlOccupiedRooms
            // 
            pnlOccupiedRooms.BackColor = Color.White;
            pnlOccupiedRooms.BorderStyle = BorderStyle.FixedSingle;
            pnlOccupiedRooms.Controls.Add(lblOccupiedRooms);
            pnlOccupiedRooms.Controls.Add(lblOccupiedRoomsTitle);
            pnlOccupiedRooms.Location = new Point(596, 90);
            pnlOccupiedRooms.Name = "pnlOccupiedRooms";
            pnlOccupiedRooms.Size = new Size(260, 110);
            pnlOccupiedRooms.TabIndex = 4;
            // 
            // lblOccupiedRooms
            // 
            lblOccupiedRooms.AutoSize = true;
            lblOccupiedRooms.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupiedRooms.Location = new Point(13, 48);
            lblOccupiedRooms.Name = "lblOccupiedRooms";
            lblOccupiedRooms.Size = new Size(38, 45);
            lblOccupiedRooms.TabIndex = 1;
            lblOccupiedRooms.Text = "0";
            // 
            // lblOccupiedRoomsTitle
            // 
            lblOccupiedRoomsTitle.AutoSize = true;
            lblOccupiedRoomsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupiedRoomsTitle.ForeColor = SystemColors.GrayText;
            lblOccupiedRoomsTitle.Location = new Point(15, 14);
            lblOccupiedRoomsTitle.Name = "lblOccupiedRoomsTitle";
            lblOccupiedRoomsTitle.Size = new Size(122, 19);
            lblOccupiedRoomsTitle.TabIndex = 0;
            lblOccupiedRoomsTitle.Text = "Occupied Rooms";
            // 
            // pnlReservedRooms
            // 
            pnlReservedRooms.BackColor = Color.White;
            pnlReservedRooms.BorderStyle = BorderStyle.FixedSingle;
            pnlReservedRooms.Controls.Add(lblReservedRooms);
            pnlReservedRooms.Controls.Add(lblReservedRoomsTitle);
            pnlReservedRooms.Location = new Point(876, 90);
            pnlReservedRooms.Name = "pnlReservedRooms";
            pnlReservedRooms.Size = new Size(260, 110);
            pnlReservedRooms.TabIndex = 5;
            // 
            // lblReservedRooms
            // 
            lblReservedRooms.AutoSize = true;
            lblReservedRooms.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservedRooms.Location = new Point(13, 48);
            lblReservedRooms.Name = "lblReservedRooms";
            lblReservedRooms.Size = new Size(38, 45);
            lblReservedRooms.TabIndex = 1;
            lblReservedRooms.Text = "0";
            // 
            // lblReservedRoomsTitle
            // 
            lblReservedRoomsTitle.AutoSize = true;
            lblReservedRoomsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservedRoomsTitle.ForeColor = SystemColors.GrayText;
            lblReservedRoomsTitle.Location = new Point(15, 14);
            lblReservedRoomsTitle.Name = "lblReservedRoomsTitle";
            lblReservedRoomsTitle.Size = new Size(122, 19);
            lblReservedRoomsTitle.TabIndex = 0;
            lblReservedRoomsTitle.Text = "Reserved Rooms";
            // 
            // pnlOccupancyRate
            // 
            pnlOccupancyRate.BackColor = Color.White;
            pnlOccupancyRate.BorderStyle = BorderStyle.FixedSingle;
            pnlOccupancyRate.Controls.Add(lblOccupancyRate);
            pnlOccupancyRate.Controls.Add(lblOccupancyRateTitle);
            pnlOccupancyRate.Location = new Point(1156, 90);
            pnlOccupancyRate.Name = "pnlOccupancyRate";
            pnlOccupancyRate.Size = new Size(260, 110);
            pnlOccupancyRate.TabIndex = 6;
            // 
            // lblOccupancyRate
            // 
            lblOccupancyRate.AutoSize = true;
            lblOccupancyRate.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupancyRate.Location = new Point(13, 48);
            lblOccupancyRate.Name = "lblOccupancyRate";
            lblOccupancyRate.Size = new Size(66, 45);
            lblOccupancyRate.TabIndex = 1;
            lblOccupancyRate.Text = "0%";
            // 
            // lblOccupancyRateTitle
            // 
            lblOccupancyRateTitle.AutoSize = true;
            lblOccupancyRateTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupancyRateTitle.ForeColor = SystemColors.GrayText;
            lblOccupancyRateTitle.Location = new Point(15, 14);
            lblOccupancyRateTitle.Name = "lblOccupancyRateTitle";
            lblOccupancyRateTitle.Size = new Size(116, 19);
            lblOccupancyRateTitle.TabIndex = 0;
            lblOccupancyRateTitle.Text = "Occupancy Rate";
            // 
            // pnlTodayCheckIns
            // 
            pnlTodayCheckIns.BackColor = Color.White;
            pnlTodayCheckIns.BorderStyle = BorderStyle.FixedSingle;
            pnlTodayCheckIns.Controls.Add(lblTodayCheckIns);
            pnlTodayCheckIns.Controls.Add(lblTodayCheckInsTitle);
            pnlTodayCheckIns.Location = new Point(36, 220);
            pnlTodayCheckIns.Name = "pnlTodayCheckIns";
            pnlTodayCheckIns.Size = new Size(260, 110);
            pnlTodayCheckIns.TabIndex = 7;
            // 
            // lblTodayCheckIns
            // 
            lblTodayCheckIns.AutoSize = true;
            lblTodayCheckIns.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayCheckIns.Location = new Point(13, 48);
            lblTodayCheckIns.Name = "lblTodayCheckIns";
            lblTodayCheckIns.Size = new Size(38, 45);
            lblTodayCheckIns.TabIndex = 1;
            lblTodayCheckIns.Text = "0";
            // 
            // lblTodayCheckInsTitle
            // 
            lblTodayCheckInsTitle.AutoSize = true;
            lblTodayCheckInsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayCheckInsTitle.ForeColor = SystemColors.GrayText;
            lblTodayCheckInsTitle.Location = new Point(15, 14);
            lblTodayCheckInsTitle.Name = "lblTodayCheckInsTitle";
            lblTodayCheckInsTitle.Size = new Size(126, 19);
            lblTodayCheckInsTitle.TabIndex = 0;
            lblTodayCheckInsTitle.Text = "Today's Check-ins";
            // 
            // pnlTodayCheckOuts
            // 
            pnlTodayCheckOuts.BackColor = Color.White;
            pnlTodayCheckOuts.BorderStyle = BorderStyle.FixedSingle;
            pnlTodayCheckOuts.Controls.Add(lblTodayCheckOuts);
            pnlTodayCheckOuts.Controls.Add(lblTodayCheckOutsTitle);
            pnlTodayCheckOuts.Location = new Point(316, 220);
            pnlTodayCheckOuts.Name = "pnlTodayCheckOuts";
            pnlTodayCheckOuts.Size = new Size(260, 110);
            pnlTodayCheckOuts.TabIndex = 8;
            // 
            // lblTodayCheckOuts
            // 
            lblTodayCheckOuts.AutoSize = true;
            lblTodayCheckOuts.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayCheckOuts.Location = new Point(13, 48);
            lblTodayCheckOuts.Name = "lblTodayCheckOuts";
            lblTodayCheckOuts.Size = new Size(38, 45);
            lblTodayCheckOuts.TabIndex = 1;
            lblTodayCheckOuts.Text = "0";
            // 
            // lblTodayCheckOutsTitle
            // 
            lblTodayCheckOutsTitle.AutoSize = true;
            lblTodayCheckOutsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayCheckOutsTitle.ForeColor = SystemColors.GrayText;
            lblTodayCheckOutsTitle.Location = new Point(15, 14);
            lblTodayCheckOutsTitle.Name = "lblTodayCheckOutsTitle";
            lblTodayCheckOutsTitle.Size = new Size(136, 19);
            lblTodayCheckOutsTitle.TabIndex = 0;
            lblTodayCheckOutsTitle.Text = "Today's Check-outs";
            // 
            // pnlTotalGuests
            // 
            pnlTotalGuests.BackColor = Color.White;
            pnlTotalGuests.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalGuests.Controls.Add(lblTotalGuests);
            pnlTotalGuests.Controls.Add(lblTotalGuestsTitle);
            pnlTotalGuests.Location = new Point(596, 220);
            pnlTotalGuests.Name = "pnlTotalGuests";
            pnlTotalGuests.Size = new Size(260, 110);
            pnlTotalGuests.TabIndex = 9;
            // 
            // lblTotalGuests
            // 
            lblTotalGuests.AutoSize = true;
            lblTotalGuests.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGuests.Location = new Point(13, 48);
            lblTotalGuests.Name = "lblTotalGuests";
            lblTotalGuests.Size = new Size(38, 45);
            lblTotalGuests.TabIndex = 1;
            lblTotalGuests.Text = "0";
            // 
            // lblTotalGuestsTitle
            // 
            lblTotalGuestsTitle.AutoSize = true;
            lblTotalGuestsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGuestsTitle.ForeColor = SystemColors.GrayText;
            lblTotalGuestsTitle.Location = new Point(15, 14);
            lblTotalGuestsTitle.Name = "lblTotalGuestsTitle";
            lblTotalGuestsTitle.Size = new Size(89, 19);
            lblTotalGuestsTitle.TabIndex = 0;
            lblTotalGuestsTitle.Text = "Total Guests";
            // 
            // pnlRevenueToday
            // 
            pnlRevenueToday.BackColor = Color.White;
            pnlRevenueToday.BorderStyle = BorderStyle.FixedSingle;
            pnlRevenueToday.Controls.Add(lblRevenueToday);
            pnlRevenueToday.Controls.Add(lblRevenueTodayTitle);
            pnlRevenueToday.Location = new Point(876, 220);
            pnlRevenueToday.Name = "pnlRevenueToday";
            pnlRevenueToday.Size = new Size(260, 110);
            pnlRevenueToday.TabIndex = 10;
            // 
            // lblRevenueToday
            // 
            lblRevenueToday.AutoSize = true;
            lblRevenueToday.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueToday.Location = new Point(13, 48);
            lblRevenueToday.Name = "lblRevenueToday";
            lblRevenueToday.Size = new Size(103, 45);
            lblRevenueToday.TabIndex = 1;
            lblRevenueToday.Text = "₱0.00";
            // 
            // lblRevenueTodayTitle
            // 
            lblRevenueTodayTitle.AutoSize = true;
            lblRevenueTodayTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueTodayTitle.ForeColor = SystemColors.GrayText;
            lblRevenueTodayTitle.Location = new Point(15, 14);
            lblRevenueTodayTitle.Name = "lblRevenueTodayTitle";
            lblRevenueTodayTitle.Size = new Size(111, 19);
            lblRevenueTodayTitle.TabIndex = 0;
            lblRevenueTodayTitle.Text = "Revenue Today";
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecent.Location = new Point(36, 350);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(186, 25);
            lblRecent.TabIndex = 11;
            lblRecent.Text = "Recent Reservations";
            // 
            // dgvRecentReservations
            // 
            dgvRecentReservations.AllowUserToAddRows = false;
            dgvRecentReservations.AllowUserToDeleteRows = false;
            dgvRecentReservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvRecentReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentReservations.BackgroundColor = Color.White;
            dgvRecentReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentReservations.Columns.AddRange(new DataGridViewColumn[] { colReservationID, colGuestName, colRoomNumber, colCheckIn, colCheckOut, colStatus });
            dgvRecentReservations.Location = new Point(36, 385);
            dgvRecentReservations.Name = "dgvRecentReservations";
            dgvRecentReservations.ReadOnly = true;
            dgvRecentReservations.RowHeadersVisible = false;
            dgvRecentReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentReservations.Size = new Size(1340, 560);
            dgvRecentReservations.TabIndex = 12;
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
            colRoomNumber.HeaderText = "Room";
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
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1452, 976);
            Controls.Add(dgvRecentReservations);
            Controls.Add(lblRecent);
            Controls.Add(pnlRevenueToday);
            Controls.Add(pnlTotalGuests);
            Controls.Add(pnlTodayCheckOuts);
            Controls.Add(pnlTodayCheckIns);
            Controls.Add(pnlOccupancyRate);
            Controls.Add(pnlReservedRooms);
            Controls.Add(pnlOccupiedRooms);
            Controls.Add(pnlAvailableRooms);
            Controls.Add(pnlTotalRooms);
            Controls.Add(lblDateTime);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "Dashboard";
            pnlTotalRooms.ResumeLayout(false);
            pnlTotalRooms.PerformLayout();
            pnlAvailableRooms.ResumeLayout(false);
            pnlAvailableRooms.PerformLayout();
            pnlOccupiedRooms.ResumeLayout(false);
            pnlOccupiedRooms.PerformLayout();
            pnlReservedRooms.ResumeLayout(false);
            pnlReservedRooms.PerformLayout();
            pnlOccupancyRate.ResumeLayout(false);
            pnlOccupancyRate.PerformLayout();
            pnlTodayCheckIns.ResumeLayout(false);
            pnlTodayCheckIns.PerformLayout();
            pnlTodayCheckOuts.ResumeLayout(false);
            pnlTodayCheckOuts.PerformLayout();
            pnlTotalGuests.ResumeLayout(false);
            pnlTotalGuests.PerformLayout();
            pnlRevenueToday.ResumeLayout(false);
            pnlRevenueToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblDateTime;
        private Panel pnlTotalRooms;
        private Label lblTotalRoomsTitle;
        private Label lblTotalRooms;
        private Panel pnlAvailableRooms;
        private Label lblAvailableRoomsTitle;
        private Label lblAvailableRooms;
        private Panel pnlOccupiedRooms;
        private Label lblOccupiedRoomsTitle;
        private Label lblOccupiedRooms;
        private Panel pnlReservedRooms;
        private Label lblReservedRoomsTitle;
        private Label lblReservedRooms;
        private Panel pnlOccupancyRate;
        private Label lblOccupancyRateTitle;
        private Label lblOccupancyRate;
        private Panel pnlTodayCheckIns;
        private Label lblTodayCheckInsTitle;
        private Label lblTodayCheckIns;
        private Panel pnlTodayCheckOuts;
        private Label lblTodayCheckOutsTitle;
        private Label lblTodayCheckOuts;
        private Panel pnlTotalGuests;
        private Label lblTotalGuestsTitle;
        private Label lblTotalGuests;
        private Panel pnlRevenueToday;
        private Label lblRevenueTodayTitle;
        private Label lblRevenueToday;
        private Label lblRecent;
        private DataGridView dgvRecentReservations;
        private DataGridViewTextBoxColumn colReservationID;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colCheckIn;
        private DataGridViewTextBoxColumn colCheckOut;
        private DataGridViewTextBoxColumn colStatus;
    }
}