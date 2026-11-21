using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
    public partial class CheckOutUserControl : UserControl
    {
        private readonly CheckOutController _controller = new CheckOutController();

        private int _selectedReservationId = 0;
        private int _selectedRoomId = 0;
        private string _selectedGuestName = string.Empty;
        private string _selectedRoomNumber = string.Empty;
        private decimal _selectedTotalAmount = 0m;
        private decimal _selectedPaidAmount = 0m;
        private decimal _selectedBalanceDue = 0m;
        private decimal _lastChangeDue = 0m;
        private decimal _lastAmountTendered = 0m;
        private DateTime? _selectedArrivalDate = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentEmployeeID { get; set; } = 1;

        public CheckOutUserControl()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load += CheckOutUserControl_Load;

            btnSearchActive.Click += btnSearchActive_Click;
            btnSearchActiveIcon.Click += btnSearchActive_Click;
            btnClearActive.Click += btnClearActive_Click;
            txtSearchActive.KeyDown += txtSearchActive_KeyDown;

            dgvActiveStays.CellClick += dgvActiveStays_CellClick;
            txtFinVerif.TextChanged += txtFinVerif_TextChanged;

            btnFinalizeCheckout.Click += btnFinalizeCheckout_Click;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            btnGenerateReceipt.Click += btnGenerateReceipt_Click;
        }

        private void CheckOutUserControl_Load(object? sender, EventArgs e)
        {
            ResetInputs();
            LoadActiveStays(string.Empty);
        }

        private void LoadActiveStays(string searchTerm)
        {
            try
            {
                DataTable dt = _controller.SearchActiveStays(searchTerm);
                dgvActiveStays.DataSource = dt;

                string[] hiddenCols = { "ReservationID", "RoomID", "TotalAmount", "PaidAmount", "BalanceDue" };
                foreach (string col in hiddenCols)
                {
                    if (dgvActiveStays.Columns.Contains(col))
                        dgvActiveStays.Columns[col].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load active stays: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchActive_Click(object? sender, EventArgs e)
        {
            LoadActiveStays(txtSearchActive.Text.Trim());
        }

        private void txtSearchActive_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadActiveStays(txtSearchActive.Text.Trim());
            }
        }

        private void btnClearActive_Click(object? sender, EventArgs e)
        {
            txtSearchActive.Clear();
            ResetInputs();
            LoadActiveStays(string.Empty);
        }

        private void ResetInputs()
        {
            _selectedReservationId = 0;
            _selectedRoomId = 0;
            _selectedGuestName = string.Empty;
            _selectedRoomNumber = string.Empty;
            _selectedTotalAmount = 0m;
            _selectedPaidAmount = 0m;
            _selectedBalanceDue = 0m;
            _lastChangeDue = 0m;
            _lastAmountTendered = 0m;
            _selectedArrivalDate = null;

            dgvActiveStays.ClearSelection();
            dtpTimeSelection.Value = DateTime.Now;
            dtpActualOut.Value = DateTime.Now;
            txtFinVerif.Text = "0.00";
            txtChangeDue.Text = "0.00";
            txtRemarks.Clear();
        }

        private void dgvActiveStays_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvActiveStays.Rows[e.RowIndex];
            _selectedReservationId = row.Cells["ReservationID"].Value != DBNull.Value
                ? Convert.ToInt32(row.Cells["ReservationID"].Value) : 0;
            _selectedRoomId = row.Cells["RoomID"].Value != DBNull.Value
                ? Convert.ToInt32(row.Cells["RoomID"].Value) : 0;

            _selectedGuestName = row.Cells["Guest Name"].Value?.ToString() ?? string.Empty;
            _selectedRoomNumber = row.Cells["Room No"].Value?.ToString() ?? string.Empty;
            _selectedArrivalDate = row.Cells["Arrival"].Value != DBNull.Value
                ? Convert.ToDateTime(row.Cells["Arrival"].Value) : (DateTime?)null;

            _selectedTotalAmount = row.Cells["TotalAmount"].Value != DBNull.Value
                ? Convert.ToDecimal(row.Cells["TotalAmount"].Value) : 0m;
            _selectedPaidAmount = row.Cells["PaidAmount"].Value != DBNull.Value
                ? Convert.ToDecimal(row.Cells["PaidAmount"].Value) : 0m;
            _selectedBalanceDue = row.Cells["BalanceDue"].Value != DBNull.Value
                ? Convert.ToDecimal(row.Cells["BalanceDue"].Value) : 0m;

            dtpTimeSelection.Value = DateTime.Now;
            dtpActualOut.Value = DateTime.Now;
            txtFinVerif.Text = _selectedBalanceDue.ToString("0.00");
            RecalculateChangeDue();
        }

        private void txtFinVerif_TextChanged(object? sender, EventArgs e)
        {
            RecalculateChangeDue();
        }

        private void RecalculateChangeDue()
        {
            decimal.TryParse(txtFinVerif.Text, out decimal amountTendered);
            decimal change = _controller.CalculateChangeDue(_selectedBalanceDue, amountTendered);
            txtChangeDue.Text = change.ToString("0.00");
        }

        private void btnFinalizeCheckout_Click(object? sender, EventArgs e)
        {
            if (_selectedReservationId <= 0)
            {
                MessageBox.Show("Please select an active stay from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFinVerif.Text, out decimal amountTendered) || amountTendered < 0m)
            {
                MessageBox.Show("Enter a valid amount for financial verification.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Finalize check-out for this stay?", "Confirm Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                decimal changeDue = _controller.CalculateChangeDue(_selectedBalanceDue, amountTendered);

                bool success = _controller.ProcessCheckOut(
                    _selectedReservationId,
                    _selectedRoomId,
                    CurrentEmployeeID,
                    dtpActualOut.Value,
                    _selectedBalanceDue,
                    amountTendered,
                    txtRemarks.Text.Trim());

                if (success)
                {
                    _lastAmountTendered = amountTendered;
                    _lastChangeDue = changeDue;
                    txtChangeDue.Text = changeDue.ToString("0.00");

                    MessageBox.Show("Check-out finalized successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadActiveStays(txtSearchActive.Text.Trim());
                    ResetInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check-Out Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrintInvoice_Click(object? sender, EventArgs e)
        {
            if (_selectedReservationId <= 0)
            {
                MessageBox.Show("Select a stay first to print the final invoice.", "Nothing to Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowPrintDocument("FINAL INVOICE");
        }

        private void btnGenerateReceipt_Click(object? sender, EventArgs e)
        {
            if (_selectedReservationId <= 0 && _lastAmountTendered <= 0m)
            {
                MessageBox.Show("Select a stay or finalize a check-out first to generate a receipt.", "Nothing to Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowPrintDocument("CHECK-OUT RECEIPT");
        }

        private void ShowPrintDocument(string documentTitle)
        {
            decimal.TryParse(txtFinVerif.Text, out decimal currentAmount);
            decimal tendered = _lastAmountTendered > 0m ? _lastAmountTendered : currentAmount;
            decimal change = _lastChangeDue > 0m ? _lastChangeDue : _controller.CalculateChangeDue(_selectedBalanceDue, tendered);

            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = $"{documentTitle.Replace(' ', '_')}_{_selectedReservationId}";

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

                ev.Graphics.DrawString($"HOTEL RESERVATION - {documentTitle}", titleFont, Brushes.Black, x, y);
                y += 35;
                ev.Graphics.DrawString($"Generated: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", bodyFont, Brushes.DimGray, x, y);
                y += 25;
                ev.Graphics.DrawLine(linePen, x, y, 750, y);
                y += 20;

                void DrawRow(string label, string value)
                {
                    ev.Graphics.DrawString(label, headerFont, Brushes.Black, x, y);
                    ev.Graphics.DrawString(value, bodyFont, Brushes.Black, x + 210, y);
                    y += lineHeight;
                }

                DrawRow("Reservation ID:", _selectedReservationId.ToString());
                DrawRow("Guest Name:", _selectedGuestName);
                DrawRow("Room Number:", _selectedRoomNumber);
                DrawRow("Arrival Date:", _selectedArrivalDate?.ToString("MMMM dd, yyyy") ?? "-");
                DrawRow("Check-Out Time:", dtpActualOut.Value.ToString("MMMM dd, yyyy hh:mm tt"));
                DrawRow("Remarks:", string.IsNullOrWhiteSpace(txtRemarks.Text) ? "None" : txtRemarks.Text.Trim());

                y += 10;
                ev.Graphics.DrawLine(linePen, x, y, 750, y);
                y += 20;

                DrawRow("Total Stay Amount:", _selectedTotalAmount.ToString("0.00"));
                DrawRow("Previous Paid:", _selectedPaidAmount.ToString("0.00"));
                DrawRow("Balance Due:", _selectedBalanceDue.ToString("0.00"));
                DrawRow("Amount Tendered:", tendered.ToString("0.00"));
                DrawRow("Change Due:", change.ToString("0.00"));
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
    }
}