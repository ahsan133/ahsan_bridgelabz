// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISocketAdapter.cs" company="Bridgelabz">
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
    /// Socket adapter class
    /// </summary>
    public interface ISocketAdapter
    {
        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>
        /// Returns the 120volt value
        /// </returns>
        Volt Get120Volt();

        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>
        /// Returns the 12volt value
        /// </returns>
        Volt Get12Volt();

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>
        /// Returns the 3volt value
        /// </returns>
        Volt Get3Volt();
    }
}