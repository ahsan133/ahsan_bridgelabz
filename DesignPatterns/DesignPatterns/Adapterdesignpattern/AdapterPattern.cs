// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdapterPattern.cs" company="Bridgelabz">
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
    /// Adapter pattern class
    /// </summary>
    public class AdapterPattern
    {
        /// <summary>
        /// Adapters the pattern object.
        /// </summary>
        public static void AdapterPatternObj()
        {
            SocketObjectAdapter();
            SocketClassAdapter();
        }

        /// <summary>
        /// Sockets the object adapter.
        /// </summary>
        public static void SocketObjectAdapter()
        {
            ISocketAdapter socketObject = new SocketObjectAdapterImpl();
            Volt v120 = GetSocket(socketObject, 120);
            Volt v12 = GetSocket(socketObject, 12);
            Volt v3 = GetSocket(socketObject, 3);
            Console.WriteLine(v120.Volts);
            Console.WriteLine(v12.Volts);
            Console.WriteLine(v3.Volts);
        }

        /// <summary>
        /// Sockets the class adapter.
        /// </summary>
        public static void SocketClassAdapter()
        {
            ISocketAdapter socketClass = new SocketClassAdapterImpl();
            Volt v120 = GetSocket(socketClass, 120);
            Volt v12 = GetSocket(socketClass, 12);
            Volt v3 = GetSocket(socketClass, 3);

            Console.WriteLine(v120.Volts);
            Console.WriteLine(v12.Volts);
            Console.WriteLine(v3.Volts);
        }

        /// <summary>
        /// Gets the socket.
        /// </summary>
        /// <param name="sock">The sock.</param>
        /// <param name="i">The i.</param>
        /// <returns>
        /// Returns the value for particular case
        /// </returns>
        public static Volt GetSocket(ISocketAdapter sock, int i)
        {
            switch (i)
            {
                case 3:
                    return sock.Get3Volt();
                case 12:
                    return sock.Get12Volt();
                case 120:
                    return sock.Get120Volt();
                default:
                    return sock.Get120Volt();
            }
        }
    }
}
