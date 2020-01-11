// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Member.cs" company="Bridgelabz">
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
    /// Member class
    /// </summary>
    public class Member
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The shares bought
        /// </summary>
        private int sharesBought;

        /// <summary>
        /// The symbol
        /// </summary>
        private string symbol;

        /// <summary>
        /// The datetime
        /// </summary>
        private DateTime datetime;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the shares bought.
        /// </summary>
        /// <value>
        /// The shares bought.
        /// </value>
        public int SharesBought { get => this.sharesBought; set => this.sharesBought = value; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get => this.symbol; set => this.symbol = value; }

        /// <summary>
        /// Gets or sets the datetime.
        /// </summary>
        /// <value>
        /// The datetime.
        /// </value>
        public DateTime Datetime { get => this.datetime; set => this.datetime = value; }
    }
}
