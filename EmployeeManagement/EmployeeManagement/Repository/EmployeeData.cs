// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.Repository;
    using EmployeeManagement.Utility;    
   
    /// <summary>
    /// EmployeeData implements IRepository.
    /// </summary>
    /// <seealso cref="EmployeeManagement.Repository.IRepository" />
    public class EmployeeData : IRepository
    {
        /// <summary>
        /// The connection
        /// </summary>
        private string connection = ConnectionString.ConnectionName;

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>
        /// Returns a list of all employees.
        /// </returns>
        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            using (SqlConnection connect = new SqlConnection(this.connection))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                connect.Open();
                SqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Employee employee = new Employee();
                    employee.UserId = Convert.ToInt32(data["userId"]);
                    employee.Name = data["name"].ToString();
                    employee.Email = data["email"].ToString();
                    employee.Password = data["password"].ToString();
                    employee.Address = data["address"].ToString();

                    list.Add(employee);
                }

                connect.Close();
            }

            return list;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection connect = new SqlConnection(this.connection))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@userId", employee.UserId);
                cmd.Parameters.AddWithValue("@name", employee.Name);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@password", employee.Password);
                cmd.Parameters.AddWithValue("@address", employee.Address);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection connect = new SqlConnection(this.connection))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@userId", employee.UserId);
                cmd.Parameters.AddWithValue("@name", employee.Name);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@password", employee.Password);
                cmd.Parameters.AddWithValue("@address", employee.Address);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        public void DeleteEmployee(int? userId)
        {
            using (SqlConnection connect = new SqlConnection(this.connection))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@userId", userId);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if email and password exist else false.
        /// </returns>
        public bool LoginEmployee(string email, string password)
        {
            using (SqlConnection connect = new SqlConnection(this.connection))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                connect.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    if (Equals(data["password"].ToString(), password))
                    {
                        if (Equals(data["email"].ToString(), email))
                        {
                            return true;
                        }
                    }
                }

                connect.Close();
                return false;
            }
        }
    }
}