// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectionString.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Utility class.
    /// </summary>
    public static class ConnectionString
    {
        /// <summary>
        /// The connection name
        /// </summary>
        private static string connectionName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee;Integrated Security=True";

        /// <summary>
        /// Gets or sets the name of the connection.
        /// </summary>
        /// <value>
        /// The name of the connection.
        /// </value>
        public static string ConnectionName { get => connectionName; set => connectionName = value; }

        /// <summary>
        /// Randoms this instance.
        /// </summary>
        /// <returns>
        /// Returns a random integer value.
        /// </returns>
        public static int Random()
        {
            Random random = new Random();
            return random.Next(10000);
        }
    }
}