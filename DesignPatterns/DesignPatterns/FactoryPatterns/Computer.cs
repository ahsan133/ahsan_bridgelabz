// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// computer class
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Rom this instance.
        /// </summary>
        /// <returns>
        /// Returns rom value
        /// </returns>
        public abstract string Rom();

        /// <summary>
        /// Rams this instance.
        /// </summary>
        /// <returns>
        /// Returns ram value
        /// </returns>
        public abstract string Ram();

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Rom=" + this.Rom() + ", Ram=" + this.Ram();
        }
    }
}
