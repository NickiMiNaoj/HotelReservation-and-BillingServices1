
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HotelReservation.BusinessLogic;

namespace UI
{
    public partial class CheckInUserControl : UserControl
    {
        private readonly CheckInController controller;

        private int selectedReservationID = 0;
        private int selectedRoomID = 0;
        private string selectedPaymentStatus = "";

        public CheckInUserControl()
        {
            InitializeComponent();

            controller = new CheckInController();

            // FORM EVENTS
            this.Load += CheckInUserControl_Load;

            // BUTTON EVENTS
            btnSearch.Click += btnSearch_Click;
            btnSearchIcon.Click += btnSearch_Click;
            btnClearLookup.Click += btnClearLookup_Click;
            btnConfirmCheckIn.Click += btnConfirmCheckIn_Click;

            // DATAGRIDVIEW EVENT
            dgvReservationLookup.CellClick +=
                dgvReservationLookup_CellClick;
        }

        // LOAD FORM
        private void CheckInUserControl_Load(object sender, EventArgs e)
        {
            SetupReservationGrid();
            LoadReservations("");
            ClearSelectedReservation();
        }

        // DATAGRIDVIEW SETTINGS
        private void SetupReservationGrid()
        {
            dgvReservationLookup.AutoGenerateColumns = true;
            dgvReservationLookup.ReadOnly = true;
            dgvReservationLookup.AllowUserToAddRows = false;
            dgvReservationLookup.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvReservationLookup.MultiSelect = false;
            dgvReservationLookup.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // LOAD RESERVATIONS
        private void LoadReservations(string searchTerm)
        {
            try
            {
                DataTable dt =
                    controller.SearchReservations(searchTerm);

                dgvReservationLookup.DataSource = dt;

                if (dgvReservationLookup.Columns.Contains("GuestID"))
                    dgvReservationLookup.Columns["GuestID"].Visible = false;

                if (dgvReservationLookup.Columns.Contains("RoomID"))
                    dgvReservationLookup.Columns["RoomID"].Visible = false;

                if (dgvReservationLookup.Columns.Contains("TotalPaid"))
                    dgvReservationLookup.Columns["TotalPaid"].Visible = false;

                if (dgvReservationLookup.Columns.Contains("TotalAmountDue"))
                    dgvReservationLookup.Columns["TotalAmountDue"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load reservations.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SEARCH RESERVATIONS
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = cmbSearchRes.Text.Trim();

            LoadReservations(searchTerm);

            ClearSelectedReservation();
        }

        // SELECT RESERVATION
        private void dgvReservationLookup_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvReservationLookup.Rows[e.RowIndex];

            try
            {
                selectedReservationID =
                    Convert.ToInt32(row.Cells["ReservationID"].Value);

                selectedRoomID =
                    Convert.ToInt32(row.Cells["RoomID"].Value);

                txtGuestName.Text =
                    row.Cells["GuestName"].Value?.ToString() ?? "";

                selectedPaymentStatus =
                    row.Cells["PaymentStatus"].Value?.ToString() ?? "PENDING";

                // DISPLAY PAYMENT STATUS
                lblPaymentStatus.Text =
                    "Payment Status: " + selectedPaymentStatus;

                if (selectedPaymentStatus == "CLEARED")
                {
                    lblPaymentStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblPaymentStatus.ForeColor = Color.Red;
                }

                // RESET VERIFICATION
                chkIdVerified.Checked = false;
                chkKeyIssued.Checked = false;
                txtKeyCard.Clear();

                UpdateCheckInButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to display reservation details.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // UPDATE CONFIRM BUTTON
        private void UpdateCheckInButton()
        {
            btnConfirmCheckIn.Enabled =
                selectedReservationID > 0 &&
                selectedPaymentStatus == "CLEARED" &&
                chkIdVerified.Checked &&
                chkKeyIssued.Checked &&
                !string.IsNullOrWhiteSpace(txtKeyCard.Text);
        }

        // GUEST ID VERIFICATION
        private void chkIdVerified_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateCheckInButton();
        }

        // ROOM KEY ISSUANCE
        private void chkKeyIssued_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateCheckInButton();
        }

        // KEY CARD VALIDATION
        private void txtKeyCard_TextChanged(
            object sender, EventArgs e)
        {
            UpdateCheckInButton();
        }

        // CONFIRM CHECK-IN
        private void btnConfirmCheckIn_Click(
            object sender, EventArgs e)
        {
            if (selectedReservationID == 0)
            {
                MessageBox.Show(
                    "Please select a reservation first.",
                    "No Reservation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (selectedPaymentStatus != "CLEARED")
            {
                MessageBox.Show(
                    "Payment must be cleared before check-in.",
                    "Payment Pending",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!chkIdVerified.Checked)
            {
                MessageBox.Show(
                    "Please verify the guest's identification.",
                    "Verification Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!chkKeyIssued.Checked)
            {
                MessageBox.Show(
                    "Please confirm that the room key has been issued.",
                    "Key Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string keyCardNumber = txtKeyCard.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyCardNumber))
            {
                MessageBox.Show(
                    "Please enter the key card number.",
                    "Missing Key Card",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtKeyCard.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to confirm check-in?",
                "Confirm Check-In",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                bool success = controller.ProcessCheckIn(
                selectedReservationID,
                selectedRoomID,
                keyCardNumber,
                string.Empty
                );

                if (success)
                {
                    MessageBox.Show(
                        "Guest check-in completed successfully!",
                        "Check-In Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadReservations(cmbSearchRes.Text.Trim());

                    ClearSelectedReservation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Check-in failed.\n" + ex.Message,
                    "Check-In Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // CLEAR SELECTED RESERVATION
        private void ClearSelectedReservation()
        {
            selectedReservationID = 0;
            selectedRoomID = 0;
            selectedPaymentStatus = "";

            txtGuestName.Clear();
            txtKeyCard.Clear();

            chkIdVerified.Checked = false;
            chkKeyIssued.Checked = false;

            lblPaymentStatus.Text = "Payment Status: N/A";
            lblPaymentStatus.ForeColor = Color.Black;

            btnConfirmCheckIn.Enabled = false;

            dgvReservationLookup.ClearSelection();
        }

        // CLEAR SEARCH
        private void btnClearLookup_Click(object sender, EventArgs e)
        {
            cmbSearchRes.SelectedIndex = -1;
            cmbSearchRes.Text = "";

            LoadReservations("");

            ClearSelectedReservation();
        }
    }
}
