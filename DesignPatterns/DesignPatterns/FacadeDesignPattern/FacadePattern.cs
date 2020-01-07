// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacadePattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;

    /// <summary>
    /// Facade pattern 
    /// </summary>
    public class FacadePattern
    {
        /// <summary>
        /// Facades the pattern object.
        /// </summary>
        public static void FacadePatternObj()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Addressbook;Integrated Security =true;");
            SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Addressbook ", sqlCon);

            DataTable d = new DataTable();
            sqldata.Fill(d);

            foreach (DataRow row in d.Rows)
            {
                Console.WriteLine("first name= " + row["firstname"]);
                Console.WriteLine("first last= " + row["lastname"]);
                Console.WriteLine("address= " + row["address"]);
                Console.WriteLine("first city= " + row["city"]);
                Console.WriteLine("state= " + row["state"]);
                Console.WriteLine("zip= " + row["zip"]);
                Console.WriteLine("phone= " + row["phone"]);
                Console.WriteLine();
            }
        }
    }
}