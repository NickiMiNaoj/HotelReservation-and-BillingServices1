using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class EmployeeRepository
    {
        // Returns the employee when the login is valid, or null when it is not
        public Employee Login(string username, string password, string role)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Employee_Login", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Employee
                        {
                            EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                            FullName = reader["FullName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
                            AccountStatus = "Active"
                        };
                    }
                }
            }
            return null;
        }

        // Inserts a new employee and returns the new auto-generated EmployeeID
        public int Insert(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Employee_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FullName", employee.FullName);
                cmd.Parameters.AddWithValue("@Username", employee.Username);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                cmd.Parameters.AddWithValue("@Role", employee.Role);
                cmd.Parameters.AddWithValue("@AccountStatus", employee.AccountStatus);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Updates an employee. An empty Password keeps the current password.
        public void Update(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Employee_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@FullName", employee.FullName);
                cmd.Parameters.AddWithValue("@Username", employee.Username);
                cmd.Parameters.AddWithValue("@Role", employee.Role);
                cmd.Parameters.AddWithValue("@AccountStatus", employee.AccountStatus);

                if (string.IsNullOrWhiteSpace(employee.Password))
                    cmd.Parameters.AddWithValue("@Password", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Password", employee.Password);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deactivate(int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Employee_Deactivate", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Fills the Employee List grid (passwords are not returned)
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Employee_GetAll", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                            FullName = reader["FullName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
                            AccountStatus = reader["AccountStatus"].ToString()
                        });
                    }
                }
            }
            return employees;
        }
    }
}