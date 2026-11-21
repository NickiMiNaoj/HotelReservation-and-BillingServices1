using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
    public partial class DashboardForm : Form
    {
        private readonly DashboardController _controller = new DashboardController();
        private readonly System.Windows.Forms.Timer _clockTimer = new System.Windows.Forms.Timer();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CurrentUserRole { get; set; } = "Admin";

        public DashboardForm()
        {
            InitializeComponent();
            ConfigureRecentReservationsGrid();
            WireEvents();
        }

        private void ConfigureRecentReservationsGrid()
        {
            dgvRecentReservations.AutoGenerateColumns = false;

            colReservationID.DataPropertyName = "Reservation ID";
            colGuestName.DataPropertyName = "Guest Name";
            colRoomNumber.DataPropertyName = "Room";
            colCheckIn.DataPropertyName = "Check-In";
            colCheckOut.DataPropertyName = "Check-Out";
            colStatus.DataPropertyName = "Status";
        }

        private void WireEvents()
        {
            this.Load += DashboardForm_Load;
            this.Activated += DashboardForm_Activated;

            _clockTimer.Interval = 1000;
            _clockTimer.Tick += ClockTimer_Tick;
        }

        private void DashboardForm_Load(object? sender, EventArgs e)
        {
            UpdateDateTimeLabel();
            _clockTimer.Start();
            RefreshDashboard();
        }

        private void DashboardForm_Activated(object? sender, EventArgs e)
        {
            UpdateDateTimeLabel();
            RefreshDashboard();
        }

        private void ClockTimer_Tick(object? sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void UpdateDateTimeLabel()
        {
            lblWelcome.Text = $"Welcome, {CurrentUserRole}";
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy  hh:mm tt");
        }

        public void RefreshDashboard()
        {
            try
            {
                DataTable summary = _controller.LoadSummary();
                if (summary.Rows.Count > 0)
                {
                    DataRow row = summary.Rows[0];

                    int totalRooms = row["TotalRooms"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalRooms"]);
                    int availableRooms = row["AvailableRooms"] == DBNull.Value ? 0 : Convert.ToInt32(row["AvailableRooms"]);
                    int occupiedRooms = row["OccupiedRooms"] == DBNull.Value ? 0 : Convert.ToInt32(row["OccupiedRooms"]);
                    int reservedRooms = row["ReservedRooms"] == DBNull.Value ? 0 : Convert.ToInt32(row["ReservedRooms"]);
                    int todayCheckIns = row["TodayCheckIns"] == DBNull.Value ? 0 : Convert.ToInt32(row["TodayCheckIns"]);
                    int todayCheckOuts = row["TodayCheckOuts"] == DBNull.Value ? 0 : Convert.ToInt32(row["TodayCheckOuts"]);
                    int totalGuests = row["TotalGuests"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalGuests"]);
                    decimal revenueToday = row["RevenueToday"] == DBNull.Value ? 0m : Convert.ToDecimal(row["RevenueToday"]);

                    decimal occupancyRate = _controller.CalculateOccupancyRate(totalRooms, occupiedRooms);

                    lblTotalRooms.Text = totalRooms.ToString();
                    lblAvailableRooms.Text = availableRooms.ToString();
                    lblOccupiedRooms.Text = occupiedRooms.ToString();
                    lblReservedRooms.Text = reservedRooms.ToString();
                    lblOccupancyRate.Text = $"{occupancyRate:0.#}%";
                    lblTodayCheckIns.Text = todayCheckIns.ToString();
                    lblTodayCheckOuts.Text = todayCheckOuts.ToString();
                    lblTotalGuests.Text = totalGuests.ToString();
                    lblRevenueToday.Text = $"₱{revenueToday:N2}";
                }

                DataTable recent = _controller.LoadRecentReservations(20);
                dgvRecentReservations.DataSource = recent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}