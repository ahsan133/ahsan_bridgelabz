// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISubject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ObserverDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ISubject interface
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        void Register(IObserver obj);

        /// <summary>
        /// Unregisters the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        void Unregister(IObserver obj);

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }
}
