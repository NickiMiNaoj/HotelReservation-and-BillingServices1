using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;   // NuGet: Microsoft.Data.SqlClient
using Model;

namespace BusinessLogic.Repository
{
    public class BillingRepository
    {
        // Loads the Billing form for one reservation. Returns null when the reservation does not exist.
        public BillingSummary GetBillingSummary(int reservationId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Billing_GetByReservation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return new BillingSummary
                    {
                        ReservationID = Convert.ToInt32(reader["ReservationID"]),
                        GuestName = reader["GuestName"].ToString(),
                        RoomNumber = reader["RoomNumber"].ToString(),
                        RoomCharges = Convert.ToDecimal(reader["RoomCharges"]),
                        FoodBeverageCharges = Convert.ToDecimal(reader["FoodBeverageCharges"]),
                        OtherServiceCharges = Convert.ToDecimal(reader["OtherServiceCharges"]),
                        Discount = Convert.ToDecimal(reader["Discount"]),
                        TaxRate = Convert.ToDecimal(reader["TaxRate"]),
                        TaxAmount = Convert.ToDecimal(reader["TaxAmount"]),
                        TotalAmountDue = Convert.ToDecimal(reader["TotalAmountDue"]),
                        AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                        Balance = Convert.ToDecimal(reader["Balance"]),
                        PaymentStatus = reader["PaymentStatus"].ToString(),
                        InvoiceID = reader["InvoiceID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["InvoiceID"]),
                        InvoiceNumber = reader["InvoiceNumber"] == DBNull.Value ? string.Empty : reader["InvoiceNumber"].ToString()
                    };
                }
            }
        }

        // Creates/updates the invoice, saves the payment, and returns the refreshed summary
        // (with ChangeGiven filled in).
        public BillingSummary ProcessPayment(int reservationId, decimal foodBeverageCharges, decimal otherServiceCharges,
                                             decimal discount, string paymentMethod, decimal amountTendered, int employeeId)
        {
            decimal change;

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Billing_ProcessPayment", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.Parameters.AddWithValue("@FoodBeverageCharges", foodBeverageCharges);
                cmd.Parameters.AddWithValue("@OtherServiceCharges", otherServiceCharges);
                cmd.Parameters.AddWithValue("@Discount", discount);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@AmountTendered", amountTendered);
                cmd.Parameters.AddWithValue("@ProcessedBy", employeeId);

                conn.Open();
                change = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            BillingSummary summary = GetBillingSummary(reservationId);
            if (summary != null)
                summary.ChangeGiven = change;
            return summary;
        }

        // Payment History grid. reservationId = null shows every payment.
        public List<Payment> GetPaymentHistory(int employeeId, int? reservationId = null)
        {
            List<Payment> payments = new List<Payment>();

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Payment_GetHistory", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                if (reservationId.HasValue)
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId.Value);
                else
                    cmd.Parameters.AddWithValue("@ReservationID", DBNull.Value);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        payments.Add(new Payment
                        {
                            PaymentID = Convert.ToInt32(reader["PaymentID"]),
                            InvoiceNumber = reader["InvoiceNumber"].ToString(),
                            ReservationID = Convert.ToInt32(reader["ReservationID"]),
                            GuestName = reader["GuestName"].ToString(),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            PaymentMethod = reader["PaymentMethod"].ToString(),
                            AmountTendered = Convert.ToDecimal(reader["AmountTendered"]),
                            AmountApplied = Convert.ToDecimal(reader["AmountApplied"]),
                            ChangeGiven = Convert.ToDecimal(reader["ChangeGiven"]),
                            PaidAt = Convert.ToDateTime(reader["PaidAt"]),
                            ProcessedByName = reader["ProcessedByName"] == DBNull.Value ? string.Empty : reader["ProcessedByName"].ToString()
                        });
                    }
                }
            }
            return payments;
        }
    }
}