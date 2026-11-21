using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
    public partial class AvailabilityViewUserControl : UserControl
    {
        private readonly RoomAvailabilityController _controller = new RoomAvailabilityController();

        public event Action<int, DateTime, DateTime>? BookRoomRequested;

        public AvailabilityViewUserControl()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load += AvailabilityViewUserControl_Load;
            btnSearch.Click += btnSearch_Click;
            btnViewDetails.Click += btnViewRoomDetails_Click;
            btnBookSelected.Click += btnBookSelectedRoom_Click;
        }

        private void AvailabilityViewUserControl_Load(object? sender, EventArgs e)
        {
            if (numMaxPrice.Maximum < 100000m)
                numMaxPrice.Maximum = 100000m;

            if (numMaxPrice.Value <= 100m)
                numMaxPrice.Value = 10000m;

            if (dtpCheckOut.Value <= dtpCheckIn.Value)
                dtpCheckOut.Value = dtpCheckIn.Value.Date.AddDays(1).Add(dtpCheckOut.Value.TimeOfDay);

            LoadRoomTypes();
            LoadRoomsGrid();
        }

        private void LoadRoomTypes()
        {
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.Add("All Types");

            DataTable types = _controller.GetRoomTypes();
            foreach (DataRow row in types.Rows)
            {
                string typeName = row["RoomType"]?.ToString() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(typeName) && !cmbRoomType.Items.Contains(typeName))
                    cmbRoomType.Items.Add(typeName);
            }

            cmbRoomType.SelectedIndex = 0;
        }

        private void LoadRoomsGrid()
        {
            try
            {
                string selectedType = cmbRoomType.SelectedItem?.ToString() ?? "All Types";
                decimal minPrice = numMinPrice.Value;
                decimal maxPrice = numMaxPrice.Value;

                DataTable dt = _controller.SearchRooms(
                    dtpCheckIn.Value,
                    dtpCheckOut.Value,
                    selectedType,
                    minPrice,
                    maxPrice);

                dgvAvailableRooms.DataSource = dt;

                string[] hiddenCols = { "RoomID", "BedType", "Description", "Amenities" };
                foreach (string col in hiddenCols)
                {
                    if (dgvAvailableRooms.Columns.Contains(col))
                        dgvAvailableRooms.Columns[col].Visible = false;
                }

                if (dgvAvailableRooms.Columns.Contains("Rate"))
                    dgvAvailableRooms.Columns["Rate"].DefaultCellStyle.Format = "0.00";

                if (lblStatus != null)
                    lblStatus.Text = $"Availability View Status: Ready ({dt.Rows.Count} room(s))";
            }
            catch (Exception ex)
            {
                if (lblStatus != null)
                    lblStatus.Text = "Availability View Status: Error";

                MessageBox.Show(ex.Message, "Availability Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadRoomsGrid();
        }

        private DataRow? GetSelectedRoomRow()
        {
            if (dgvAvailableRooms.CurrentRow == null || dgvAvailableRooms.CurrentRow.DataBoundItem is not DataRowView drv)
                return null;

            return drv.Row;
        }

        private void btnViewRoomDetails_Click(object? sender, EventArgs e)
        {
            DataRow? row = GetSelectedRoomRow();
            if (row == null)
            {
                MessageBox.Show("Please select a room in the table first.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bedType = row.Table.Columns.Contains("BedType") ? row["BedType"]?.ToString() ?? "-" : "-";
            string description = row.Table.Columns.Contains("Description") ? row["Description"]?.ToString() ?? "-" : "-";
            string amenities = row.Table.Columns.Contains("Amenities") ? row["Amenities"]?.ToString() ?? "-" : "-";

            string details =
                $"Room No.: {row["Room No."]}\n" +
                $"Type: {row["Type"]}\n" +
                $"Bed Type: {bedType}\n" +
                $"Floor: {row["Floor"]}\n" +
                $"Max Capacity: {row["Max Capacity"]}\n" +
                $"Nightly Rate: {Convert.ToDecimal(row["Rate"]):0.00}\n" +
                $"Status: {row["Status"]}\n" +
                $"Amenities: {(string.IsNullOrWhiteSpace(amenities) ? "-" : amenities)}\n" +
                $"Description: {(string.IsNullOrWhiteSpace(description) ? "-" : description)}";

            MessageBox.Show(details, $"Room {row["Room No."]} Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBookSelectedRoom_Click(object? sender, EventArgs e)
        {
            DataRow? row = GetSelectedRoomRow();
            if (row == null)
            {
                MessageBox.Show("Please select a room in the table first.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = row["Status"]?.ToString() ?? string.Empty;
            if (!status.Equals("Available", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    $"Room {row["Room No."]} is currently '{status}' and cannot be booked.",
                    "Room Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int roomId = Convert.ToInt32(row["RoomID"]);

            if (BookRoomRequested != null)
            {
                BookRoomRequested.Invoke(roomId, dtpCheckIn.Value, dtpCheckOut.Value);
                return;
            }

            MessageBox.Show(
                $"Selected Room {row["Room No."]} ({row["Type"]}) for {dtpCheckIn.Value:MMM dd, yyyy} to {dtpCheckOut.Value:MMM dd, yyyy}.",
                "Room Ready for Reservation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}