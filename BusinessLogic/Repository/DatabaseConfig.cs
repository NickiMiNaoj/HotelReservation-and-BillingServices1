using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repository
{
    internal class DatabaseConfig
    {
        public static string ConnectionString = @"Server=.\SQLEXPRESS09;Database=HotelReservationDB;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
