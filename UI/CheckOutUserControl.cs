using System;
using System.Data;
using System.Windows.Forms;
using HotelReservation.BusinessLogic; // Ensures business logic connection

namespace UI
{
    public partial class CheckOutUserControl : UserControl
    {
        private CheckOutController checkOutController;
        private int selectedReservationID = -1;
        private int selectedRoomID = -1;
        private decimal currentTotalDue = 0.00m;
        private decimal currentAmountPaid = 0.00m;

        public CheckOutUserControl()
        {
            InitializeComponent();
            checkOutController = new CheckOutController();

            // Load active stays on startup
            LoadActiveStays(string.Empty);
        }

        private void LoadActiveStays(string searchTerm)
        {
            try
            {
                DataTable dt = checkOutController.SearchActiveStays(searchTerm);
                dgvActiveStays.DataSource = dt;
                dgvActiveStays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active stays: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchActiveStay_Click(object sender, EventArgs e)
        {
            string searchTerm = cmbSearchRes.Text.Trim(); // Make sure textbox matches your designer name
            LoadActiveStays(searchTerm);
        }

        private void dgvActiveStays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvActiveStays.Rows[e.RowIndex];
                selectedReservationID = Convert.ToInt32(row.Cells["ReservationID"].Value);
                selectedRoomID = Convert.ToInt32(row.Cells["RoomID"].Value);

                // Optional: Map financial columns if your active stay view/query includes them
                // currentTotalDue = Convert.ToDecimal(row.Cells["TotalDue"].Value);
                // currentAmountPaid = Convert.ToDecimal(row.Cells["AmountPaid"].Value);
            }
        }

        private void btnFinalizeCheckOut_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == -1 || selectedRoomID == -1)
            {
                MessageBox.Show("Please select an active stay from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime actualCheckOutTime = dtpActualOut.Value; // Make sure datetime picker matches designer
            string remarks = txtRemarks.Text.Trim(); // Make sure remarks textbox matches designer

            try
            {
                // Enforces zero-balance rule & updates database status
                bool success = checkOutController.ProcessCheckOut(
                    selectedReservationID,
                    selectedRoomID,
                    currentTotalDue,
                    currentAmountPaid,
                    actualCheckOutTime,
                    remarks
                );

                if (success)
                {
                    MessageBox.Show("Check-Out finalized successfully! Room status updated to Needs Housekeeping.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid and reset selections
                    LoadActiveStays(string.Empty);
                    selectedReservationID = -1;
                    selectedRoomID = -1;
                    txtRemarks.Clear();
                }
            }
            catch (InvalidOperationException ex)
            {
                // Catches zero-balance / unpaid balance warnings
                MessageBox.Show(ex.Message, "Check-Out Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check-Out Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearLookup_Click(object sender, EventArgs e)
        {
            cmbSearchRes.Items.Clear();
            LoadActiveStays(string.Empty);
        }
    }
}