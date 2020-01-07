// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketObjectAdapterImpl.cs" company="Bridgelabz">
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
    /// Socket object adapter class
    /// </summary>
    /// <seealso cref="DesignPatterns.Adapterdesignpattern.ISocketAdapter" />
    public class SocketObjectAdapterImpl : ISocketAdapter
    {
        /// <summary>
        /// The sock
        /// </summary>
        private Socket sock = new Socket();

        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>
        /// Returns the sock value
        /// </returns>
        public Volt Get120Volt()
        {
            return this.sock.Value();
        }

        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>
        ///  Returns the sock value
        /// </returns>
        public Volt Get12Volt()
        {
            Volt v = this.sock.Value();
            return this.ConvertVolt(v, 10);
        }

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>
        ///  Returns the sock value
        /// </returns>
        public Volt Get3Volt()
        {
            Volt v = this.sock.Value();
            return this.ConvertVolt(v, 40);
        }

        /// <summary>
        /// Converts the volt.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <param name="i">The i.</param>
        /// <returns>
        /// Returns the converted sock value
        /// </returns>
        public Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.Volts / i);
        }
    }
}
