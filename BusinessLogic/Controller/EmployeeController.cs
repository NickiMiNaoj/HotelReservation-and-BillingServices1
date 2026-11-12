using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class EmployeeController
    {
        private readonly EmployeeRepository _repository = new EmployeeRepository();

        private static readonly string[] ValidRoles = { "Admin", "Front Desk" };
        private static readonly string[] ValidStatuses = { "Active", "Inactive" };

        // Returns the employee on success, or null with a message on failure
        public Employee Login(string username, string password, string role, out string message)
        {
            message = string.Empty;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                message = "Please enter your username and password.";
                return null;
            }
            if (string.IsNullOrWhiteSpace(role))
            {
                message = "Please select a role.";
                return null;
            }

            try
            {
                Employee employee = _repository.Login(username.Trim(), password, role);
                if (employee == null)
                    message = "Invalid username, password, or role.";
                return employee;
            }
            catch (SqlException ex)
            {
                message = "Database error: " + ex.Message;
                return null;
            }
        }

        public bool AddEmployee(Employee employee, out string message)
        {
            string error = Validate(employee, passwordRequired: true);
            if (error != null)
            {
                message = error;
                return false;
            }

            try
            {
                employee.EmployeeID = _repository.Insert(employee);
                message = "Employee saved.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;   // e.g. "Username already exists."
                return false;
            }
        }

        public bool UpdateEmployee(Employee employee, out string message)
        {
            if (employee.EmployeeID <= 0)
            {
                message = "Select an employee to update.";
                return false;
            }

            string error = Validate(employee, passwordRequired: false);
            if (error != null)
            {
                message = error;
                return false;
            }

            try
            {
                _repository.Update(employee);
                message = "Employee updated.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool DeactivateEmployee(int employeeId, out string message)
        {
            if (employeeId <= 0)
            {
                message = "Select an employee to deactivate.";
                return false;
            }

            try
            {
                _repository.Deactivate(employeeId);
                message = "Employee deactivated.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;   // e.g. "Cannot deactivate the last active Admin account."
                return false;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAll();
        }

        // Returns an error message, or null when everything is valid
        private string Validate(Employee employee, bool passwordRequired)
        {
            if (string.IsNullOrWhiteSpace(employee.FullName))
                return "Full name is required.";
            if (string.IsNullOrWhiteSpace(employee.Username))
                return "Username is required.";
            if (passwordRequired && string.IsNullOrWhiteSpace(employee.Password))
                return "Password is required.";
            if (Array.IndexOf(ValidRoles, employee.Role) < 0)
                return "Please select a valid role.";
            if (Array.IndexOf(ValidStatuses, employee.AccountStatus) < 0)
                return "Please select a valid account status.";

            return null;
        }
    }
}