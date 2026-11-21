using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;
using System.Data;
using Microsoft.Data.SqlClient;

namespace UI
{
    public partial class RoomReservationUserControl : UserControl
    {
        private readonly string connectionString = @"Server=.\SQLEXPRESS09;Database=HotelReservationDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private readonly ReservationController _reservationController = new ReservationController();
        private readonly RoomController _roomController = new RoomController();
        private List<Room> _rooms = new List<Room>();
        private int _selectedReservationId = 0;

        // Set this from your Dashboard/Login session
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentEmployeeID { get; set; } = 1;

        public RoomReservationUserControl()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load += RoomReservationUserControl_Load;

            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnCancel.Click += btnCancel_Click;
            btnClear.Click += btnClear_Click;
            btnPrint.Click += btnPrint_Click;
            btnAddGuest.Click += btnAddGuest_Click;

            cmbRoomNo.SelectedIndexChanged += cmbRoomNo_SelectedIndexChanged;
            dtpArrival.ValueChanged += dtpArrival_ValueChanged;
            dtpDeparture.ValueChanged += dtpDeparture_ValueChanged;
            numAddCharges.ValueChanged += numAddCharges_ValueChanged;
            numDiscount.ValueChanged += numDiscount_ValueChanged;

            dgvReservations.CellClick += dgvReservations_CellClick;
        }

        private void RoomReservationUserControl_Load(object? sender, EventArgs e)
        {
            LoadGuestDropdown();
            LoadRoomsDropdown();
            LoadReservationsGrid();
            ClearForm();
        }

        private void LoadRoomsDropdown()
        {
            _rooms = _roomController.GetAllRooms();
            cmbRoomNo.DataSource = _rooms;
            cmbRoomNo.DisplayMember = "RoomNumber";
            cmbRoomNo.ValueMember = "RoomID";
        }

        private void LoadReservationsGrid(string? keyword = null)
        {
            dgvReservations.DataSource = string.IsNullOrWhiteSpace(keyword)
                ? _reservationController.GetAllReservations(CurrentEmployeeID)
                : _reservationController.GetAllReservations(CurrentEmployeeID, keyword);

            string[] hiddenCols = { "GuestID", "RoomID", "IsDeleted", "DeletedAt", "DeletedByName" };
            foreach (string col in hiddenCols)
            {
                var column = dgvReservations.Columns[col];
                if (column != null)
                    column.Visible = false;
            }
        }

