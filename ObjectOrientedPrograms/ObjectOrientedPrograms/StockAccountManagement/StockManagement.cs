// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.StockAccountManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Managing stocks 
    /// </summary>
    public class StockManagement
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
        /// The share price
        /// </summary>
        private int sharePrice;

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

        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public int SharePrice { get => this.sharePrice; set => this.sharePrice = value; }
    }
}
