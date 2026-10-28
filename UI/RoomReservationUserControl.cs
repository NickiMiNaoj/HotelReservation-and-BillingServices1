using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class RoomReservationUserControl : UserControl
    {
        public RoomReservationUserControl()
        {
            InitializeComponent();
            SetupSampleData();
        }

        private void SetupSampleData()
        {
            // Plain DataTable binding for layout display purposes only
            DataTable dt = new DataTable();
            dt.Columns.Add("Res. ID", typeof(string));
            dt.Columns.Add("Guest Name", typeof(string));
            dt.Columns.Add("Room No.", typeof(string));
            dt.Columns.Add("Arrival", typeof(string));
            dt.Columns.Add("Departure", typeof(string));
            dt.Columns.Add("Adults", typeof(int));
            dt.Columns.Add("Children", typeof(int));
            dt.Columns.Add("Total Amount", typeof(decimal));
            dt.Columns.Add("Status", typeof(string));

            dt.Rows.Add("R-2026102703", "Sarah Jenkins", "112", "2026-11-01", "2026-11-01", 2, 1, 450.00m, "Confirmed");
            dt.Rows.Add("R-2026102801", "Alexander Pierce", "110", "2026-11-01", "2026-11-05", 2, 1, 615.00m, "Confirmed");
            dt.Rows.Add("R-2026102805", "Michael Lee", "108", "2026-11-01", "2026-11-05", 2, 1, 380.00m, "Pending");
            dt.Rows.Add("R-2026102805", "Michael Lee", "108", "2026-11-01", "2026-11-05", 1, 0, 380.00m, "Cancelled");

            dgvReservations.DataSource = dt;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}