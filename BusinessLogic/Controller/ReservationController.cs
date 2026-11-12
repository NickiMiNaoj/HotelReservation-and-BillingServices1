using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class ReservationController
    {
        private readonly ReservationRepository _repository = new ReservationRepository();

        // Statuses the Room Reservation form can set (CheckedIn / CheckedOut come from the Check-in/out form)
        private static readonly string[] ValidStatuses = { "Pending", "Confirmed", "Cancelled" };

        public bool AddReservation(Reservation reservation, out string message)
        {
            string error = Validate(reservation);
            if (error == null && reservation.CheckInDate.Date < DateTime.Today)
                error = "Check-in date cannot be in the past.";

            if (error != null)
            {
                message = error;
                return false;
            }

            try
            {
                reservation.ReservationID = _repository.Insert(reservation);
                message = "Reservation saved.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;   // e.g. "The room is already booked for the selected dates."
                return false;
            }
        }

        public bool UpdateReservation(Reservation reservation, out string message)
        {
            if (reservation.ReservationID <= 0)
            {
                message = "Select a reservation to update.";
                return false;
            }

            string error = Validate(reservation);
            if (error != null)
            {
                message = error;
                return false;
            }

            try
            {
                _repository.Update(reservation);
                message = "Reservation updated.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        // Soft delete: works the same for Admin and Front Desk,
        // but only the Admin can ever see the deleted reservation again.
        public bool DeleteReservation(int reservationId, int employeeId, out string message)
        {
            if (reservationId <= 0)
            {
                message = "Select a reservation to delete.";
                return false;
            }

            try
            {
                _repository.SoftDelete(reservationId, employeeId);
                message = "Reservation deleted.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool RestoreReservation(int reservationId, int employeeId, out string message)
        {
            if (reservationId <= 0)
            {
                message = "Select a deleted reservation to restore.";
                return false;
            }

            try
            {
                _repository.Restore(reservationId, employeeId);
                message = "Reservation restored.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;   // e.g. "Only an Admin can restore reservations."
                return false;
            }
        }

        // The normal list. Front Desk never receives deleted reservations; Admin receives all of them.
        public List<Reservation> GetAllReservations(int employeeId, string keyword = null)
        {
            return _repository.GetAll(employeeId, keyword, false);
        }

        // The "deleted" list for the Admin (returns nothing for anyone else)
        public List<Reservation> GetDeletedReservations(int employeeId, string keyword = null)
        {
            return _repository.GetAll(employeeId, keyword, true);
        }

        // Returns an error message, or null when everything is valid
        private string Validate(Reservation r)
        {
            if (r.GuestID <= 0)
                return "Please select a guest.";
            if (r.RoomID <= 0)
                return "Please select a room.";
            if (r.CheckOutDate.Date <= r.CheckInDate.Date)
                return "Check-out date must be after the check-in date.";
            if (r.NumAdults < 1)
                return "There must be at least one adult.";
            if (r.NumChildren < 0)
                return "Number of children cannot be negative.";
            if (r.AdditionalCharges < 0 || r.Discount < 0)
                return "Additional charges and discount cannot be negative.";
            if (Array.IndexOf(ValidStatuses, r.Status) < 0)
                return "Please select a valid reservation status.";

            return null;
        }
    }
}