// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Server.cs" company="Bridgelabz">
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
    /// class server extends class computer
    /// </summary>
    /// <seealso cref="DesignPatterns.FactoryPatterns.Computer" />
    public class Server : Computer
    {
        /// <summary>
        /// The rom
        /// </summary>
        private string rom;

        /// <summary>
        /// The ram
        /// </summary>
        private string ram;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="rom">The rom.</param>
        /// <param name="ram">The ram.</param>
        public Server(string rom, string ram)
        {
            this.rom = rom;
            this.ram = ram;
        }

        /// <summary>
        /// Rom this instance.
        /// </summary>
        /// <returns>
        /// Returns rom value
        /// </returns>
        public override string Rom()
        { 
            return this.rom;
        }

        /// <summary>
        /// Ram this instance.
        /// </summary>
        /// <returns>
        /// Returns ram value
        /// </returns>
        public override string Ram()
        {
            return this.ram;
        }      
    }
}
