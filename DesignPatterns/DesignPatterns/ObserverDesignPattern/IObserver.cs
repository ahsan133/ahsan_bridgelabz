// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IObserver.cs" company="Bridgelabz">
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
    /// IObserver interface
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the specified petrol.
        /// </summary>
        /// <param name="petrol">The petrol.</param>
        /// <param name="diesel">The diesel.</param>
        void Update(int petrol, int diesel);
    }
}