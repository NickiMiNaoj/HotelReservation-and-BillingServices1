using System;
using System.Data;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class DashboardController
    {
        private readonly DashboardRepository repository;

        public DashboardController()
        {
            repository = new DashboardRepository();
        }

        public DataTable LoadSummary()
        {
            try
            {
                return repository.GetDashboardSummary();
            }
            catch (Exception ex)
            {
                throw new Exception("Dashboard summary failed: " + ex.Message);
            }
        }

        public DataTable LoadRecentReservations(int topCount = 20)
        {
            try
            {
                return repository.GetRecentReservations(topCount);
            }
            catch (Exception ex)
            {
                throw new Exception("Recent reservations failed: " + ex.Message);
            }
        }

        public decimal CalculateOccupancyRate(int totalRooms, int occupiedRooms)
        {
            if (totalRooms <= 0) return 0m;
            decimal rate = ((decimal)occupiedRooms / totalRooms) * 100m;
            return Math.Round(rate, 1);
        }
    }
}