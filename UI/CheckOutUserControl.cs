using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class CheckOutUserControl : UserControl
    {
        public CheckOutUserControl()
        {
            InitializeComponent();
            SetupSampleData();
        }

        private void SetupSampleData()
        {
            // Sample Data for Active Stay Lookup DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Res. ID", typeof(string));
            dt.Columns.Add("Guest Name", typeof(string));
            dt.Columns.Add("Arrival", typeof(string));
            dt.Columns.Add("Departure", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            dt.Rows.Add("1", "Anna", "07/07/2026", "11:00:00", "Cleared");
            dt.Rows.Add("2", "Ranis", "07/09/2026", "11:00:00", "Cleared");
            dt.Rows.Add("3", "Kannita", "07/04/2026", "13:30:00", "Cleared");

            dgvActiveStays.DataSource = dt;
            dgvActiveStays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}