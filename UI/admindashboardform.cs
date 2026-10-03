using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class admindashboardform : Form
    {
        public admindashboardform()
        {
            InitializeComponent();
        }

        private void btnGuestMaintenance_Click(object sender, EventArgs e)
        {
            guest_maintenanceform guestForm = new guest_maintenanceform();
            guestForm.Show();
        }
    }
}
