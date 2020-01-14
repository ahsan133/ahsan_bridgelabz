// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FuelObserve.cs" company="Bridgelabz">
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
    /// FuelObserve class implements IObserver
    /// </summary>
    /// <seealso cref="DesignPatterns.ObserverDesignPattern.IObserver" />
    public class FuelObserve : IObserver
    {
        /// <summary>
        /// The petrol
        /// </summary>
        private int petrol;

        /// <summary>
        /// The diesel
        /// </summary>
        private int diesel;

        /// <summary>
        /// Initializes a new instance of the <see cref="FuelObserve"/> class.
        /// </summary>
        /// <param name="petrol">The petrol.</param>
        /// <param name="diesel">The diesel.</param>
        public FuelObserve(int petrol, int diesel)
        {
            this.petrol = petrol;
            this.diesel = diesel;
        }

        /// <summary>
        /// Updates the specified petrol.
        /// </summary>
        /// <param name="petrol">The petrol.</param>
        /// <param name="diesel">The diesel.</param>
        public void Update(int petrol, int diesel)
        {
            this.petrol = petrol;
            this.diesel = diesel;

            Print();
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("petrol= " + this.petrol + " diesel= " + this.diesel);
        }
    }
}
