// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Share.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Company_Shares
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Share class
    /// </summary>
    public class Share
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The shares
        /// </summary>
        private int shares;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the shares.
        /// </summary>
        /// <value>
        /// The shares.
        /// </value>
        public int Shares { get => this.shares; set => this.shares = value; }
    }
}
