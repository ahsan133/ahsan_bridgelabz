// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Socket.cs" company="Bridgelabz">
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
    /// Socket class
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Values this instance.
        /// </summary>
        /// <returns>
        /// Returns the value
        /// </returns>
        public Volt Value()
        {
            return new Volt(120);
        }
    }
}
