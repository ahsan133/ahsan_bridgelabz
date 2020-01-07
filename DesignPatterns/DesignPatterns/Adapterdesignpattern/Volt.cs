// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Volt.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Adapterdesignpattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Volt class
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// The volts
        /// </summary>
        private int volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
        public Volt(int v)
        {
            this.volts = v;
        }

        /// <summary>
        /// Gets or sets the volts.
        /// </summary>
        /// <value>
        /// The volts.
        /// </value>
        public int Volts { get => this.volts; set => this.volts = value; }
    }
}