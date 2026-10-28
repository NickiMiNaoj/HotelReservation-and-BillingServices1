using System.Data;

namespace UI
{
    public partial class AvailabilityViewUserControl : UserControl
    {
        public AvailabilityViewUserControl()
        {
            InitializeComponent();
            SetupSampleData();
        }

        private void SetupSampleData()
        {
            // Plain DataTable binding for layout display purposes only
            DataTable dt = new DataTable();
            dt.Columns.Add("Room No.", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Rate", typeof(decimal));
            dt.Columns.Add("Floor", typeof(int));
            dt.Columns.Add("Max Capacity", typeof(int));
            dt.Columns.Add("Status", typeof(string));

            dt.Rows.Add("01", "Deluxe 1", 30.00m, 1, 3, "Available");
            dt.Rows.Add("02", "Suite 2", 30.00m, 1, 3, "Booked");
            dt.Rows.Add("03", "Deluxe 1", 85.00m, 2, 3, "Available");
            dt.Rows.Add("04", "Suite 2", 100.00m, 2, 8, "Booked");
            dt.Rows.Add("05", "Suite 2", 75.00m, 2, 3, "Available");
            dt.Rows.Add("06", "Executive 3", 55.00m, 3, 3, "Available");
            dt.Rows.Add("07", "Connecting", 50.00m, 4, 9, "Booked");
            dt.Rows.Add("08", "Penthouse", 35.00m, 5, 6, "Available");

            dgvAvailableRooms.DataSource = dt;
        }
    }
}