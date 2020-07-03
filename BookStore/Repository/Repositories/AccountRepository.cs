using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Repository.IRepository;

namespace Repository.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public string Register(RegisterModel data)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("dbo.spAddAccount", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                cmd.Parameters.AddWithValue("@LastName", data.LastName);
                cmd.Parameters.AddWithValue("@Email", data.Email);
                cmd.Parameters.AddWithValue("@Password", data.Password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return "success";
            }
        }

        public bool Login(LoginModel data)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("dbo.spLogin", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Email", data.Email);
                cmd.Parameters.AddWithValue("@Password", data.Password);

                con.Open();
                var result = Convert.ToInt16(cmd.ExecuteNonQuery());
                con.Close();

                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
             
            }
        }
    }
} 
