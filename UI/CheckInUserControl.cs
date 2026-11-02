using System;
using System.Data;
using System.Windows.Forms;
using HotelReservation.BusinessLogic; // Make sure your business logic namespace is included

namespace UI
{
    public partial class CheckInUserControl : UserControl
    {
        private CheckInController checkInController;
        private int selectedReservationID = -1;
        private int selectedRoomID = -1;

        public CheckInUserControl()
        {
            InitializeComponent();
            checkInController = new CheckInController();

            // Load initial pending reservations on startup
            LoadPendingReservations(string.Empty);
        }

        private void LoadPendingReservations(string searchTerm)
        {
            try
            {
                DataTable dt = checkInController.SearchReservations(searchTerm);
                dgvReservationLookup.DataSource = dt;
                dgvReservationLookup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = cmbSearchRes.Text.Trim(); // Replace with your actual search textbox control name if different
            LoadPendingReservations(searchTerm);
        }

        private void dgvReservationLookup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReservationLookup.Rows[e.RowIndex];
                selectedReservationID = Convert.ToInt32(row.Cells["ReservationID"].Value);
                selectedRoomID = Convert.ToInt32(row.Cells["RoomID"].Value);

                // If you have a guest name or verification field, populate it here:
                // txtGuestName.Text = row.Cells["GuestName"].Value.ToString();
            }
        }

        private void btnConfirmCheckIn_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == -1 || selectedRoomID == -1)
            {
                MessageBox.Show("Please select a reservation from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string keyCardNumber = txtKeyCard.Text.Trim(); // Replace with your key card textbox name
            string remarks = txtRemarks.Text.Trim(); // Replace with your remarks textbox name

            try
            {
                bool success = checkInController.ProcessCheckIn(selectedReservationID, selectedRoomID, keyCardNumber, remarks);

                if (success)
                {
                    MessageBox.Show("Check-In processed successfully! Room status updated to Occupied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the grid and clear inputs
                    LoadPendingReservations(string.Empty);
                    selectedReservationID = -1;
                    selectedRoomID = -1;
                    txtKeyCard.Clear();
                    txtRemarks.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check-In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}