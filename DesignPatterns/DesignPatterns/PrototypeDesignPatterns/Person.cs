// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Person info. class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The age
        /// </summary>
        private int age;

        /// <summary>
        /// The phone
        /// </summary>
        private long phone;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age { get => this.age; set => this.age = value; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public long Phone { get => this.phone; set => this.phone = value; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>
        /// Returns the copied person info.
        /// </returns>
        public Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}
