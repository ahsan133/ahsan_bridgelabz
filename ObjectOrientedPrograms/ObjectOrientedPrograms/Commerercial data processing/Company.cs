// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Commerercial_data_processing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Company class
    /// </summary>
    public class Company
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
        /// The symbol
        /// </summary>
        private string symbol;

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

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get => this.symbol; set => this.symbol = value; }
    }
}
