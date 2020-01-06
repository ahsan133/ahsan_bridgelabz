// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
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
    /// computer factory class
    /// </summary>
    public class ComputerFactory
    {
        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="rom">The rom.</param>
        /// <param name="ram">The ram.</param>
        /// <returns>
        /// Returns the ram and rom value
        /// </returns>
        public static Computer GetString(string type, string rom, string ram)
        {
            if ("server".Equals(type))
            {
                return new Server(rom, ram);
            }
            else if ("pc".Equals(type))
            {
                return new Pc(rom, ram);
            }

            return null;
        }
    }
}
