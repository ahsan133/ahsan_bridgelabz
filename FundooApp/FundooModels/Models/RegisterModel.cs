// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// Register model class.
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// The profilePicture
        /// </summary>
        private string profilePicture;

        /// <summary>
        /// The status
        /// </summary>
        private bool status;

        /// <summary>
        /// The cardType
        /// </summary>
        private string cardType;

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get => this.firstName; set => this.firstName = value; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get => this.lastName; set => this.lastName = value; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Key]
        public string Email { get => this.email; set => this.email = value; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get => this.password; set => this.password = value; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="RegisterModel"/> is status.
        /// </summary>
        /// <value>
        ///   <c>true</c> if status; otherwise, <c>false</c>.
        /// </value>
        public bool Status { get => this.status; set => this.status = value; }

        /// <summary>
        /// Gets or sets the profilePicture.
        /// </summary>
        /// <value>
        /// The profilePicture.
        /// </value>
        public string ProfilePicture { get => this.profilePicture; set => this.profilePicture = value; }

        /// <summary>
        /// Gets or sets the CardType.
        /// </summary>
        /// <value>
        /// The CardType.
        /// </value>
        public string CardType { get => this.cardType; set => this.cardType = value; }
    }
}
