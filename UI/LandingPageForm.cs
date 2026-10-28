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
            LoadUserControl((RoomReservationUserControl)avControl);
        }
    }
}
