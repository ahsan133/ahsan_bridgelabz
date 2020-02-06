// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdminUserList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModels.AdminModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Admin user List class.
    /// </summary>
    public class AdminUserList
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;

        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The login time
        /// </summary>
        private DateTime loginTime;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get => this.email; set => this.email = value; }

        /// <summary>
        /// Gets or sets the login time.
        /// </summary>
        /// <value>
        /// The login time.
        /// </value>
        public DateTime LoginTime { get => this.loginTime; set => this.loginTime = value; }
    }
}