        // Updates lblRoomTypeVal and txtRatePerNight when cmbRoomNo changes
        private void cmbRoomNo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbRoomNo.SelectedItem is Room selectedRoom)
            {
                lblRoomTypeVal.Text = selectedRoom.RoomType;
                txtRatePerNight.Text = selectedRoom.NightlyRate.ToString("0.00");
                UpdateLiveTotals();
            }
        }

        // ARRIVAL DATE CONDITION:
        // If Arrival is Nov 11, Departure calendar disables Nov 11, Nov 10, and earlier (MinDate = Nov 12)
        private void dtpArrival_ValueChanged(object? sender, EventArgs e)
        {
            if (_selectedReservationId == 0 && dtpArrival.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Arrival date cannot be in the past.", "Invalid Arrival Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpArrival.Value = DateTime.Today;
                return;
            }

            DateTime minDeparture = dtpArrival.Value.Date.AddDays(1);
            dtpDeparture.MinDate = minDeparture;

            if (dtpDeparture.Value.Date < minDeparture)
            {
                dtpDeparture.Value = minDeparture;
            }

            UpdateLiveTotals();
        }

        // DEPARTURE DATE CONDITION: Safety check if typed manually
        private void dtpDeparture_ValueChanged(object? sender, EventArgs e)
        {
            DateTime minDeparture = dtpArrival.Value.Date.AddDays(1);
            if (dtpDeparture.Value.Date < minDeparture)
            {
                MessageBox.Show("Departure date cannot be on or before the arrival date.", "Invalid Departure Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDeparture.Value = minDeparture;
                return;
            }

            UpdateLiveTotals();
        }

        private void numAddCharges_ValueChanged(object? sender, EventArgs e) => UpdateLiveTotals();
        private void numDiscount_ValueChanged(object? sender, EventArgs e) => UpdateLiveTotals();

        // Live preview matching tblReservations persisted formulas
        private void UpdateLiveTotals()
        {
            int nights = (dtpDeparture.Value.Date - dtpArrival.Value.Date).Days;
            if (nights < 1) nights = 1;
            txtTotalNights.Text = nights.ToString();

            decimal.TryParse(txtRatePerNight.Text, out decimal rate);
            decimal additional = numAddCharges.Value;
            decimal discount = numDiscount.Value;

            decimal total = (nights * rate) + additional - discount;
            if (total < 0) total = 0;

            txtTotalAmount.Text = total.ToString("0.00");
        }

        // Front-end guard before calling ReservationController
        private bool ValidateDateConditions(bool isNewBooking)
        {
            if (isNewBooking && dtpArrival.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Arrival date cannot be earlier than today.", "Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpDeparture.Value.Date <= dtpArrival.Value.Date)
            {
                MessageBox.Show("Departure date must be after the arrival date.", "Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private Reservation BuildModelFromForm()
        {
            return new Reservation
            {
                ReservationID = _selectedReservationId,
                GuestID = cmbGuest.SelectedValue != null ? Convert.ToInt32(cmbGuest.SelectedValue) : 0,
                RoomID = cmbRoomNo.SelectedValue != null ? Convert.ToInt32(cmbRoomNo.SelectedValue) : 0,
                CheckInDate = dtpArrival.Value.Date,
                CheckOutDate = dtpDeparture.Value.Date,
                NumAdults = (int)numAdults.Value,
                NumChildren = (int)numChildren.Value,
                SpecialRequests = txtSpecialReq.Text.Trim(),
                AdditionalCharges = numAddCharges.Value,
                Discount = numDiscount.Value,
                Status = "Confirmed"
            };
        }

        // SAVE RESERVATION (btnSave)
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (!ValidateDateConditions(isNewBooking: true)) return;

            Reservation res = BuildModelFromForm();

            if (_reservationController.AddReservation(res, out string message))
            {
                txtResId.Text = res.ReservationID.ToString();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservationsGrid();
                ClearForm();
            }
            else
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // UPDATE RESERVATION (btnUpdate)
        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (_selectedReservationId <= 0)
            {
                MessageBox.Show("Select a reservation from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateDateConditions(isNewBooking: false)) return;

            if (MessageBox.Show("Save changes to this reservation?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Reservation res = BuildModelFromForm();

            if (_reservationController.UpdateReservation(res, out string message))
            {
                MessageBox.Show(message, "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservationsGrid();
            }
            else
            {
                MessageBox.Show(message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // CANCEL / SOFT-DELETE RESERVATION (btnCancel)
        private void btnCancel_Click(object? sender, EventArgs e)
        {
            if (_selectedReservationId <= 0)
            {
                MessageBox.Show("Select a reservation from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Delete/cancel this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            if (_reservationController.DeleteReservation(_selectedReservationId, CurrentEmployeeID, out string message))
            {
                MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservationsGrid();
                ClearForm();
            }
            else
            {
                MessageBox.Show(message, "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // CLEAR FORM (btnClear)
        private void btnClear_Click(object? sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            _selectedReservationId = 0;
            dgvReservations.ClearSelection();

            txtResId.Text = "Auto-Generated";
            if (cmbGuest.Items.Count > 0) cmbGuest.SelectedIndex = 0;
            if (cmbRoomNo.Items.Count > 0) cmbRoomNo.SelectedIndex = 0;

            // Relax MinDate first so resetting dates never triggers out-of-range conflicts
            dtpArrival.MinDate = DateTimePicker.MinimumDateTime;
            dtpDeparture.MinDate = DateTimePicker.MinimumDateTime;

            dtpArrival.Value = DateTime.Today;
            dtpArrival.MinDate = DateTime.Today;

            dtpDeparture.Value = DateTime.Today.AddDays(1);
            dtpDeparture.MinDate = DateTime.Today.AddDays(1);

            numAdults.Value = numAdults.Minimum > 1 ? numAdults.Minimum : 1;
            numChildren.Value = 0;
            txtSpecialReq.Clear();
            numAddCharges.Value = 0;
            numDiscount.Value = 0;
            UpdateLiveTotals();
        }

        // PRINT RESERVATION SLIP (btnPrint)
        private void btnPrint_Click(object? sender, EventArgs e)
        {
            if (_selectedReservationId <= 0 && string.IsNullOrWhiteSpace(cmbRoomNo.Text))
            {
                MessageBox.Show("Select a reservation from the table or fill out the form before printing.", "Nothing to Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = $"Reservation_{txtResId.Text}";

            printDoc.PrintPage += (s, ev) =>
            {
                if (ev.Graphics == null) return;

                using Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
                using Font headerFont = new Font("Segoe UI", 11, FontStyle.Bold);
                using Font bodyFont = new Font("Segoe UI", 10, FontStyle.Regular);
                using Pen linePen = new Pen(Color.Gray, 1);

                float x = 60;
                float y = 60;
                float lineHeight = 26;

                ev.Graphics.DrawString("HOTEL RESERVATION CONFIRMATION", titleFont, Brushes.Black, x, y);
                y += 35;
                ev.Graphics.DrawString($"Printed on: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", bodyFont, Brushes.DimGray, x, y);
                y += 25;
                ev.Graphics.DrawLine(linePen, x, y, 750, y);
                y += 20;

                void DrawRow(string label, string value)
                {
                    ev.Graphics.DrawString(label, headerFont, Brushes.Black, x, y);
                    ev.Graphics.DrawString(value, bodyFont, Brushes.Black, x + 200, y);
                    y += lineHeight;
                }

                DrawRow("Reservation ID:", txtResId.Text);
                DrawRow("Guest Name:", cmbGuest.Text);
                DrawRow("Room Number:", $"{cmbRoomNo.Text} ({lblRoomTypeVal.Text})");
                DrawRow("Arrival Date:", dtpArrival.Value.ToString("MMMM dd, yyyy"));
                DrawRow("Departure Date:", dtpDeparture.Value.ToString("MMMM dd, yyyy"));
                DrawRow("Guests:", $"{numAdults.Value} Adult(s), {numChildren.Value} Child(ren)");
                DrawRow("Special Requests:", string.IsNullOrWhiteSpace(txtSpecialReq.Text) ? "None" : txtSpecialReq.Text);

                y += 10;
                ev.Graphics.DrawLine(linePen, x, y, 750, y);
                y += 20;

                DrawRow("Rate Per Night:", txtRatePerNight.Text);
                DrawRow("Total Nights:", txtTotalNights.Text);
                DrawRow("Additional Charges:", numAddCharges.Value.ToString("0.00"));
                DrawRow("Discount:", numDiscount.Value.ToString("0.00"));

                y += 5;
                ev.Graphics.DrawString("TOTAL AMOUNT:", titleFont, Brushes.Black, x, y);
                ev.Graphics.DrawString(txtTotalAmount.Text, titleFont, Brushes.Black, x + 200, y);
            };

            using PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 850,
                Height = 650,
                StartPosition = FormStartPosition.CenterParent
            };
            preview.ShowDialog();
        }

        // Populate form fields when a row in dgvReservations is clicked
        private void dgvReservations_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvReservations.Rows[e.RowIndex].DataBoundItem is Reservation selected)
            {
                _selectedReservationId = selected.ReservationID;
                txtResId.Text = selected.ReservationID.ToString();
                cmbGuest.SelectedValue = selected.GuestID;
                cmbRoomNo.SelectedValue = selected.RoomID;
                lblRoomTypeVal.Text = selected.RoomType;

                // Temporarily relax MinDate so historical reservations load cleanly without ArgumentOutOfRangeException
                dtpArrival.MinDate = DateTimePicker.MinimumDateTime;
                dtpDeparture.MinDate = DateTimePicker.MinimumDateTime;

                dtpArrival.Value = selected.CheckInDate;
                dtpDeparture.MinDate = selected.CheckInDate.Date.AddDays(1);
                dtpDeparture.Value = selected.CheckOutDate;

                numAdults.Value = selected.NumAdults;
                numChildren.Value = selected.NumChildren;
                txtSpecialReq.Text = selected.SpecialRequests;
                txtRatePerNight.Text = selected.RoomRate.ToString("0.00");
                txtTotalNights.Text = selected.TotalNights.ToString();
                numAddCharges.Value = selected.AdditionalCharges;
                numDiscount.Value = selected.Discount;
                txtTotalAmount.Text = selected.TotalAmount.ToString("0.00");
            }
        }

        // ADD NEW GUEST
        private void btnAddGuest_Click(object? sender, EventArgs e)
        {
            // Get the current highest Guest ID before opening the form
            int previousGuestID = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(GuestID), 0) FROM dbo.tblGuests";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    previousGuestID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            // Open Guest Maintenance
            using (Form guestForm = new Form())
            {
                guestForm.Text = "Guest Maintenance";
                guestForm.Size = new Size(1300, 850);
                guestForm.StartPosition = FormStartPosition.CenterParent;
                guestForm.FormBorderStyle = FormBorderStyle.Sizable;
                guestForm.MaximizeBox = true;
                guestForm.MinimizeBox = false;

                GuestMaintenanceUserControl guestControl =
                    new GuestMaintenanceUserControl();

                guestControl.Dock = DockStyle.Fill;

                guestForm.Controls.Add(guestControl);

                guestForm.ShowDialog(this.FindForm());
            }

            // Check if a new guest was registered
            int? newGuestID = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT MAX(GuestID)
            FROM dbo.tblGuests
            WHERE IsActive = 1 AND GuestID > @PreviousGuestID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PreviousGuestID", previousGuestID);

                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                        newGuestID = Convert.ToInt32(result);
                }
            }

            // Refresh guest ComboBox
            LoadGuestDropdown(newGuestID);

            if (newGuestID.HasValue)
            {
                MessageBox.Show(
                    "New guest has been added and selected automatically!",
                    "Guest Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // LOAD ACTIVE GUESTS INTO COMBOBOX
        private void LoadGuestDropdown(int? guestIDToSelect = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT GuestID,
                   FirstName + ' ' + LastName AS GuestName
            FROM dbo.tblGuests
            WHERE IsActive = 1
            ORDER BY FirstName, LastName";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbGuest.DataSource = null;
                    cmbGuest.DisplayMember = "GuestName";
                    cmbGuest.ValueMember = "GuestID";
                    cmbGuest.DataSource = dt;

                    if (guestIDToSelect.HasValue &&
                        dt.Rows.Count > 0 &&
                        dt.Select("GuestID = " + guestIDToSelect.Value).Length > 0)
                    {
                        cmbGuest.SelectedValue = guestIDToSelect.Value;
                    }
                    else
                    {
                        cmbGuest.SelectedIndex = -1;
                    }
                }
            }
        }
    }
}