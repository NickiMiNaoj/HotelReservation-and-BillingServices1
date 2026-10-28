using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class CheckInCheckOutUserControl : UserControl
    {
        public CheckInCheckOutUserControl()
        {
            InitializeComponent();
        }

        private void CheckInCheckOutUserControl_Load(object sender, EventArgs e)
        {
            CheckInUserControl checkInUserControl = new CheckInUserControl();
            LoadUserControl(checkInUserControl);
        }
        private void LoadUserControl(UserControl uc)
        {
            pnlHandlingUC.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlHandlingUC.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInUserControl checkInUserControl = new CheckInUserControl();
            LoadUserControl(checkInUserControl);

            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = true;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutUserControl checkOutUserControl = new CheckOutUserControl();
            LoadUserControl(checkOutUserControl);

            btnCheckOut.Enabled = false;
            btnCheckIn.Enabled = true;
        }
    }
}