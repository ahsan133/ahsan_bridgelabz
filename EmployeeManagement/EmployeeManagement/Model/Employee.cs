// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Employee class.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        private int userId;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserId { get => this.userId; set => this.userId = value; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get => this.email; set => this.email = value; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get => this.password; set => this.password = value; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get => this.address; set => this.address = value; }
    }
}
