namespace UI
{
    partial class frontdeskdashboardForm
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
            btnSettings = new Button();
            btnReports = new Button();
            btnUserRoles = new Button();
            btnServicesAdd = new Button();
            btnCheckinCheckOut = new Button();
            btnBullingPayment = new Button();
            btnGuests = new Button();
            btnReservations = new Button();
            btnRooms = new Button();
            btnLogout = new Button();
            listAvailableRooms = new ListView();
            listTotalReservtions = new ListView();
            lblOccupiedRooms = new Label();
            lblAvailableRooms = new Label();
            lblTotalReservtions = new Label();
            listOccupiedRooms = new ListView();
            lblOccupiedR = new Label();
            listCheckin = new ListView();
            listRoom = new ListView();
            listGuestsName = new ListView();
            listTodaySchedule = new ListView();
            listTodayCheck = new ListView();
            listCheckOut = new ListView();
            lblRoom = new Label();
            lblGuestsName = new Label();
            lblTodaySchedule = new Label();
            lblQuickActions = new Label();
            lblCheckOut = new Label();
            lblTodayCheck = new Label();
            btnViewRooms = new Button();
            btnCheckOutGuests = new Button();
            btnNewReservtions = new Button();
            btnCheckInGuests = new Button();
            listActions = new ListView();
            listSatus = new ListView();
            listCheckout1 = new ListView();
            lblActions = new Label();
            lblSatus = new Label();
            Checkout = new Label();
            lblChein = new Label();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(24, 529);
            btnSettings.Margin = new Padding(2, 2, 2, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(175, 27);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(24, 481);
            btnReports.Margin = new Padding(2, 2, 2, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(175, 27);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnUserRoles
            // 
            btnUserRoles.Location = new Point(24, 433);
            btnUserRoles.Margin = new Padding(2, 2, 2, 2);
            btnUserRoles.Name = "btnUserRoles";
            btnUserRoles.Size = new Size(175, 27);
            btnUserRoles.TabIndex = 3;
            btnUserRoles.Text = "User & Roles";
            btnUserRoles.UseVisualStyleBackColor = true;
            // 
            // btnServicesAdd
            // 
            btnServicesAdd.Location = new Point(24, 380);
            btnServicesAdd.Margin = new Padding(2, 2, 2, 2);
            btnServicesAdd.Name = "btnServicesAdd";
            btnServicesAdd.Size = new Size(175, 27);
            btnServicesAdd.TabIndex = 4;
            btnServicesAdd.Text = "Services (Add-ons )";
            btnServicesAdd.UseVisualStyleBackColor = true;
            // 
            // btnCheckinCheckOut
            // 
            btnCheckinCheckOut.Location = new Point(24, 328);
            btnCheckinCheckOut.Margin = new Padding(2, 2, 2, 2);
            btnCheckinCheckOut.Name = "btnCheckinCheckOut";
            btnCheckinCheckOut.Size = new Size(175, 27);
            btnCheckinCheckOut.TabIndex = 6;
            btnCheckinCheckOut.Text = "Check-in /Check-Out";
            btnCheckinCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnBullingPayment
            // 
            btnBullingPayment.Location = new Point(24, 280);
            btnBullingPayment.Margin = new Padding(2, 2, 2, 2);
            btnBullingPayment.Name = "btnBullingPayment";
            btnBullingPayment.Size = new Size(175, 27);
            btnBullingPayment.TabIndex = 7;
            btnBullingPayment.Text = "Bulling /Payment";
            btnBullingPayment.UseVisualStyleBackColor = true;
            // 
            // btnGuests
            // 
            btnGuests.Location = new Point(24, 233);
            btnGuests.Margin = new Padding(2, 2, 2, 2);
            btnGuests.Name = "btnGuests";
            btnGuests.Size = new Size(175, 27);
            btnGuests.TabIndex = 8;
            btnGuests.Text = "Guests";
            btnGuests.UseVisualStyleBackColor = true;
            // 
            // btnReservations
            // 
            btnReservations.Location = new Point(24, 190);
            btnReservations.Margin = new Padding(2, 2, 2, 2);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(175, 27);
            btnReservations.TabIndex = 9;
            btnReservations.Text = "Reservations";
            btnReservations.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            btnRooms.Location = new Point(24, 149);
            btnRooms.Margin = new Padding(2, 2, 2, 2);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(175, 27);
            btnRooms.TabIndex = 10;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(24, 573);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 27);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // listAvailableRooms
            // 
            listAvailableRooms.Location = new Point(478, 24);
            listAvailableRooms.Margin = new Padding(2, 2, 2, 2);
            listAvailableRooms.Name = "listAvailableRooms";
            listAvailableRooms.Size = new Size(202, 118);
            listAvailableRooms.TabIndex = 16;
            listAvailableRooms.UseCompatibleStateImageBehavior = false;
            // 
            // listTotalReservtions
            // 
            listTotalReservtions.Location = new Point(236, 24);
            listTotalReservtions.Margin = new Padding(2, 2, 2, 2);
            listTotalReservtions.Name = "listTotalReservtions";
            listTotalReservtions.Size = new Size(202, 118);
            listTotalReservtions.TabIndex = 17;
            listTotalReservtions.UseCompatibleStateImageBehavior = false;
            // 
            // lblOccupiedRooms
            // 
            lblOccupiedRooms.AutoSize = true;
            lblOccupiedRooms.Location = new Point(902, 20);
            lblOccupiedRooms.Margin = new Padding(2, 0, 2, 0);
            lblOccupiedRooms.Name = "lblOccupiedRooms";
            lblOccupiedRooms.Size = new Size(0, 20);
            lblOccupiedRooms.TabIndex = 19;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Location = new Point(478, 17);
            lblAvailableRooms.Margin = new Padding(2, 0, 2, 0);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(121, 20);
            lblAvailableRooms.TabIndex = 20;
            lblAvailableRooms.Text = "Available Rooms";
            // 
            // lblTotalReservtions
            // 
            lblTotalReservtions.AutoSize = true;
            lblTotalReservtions.Location = new Point(236, 17);
            lblTotalReservtions.Margin = new Padding(2, 0, 2, 0);
            lblTotalReservtions.Name = "lblTotalReservtions";
            lblTotalReservtions.Size = new Size(121, 20);
            lblTotalReservtions.TabIndex = 21;
            lblTotalReservtions.Text = "Total Reservtions";
            // 
            // listOccupiedRooms
            // 
            listOccupiedRooms.Location = new Point(716, 24);
            listOccupiedRooms.Margin = new Padding(2, 2, 2, 2);
            listOccupiedRooms.Name = "listOccupiedRooms";
            listOccupiedRooms.Size = new Size(202, 118);
            listOccupiedRooms.TabIndex = 23;
            listOccupiedRooms.UseCompatibleStateImageBehavior = false;
            // 
            // lblOccupiedR
            // 
            lblOccupiedR.AutoSize = true;
            lblOccupiedR.Location = new Point(716, 17);
            lblOccupiedR.Margin = new Padding(2, 0, 2, 0);
            lblOccupiedR.Name = "lblOccupiedR";
            lblOccupiedR.Size = new Size(122, 20);
            lblOccupiedR.TabIndex = 28;
            lblOccupiedR.Text = "Occupied Rooms";
            // 
            // listCheckin
            // 
            listCheckin.Location = new Point(758, 256);
            listCheckin.Margin = new Padding(2, 2, 2, 2);
            listCheckin.Name = "listCheckin";
            listCheckin.Size = new Size(146, 344);
            listCheckin.TabIndex = 29;
            listCheckin.UseCompatibleStateImageBehavior = false;
            // 
            // listRoom
            // 
            listRoom.Location = new Point(593, 256);
            listRoom.Margin = new Padding(2, 2, 2, 2);
            listRoom.Name = "listRoom";
            listRoom.Size = new Size(146, 344);
            listRoom.TabIndex = 30;
            listRoom.UseCompatibleStateImageBehavior = false;
            // 
            // listGuestsName
            // 
            listGuestsName.Location = new Point(440, 256);
            listGuestsName.Margin = new Padding(2, 2, 2, 2);
            listGuestsName.Name = "listGuestsName";
            listGuestsName.Size = new Size(137, 344);
            listGuestsName.TabIndex = 34;
            listGuestsName.UseCompatibleStateImageBehavior = false;
            // 
            // listTodaySchedule
            // 
            listTodaySchedule.Location = new Point(225, 255);
            listTodaySchedule.Margin = new Padding(2, 2, 2, 2);
            listTodaySchedule.Name = "listTodaySchedule";
            listTodaySchedule.Size = new Size(198, 344);
            listTodaySchedule.TabIndex = 36;
            listTodaySchedule.UseCompatibleStateImageBehavior = false;
            // 
            // listTodayCheck
            // 
            listTodayCheck.Location = new Point(954, 24);
            listTodayCheck.Margin = new Padding(2, 2, 2, 2);
            listTodayCheck.Name = "listTodayCheck";
            listTodayCheck.Size = new Size(202, 118);
            listTodayCheck.TabIndex = 39;
            listTodayCheck.UseCompatibleStateImageBehavior = false;
            // 
            // listCheckOut
            // 
            listCheckOut.Location = new Point(1198, 24);
            listCheckOut.Margin = new Padding(2, 2, 2, 2);
            listCheckOut.Name = "listCheckOut";
            listCheckOut.Size = new Size(202, 118);
            listCheckOut.TabIndex = 40;
            listCheckOut.UseCompatibleStateImageBehavior = false;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(647, 255);
            lblRoom.Margin = new Padding(2, 0, 2, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(55, 20);
            lblRoom.TabIndex = 51;
            lblRoom.Text = "Rooms";
            // 
            // lblGuestsName
            // 
            lblGuestsName.AutoSize = true;
            lblGuestsName.Location = new Point(485, 255);
            lblGuestsName.Margin = new Padding(2, 0, 2, 0);
            lblGuestsName.Name = "lblGuestsName";
            lblGuestsName.Size = new Size(96, 20);
            lblGuestsName.TabIndex = 54;
            lblGuestsName.Text = "Guests Name";
            // 
            // lblTodaySchedule
            // 
            lblTodaySchedule.AutoSize = true;
            lblTodaySchedule.Location = new Point(225, 255);
            lblTodaySchedule.Margin = new Padding(2, 0, 2, 0);
            lblTodaySchedule.Name = "lblTodaySchedule";
            lblTodaySchedule.Size = new Size(113, 20);
            lblTodaySchedule.TabIndex = 55;
            lblTodaySchedule.Text = "Today Schedule";
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Location = new Point(252, 152);
            lblQuickActions.Margin = new Padding(2, 0, 2, 0);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(99, 20);
            lblQuickActions.TabIndex = 56;
            lblQuickActions.Text = "Quick Actions";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(1198, 17);
            lblCheckOut.Margin = new Padding(2, 0, 2, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(122, 20);
            lblCheckOut.TabIndex = 57;
            lblCheckOut.Text = "Today Check-Out";
            // 
            // lblTodayCheck
            // 
            lblTodayCheck.AutoSize = true;
            lblTodayCheck.Location = new Point(954, 17);
            lblTodayCheck.Margin = new Padding(2, 0, 2, 0);
            lblTodayCheck.Name = "lblTodayCheck";
            lblTodayCheck.Size = new Size(110, 20);
            lblTodayCheck.TabIndex = 59;
            lblTodayCheck.Text = "Today Check-in";
            // 
            // btnViewRooms
            // 
            btnViewRooms.Location = new Point(1134, 180);
            btnViewRooms.Margin = new Padding(2, 2, 2, 2);
            btnViewRooms.Name = "btnViewRooms";
            btnViewRooms.Size = new Size(164, 48);
            btnViewRooms.TabIndex = 60;
            btnViewRooms.Text = "View Rooms";
            btnViewRooms.UseVisualStyleBackColor = true;
            // 
            // btnCheckOutGuests
            // 
            btnCheckOutGuests.Location = new Point(886, 180);
            btnCheckOutGuests.Margin = new Padding(2, 2, 2, 2);
            btnCheckOutGuests.Name = "btnCheckOutGuests";
            btnCheckOutGuests.Size = new Size(164, 48);
            btnCheckOutGuests.TabIndex = 61;
            btnCheckOutGuests.Text = "Check - Out Guests";
            btnCheckOutGuests.UseVisualStyleBackColor = true;
            // 
            // btnNewReservtions
            // 
            btnNewReservtions.Location = new Point(383, 180);
            btnNewReservtions.Margin = new Padding(2, 2, 2, 2);
            btnNewReservtions.Name = "btnNewReservtions";
            btnNewReservtions.Size = new Size(164, 48);
            btnNewReservtions.TabIndex = 63;
            btnNewReservtions.Text = "New Reservtions";
            btnNewReservtions.UseVisualStyleBackColor = true;
            // 
            // btnCheckInGuests
            // 
            btnCheckInGuests.Location = new Point(628, 180);
            btnCheckInGuests.Margin = new Padding(2, 2, 2, 2);
            btnCheckInGuests.Name = "btnCheckInGuests";
            btnCheckInGuests.Size = new Size(164, 48);
            btnCheckInGuests.TabIndex = 72;
            btnCheckInGuests.Text = "Check - In Guests";
            btnCheckInGuests.UseVisualStyleBackColor = true;
            // 
            // listActions
            // 
            listActions.Location = new Point(1254, 256);
            listActions.Margin = new Padding(2, 2, 2, 2);
            listActions.Name = "listActions";
            listActions.Size = new Size(146, 344);
            listActions.TabIndex = 75;
            listActions.UseCompatibleStateImageBehavior = false;
            // 
            // listSatus
            // 
            listSatus.Location = new Point(1087, 256);
            listSatus.Margin = new Padding(2, 2, 2, 2);
            listSatus.Name = "listSatus";
            listSatus.Size = new Size(146, 344);
            listSatus.TabIndex = 77;
            listSatus.UseCompatibleStateImageBehavior = false;
            // 
            // listCheckout1
            // 
            listCheckout1.Location = new Point(921, 256);
            listCheckout1.Margin = new Padding(2, 2, 2, 2);
            listCheckout1.Name = "listCheckout1";
            listCheckout1.Size = new Size(146, 344);
            listCheckout1.TabIndex = 78;
            listCheckout1.UseCompatibleStateImageBehavior = false;
            // 
            // lblActions
            // 
            lblActions.AutoSize = true;
            lblActions.Location = new Point(1308, 255);
            lblActions.Margin = new Padding(2, 0, 2, 0);
            lblActions.Name = "lblActions";
            lblActions.Size = new Size(58, 20);
            lblActions.TabIndex = 86;
            lblActions.Text = "Actions";
            // 
            // lblSatus
            // 
            lblSatus.AutoSize = true;
            lblSatus.Location = new Point(1141, 255);
            lblSatus.Margin = new Padding(2, 0, 2, 0);
            lblSatus.Name = "lblSatus";
            lblSatus.Size = new Size(44, 20);
            lblSatus.TabIndex = 87;
            lblSatus.Text = "Satus";
            // 
            // Checkout
            // 
            Checkout.AutoSize = true;
            Checkout.Location = new Point(976, 255);
            Checkout.Margin = new Padding(2, 0, 2, 0);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(76, 20);
            Checkout.TabIndex = 88;
            Checkout.Text = "Check-out";
            // 
            // lblChein
            // 
            lblChein.AutoSize = true;
            lblChein.Location = new Point(812, 255);
            lblChein.Margin = new Padding(2, 0, 2, 0);
            lblChein.Name = "lblChein";
            lblChein.Size = new Size(66, 20);
            lblChein.TabIndex = 89;
            lblChein.Text = "Check-in";
            // 
            // frontdeskdashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 630);
            Controls.Add(lblChein);
            Controls.Add(Checkout);
            Controls.Add(lblSatus);
            Controls.Add(lblActions);
            Controls.Add(listCheckout1);
            Controls.Add(listSatus);
            Controls.Add(listActions);
            Controls.Add(btnCheckInGuests);
            Controls.Add(btnNewReservtions);
            Controls.Add(btnCheckOutGuests);
            Controls.Add(btnViewRooms);
            Controls.Add(lblTodayCheck);
            Controls.Add(lblCheckOut);
            Controls.Add(lblQuickActions);
            Controls.Add(lblTodaySchedule);
            Controls.Add(lblGuestsName);
            Controls.Add(lblRoom);
            Controls.Add(listCheckOut);
            Controls.Add(listTodayCheck);
            Controls.Add(listTodaySchedule);
            Controls.Add(listGuestsName);
            Controls.Add(listRoom);
            Controls.Add(listCheckin);
            Controls.Add(lblOccupiedR);
            Controls.Add(listOccupiedRooms);
            Controls.Add(lblTotalReservtions);
            Controls.Add(lblAvailableRooms);
            Controls.Add(lblOccupiedRooms);
            Controls.Add(listTotalReservtions);
            Controls.Add(listAvailableRooms);
            Controls.Add(btnLogout);
            Controls.Add(btnRooms);
            Controls.Add(btnReservations);
            Controls.Add(btnGuests);
            Controls.Add(btnBullingPayment);
            Controls.Add(btnCheckinCheckOut);
            Controls.Add(btnServicesAdd);
            Controls.Add(btnUserRoles);
            Controls.Add(btnReports);
            Controls.Add(btnSettings);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frontdeskdashboardForm";
            Text = "frontdeskdashboardForm";
            Load += frontdeskdashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private Button btnReports;
        private Button button3;
        private Button btnUserRoles;
        private Button btnServicesAdd;
        private Button button6;
        private Button btnCheckinCheckOut;
        private Button btnBullingPayment;
        private Button btnGuests;
        private Button btnReservations;
        private Button btnRooms;
        private Button btnLogout;
        private ListView listAvailableRooms;
        private ListView listTotalReservtions;
        private Label lblCheckin;
        private Label lblOccupiedRooms;
        private Label lblAvailableRooms;
        private Label lblTotalReservtions;
        private ListView listOccupiedRooms;
        private Label lblOccupiedR;
        private ListView listCheckin;
        private ListView listRoom;
        private ListView listGuestsName;
        private ListView listTodaySchedule;
        private ListView listTodayCheck;
        private ListView listCheckOut;
        private ListView listView13;
  
        private Label lblRoom;
        private Label lblRooms;
       
        private Label lblGuestsName;
        private Label lblTodaySchedule;
        private Label lblQuickActions;
        private Label lblCheckOut;
        private Label label17;
        private Label lblTodayCheck;
        private Button btnViewRooms;
        private Button btnCheckOutGuests;
        private Button btnNewReservtions;
     
        private Button btnCheckInGuests;
        private ListView listActions;
        private ListView listView4;
        private ListView listSatus;
        private ListView listCheckout1;
        private ListView listView7;
        private Label lblActions;
        private Label lblSatus;
        private Label Checkout;
        private Label lblChein;
    }
}