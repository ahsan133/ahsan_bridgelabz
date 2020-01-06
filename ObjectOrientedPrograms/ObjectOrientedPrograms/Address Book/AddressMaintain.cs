// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressMaintain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Address_Book
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Address maintain class
    /// </summary>
    public class AddressMaintain
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstname;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastname;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// The city
        /// </summary>
        private string city;

        /// <summary>
        /// The state
        /// </summary>
        private string state;

        /// <summary>
        /// The zip
        /// </summary>
        private int zip;

        /// <summary>
        /// The phone/
        /// </summary>
        private long phone;

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get => this.firstname; set => this.firstname = value; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get => this.lastname; set => this.lastname = value; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get => this.address; set => this.address = value; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get => this.city; set => this.city = value; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get => this.state; set => this.state = value; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public int Zip { get => this.zip; set => this.zip = value; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public long Phone { get => this.phone; set => this.phone = value; }
    }
}
