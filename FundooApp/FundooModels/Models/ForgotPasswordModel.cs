// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForgotPasswordModel.cs" company="Bridgelabz">
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
    /// Forgot password model class.
    /// </summary>
    public class ForgotPasswordModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Key]
        public string Email { get => this.email; set => this.email = value; }
    }
}
