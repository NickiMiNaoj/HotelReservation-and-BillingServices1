using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class CheckInUserControl : UserControl
    {
        public CheckInUserControl()
        {
            InitializeComponent();
            SetupSampleData();
        }

        private void SetupSampleData()
        {
            // Sample Data for Reservation Lookup DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Res. ID", typeof(string));
            dt.Columns.Add("Guest Name", typeof(string));
            dt.Columns.Add("Arrival", typeof(string));
            dt.Columns.Add("Departure", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            dt.Rows.Add("1", "Anna", "07/04/2026", "27/01/2026", "Cleared");
            dt.Rows.Add("2", "Kannika", "07/05/2026", "30/01/2026", "Confirmed");

            dgvReservationLookup.DataSource = dt;
            dgvReservationLookup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}