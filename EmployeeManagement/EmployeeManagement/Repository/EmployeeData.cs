using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    using EmployeeManagement.Repository;
    using EmployeeManagement.Utility;
    using System.Data;
    using System.Data.SqlClient;

    public class EmployeeData : IRepository
    {
        string connection = ConnectionString.ConnectionName;

        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            using(SqlConnection connect = new SqlConnection(connection))
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

        public void AddEmployee(Employee employee)
        {
            using (SqlConnection connect = new SqlConnection(connection))
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

        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection connect = new SqlConnection(connection))
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

        public void DeleteEmployee(int? userId)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@userId", userId);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        public bool LoginEmployee(string email, string password)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                connect.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while(data.Read())
                {
                    string a = data["password"].ToString();
                    if (Equals(data["password"].ToString(), password))
                    {
                        if(Equals(data["email"].ToString(), email))
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
