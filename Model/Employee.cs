using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;           
        public string AccountStatus { get; set; } = "Active";      
    }
}
