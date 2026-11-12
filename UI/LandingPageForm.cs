using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class LandingPageForm : Form
    {
        public LandingPageForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlHandlingUC.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlHandlingUC.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            AvailabilityViewUserControl avControl = new AvailabilityViewUserControl();
            LoadUserControl(avControl);
        }

        private void btnRoomReservation_Click(object sender, EventArgs e)
        {
            RoomReservationUserControl avControl = new RoomReservationUserControl();
            LoadUserControl(avControl);
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            CheckInCheckOutUserControl avControl = new CheckInCheckOutUserControl();
            LoadUserControl(avControl);
        }

        private void btnBillingPayment_Click(object sender, EventArgs e)
        {
            BillingPaymentUserControl avControl = new BillingPaymentUserControl();
            LoadUserControl(avControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;

            dashboardForm.Dock = DockStyle.Fill;
            pnlHandlingUC.Controls.Clear();
            pnlHandlingUC.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomsMaintenanceUserControl roomsMaintenanceUserControl = new RoomsMaintenanceUserControl();
            LoadUserControl(roomsMaintenanceUserControl);
        }

        private void btnUserRole_Click(object sender, EventArgs e)
        {
            UserRolesManagementUserControl userRolesManagementUserControl = new UserRolesManagementUserControl();
            LoadUserControl(userRolesManagementUserControl);
        }
    }
}
