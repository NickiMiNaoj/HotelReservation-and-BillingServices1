using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class CheckOutRepository
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        // SEARCH ACTIVE STAYS
        public DataTable GetActiveStays(string searchTerm)
        {
            const string sql = @"
                SELECT
                    r.ReservationID,
                    r.RoomID,
                    ISNULL(g.FirstName + ' ' + g.LastName, '') AS [Guest Name],
                    ISNULL(rm.RoomNumber, '') AS [Room No],
                    r.CheckInDate AS Arrival,
                    r.CheckOutDate AS Departure,
                    r.Status,
                    ISNULL(inv.TotalAmountDue, ISNULL(r.TotalAmount, 0)) AS TotalAmount,
                    ISNULL((
                        SELECT SUM(p.AmountApplied)
                        FROM dbo.tblPayments p
                        INNER JOIN dbo.tblInvoices i ON p.InvoiceID = i.InvoiceID
                        WHERE i.ReservationID = r.ReservationID
                    ), 0) AS PaidAmount
                FROM dbo.tblReservations r
                LEFT JOIN dbo.tblGuests g ON r.GuestID = g.GuestID
                LEFT JOIN dbo.tblRooms rm ON r.RoomID = rm.RoomID
                LEFT JOIN dbo.tblInvoices inv ON inv.ReservationID = r.ReservationID
                WHERE (r.IsDeleted = 0 OR r.IsDeleted IS NULL)
                  AND r.Status IN ('Checked-In', 'Active', 'Occupied', 'Cleared', 'Confirmed')
                  AND (
                        @SearchTerm IS NULL
                        OR @SearchTerm = ''
                        OR CAST(r.ReservationID AS NVARCHAR(20)) LIKE '%' + @SearchTerm + '%'
                        OR (g.FirstName + ' ' + g.LastName) LIKE '%' + @SearchTerm + '%'
                        OR rm.RoomNumber LIKE '%' + @SearchTerm + '%'
                        OR r.Status LIKE '%' + @SearchTerm + '%'
                      )
                ORDER BY r.ReservationID DESC;";

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@SearchTerm", SqlDbType.NVarChar, 100).Value =
                string.IsNullOrWhiteSpace(searchTerm) ? DBNull.Value : searchTerm.Trim();

            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (!dt.Columns.Contains("BalanceDue"))
                dt.Columns.Add("BalanceDue", typeof(decimal));

            foreach (DataRow row in dt.Rows)
            {
                decimal total = row["TotalAmount"] == DBNull.Value ? 0m : Convert.ToDecimal(row["TotalAmount"]);
                decimal paid = row["PaidAmount"] == DBNull.Value ? 0m : Convert.ToDecimal(row["PaidAmount"]);
                decimal balance = total - paid;
                row["BalanceDue"] = balance > 0m ? balance : 0m;
            }

            return dt;
        }

        // EXECUTE CHECK-OUT
        public void ExecuteCheckOut(
            int reservationId,
            int roomId,
            int employeeId,
            DateTime actualCheckOutTime,
            decimal balanceDue,
            decimal amountTendered,
            string remarks)
        {
            const string updateReservationSql = @"
                UPDATE dbo.tblReservations
                SET
                    Status = 'Checked-Out',
                    ActualCheckOut = @ActualCheckOut,
                    Remarks = CASE
                        WHEN @Remarks = '' THEN Remarks
                        WHEN Remarks IS NULL OR Remarks = '' THEN @Remarks
                        ELSE Remarks + ' | ' + @Remarks
                    END
                WHERE ReservationID = @ReservationID;";

            const string updateRoomSql = @"
                UPDATE dbo.tblRooms
                SET Status = 'Available'
                WHERE RoomID = @RoomID;";

            const string getInvoiceSql = @"
                SELECT TOP 1 InvoiceID
                FROM dbo.tblInvoices
                WHERE ReservationID = @ReservationID;";

            const string insertPaymentSql = @"
                INSERT INTO dbo.tblPayments
                    (InvoiceID, PaymentMethod, AmountTendered, AmountApplied, PaidAt, ProcessedBy)
                VALUES
                    (@InvoiceID, @PaymentMethod, @AmountTendered, @AmountApplied, @PaidAt, @ProcessedBy);";

            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();

            try
            {
                using (var cmdRes = new SqlCommand(updateReservationSql, conn, tx))
                {
                    cmdRes.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                    cmdRes.Parameters.Add("@ActualCheckOut", SqlDbType.DateTime).Value = actualCheckOutTime;
                    cmdRes.Parameters.Add("@Remarks", SqlDbType.NVarChar, 250).Value = remarks ?? string.Empty;
                    cmdRes.ExecuteNonQuery();
                }

                if (roomId > 0)
                {
                    using var cmdRoom = new SqlCommand(updateRoomSql, conn, tx);
                    cmdRoom.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomId;
                    cmdRoom.ExecuteNonQuery();
                }

                decimal settled = balanceDue > 0m ? Math.Min(balanceDue, amountTendered) : 0m;
                if (settled > 0m)
                {
                    int invoiceId = 0;
                    using (var cmdInv = new SqlCommand(getInvoiceSql, conn, tx))
                    {
                        cmdInv.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                        object? result = cmdInv.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            invoiceId = Convert.ToInt32(result);
                    }

                    if (invoiceId > 0)
                    {
                        using var cmdPay = new SqlCommand(insertPaymentSql, conn, tx);
                        cmdPay.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = invoiceId;
                        cmdPay.Parameters.Add("@PaymentMethod", SqlDbType.NVarChar, 20).Value = "Cash";
                        cmdPay.Parameters.Add("@AmountTendered", SqlDbType.Decimal).Value = amountTendered;
                        cmdPay.Parameters.Add("@AmountApplied", SqlDbType.Decimal).Value = settled;
                        cmdPay.Parameters.Add("@PaidAt", SqlDbType.DateTime2).Value = actualCheckOutTime;
                        cmdPay.Parameters.Add("@ProcessedBy", SqlDbType.Int).Value = employeeId > 0 ? employeeId : 1;
                        cmdPay.ExecuteNonQuery();
                    }
                }

                tx.Commit();
            }
            catch
            {
                try { tx.Rollback(); } catch { }
                throw;
            }
        }
    }
}