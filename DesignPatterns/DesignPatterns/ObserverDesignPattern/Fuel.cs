// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fuel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ObserverDesignPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Fuel class implements Isubject
    /// </summary>
    public class Fuel : ISubject
    {
        /// <summary>
        /// initialising observers list.
        /// </summary>
        private List<IObserver> observers;

        /// <summary>
        /// The petrol.
        /// </summary>
        public int petrol;

        /// <summary>
        /// The diesel.
        /// </summary>
        public int diesel;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Fuel()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// Register method.
        /// </summary>
        /// <param name="obj"></param>
        public void Register(IObserver obj) 
        {
            observers.Add(obj);
            Notify();
        }

        /// <summary>
        /// Unregister method
        /// </summary>
        /// <param name="obj"></param>
        public void Unregister(IObserver obj)
        {
            int index = observers.IndexOf(obj);
            observers.Remove(obj);
            Console.WriteLine(index + " removed");
            Notify();
        }

        /// <summary>
        /// Notify method.
        /// </summary>
        public void Notify()
        {
            foreach (IObserver i in observers)
            {
                i.Update(petrol, diesel);
            }
        }

        /// <summary>
        /// SetPetrol method.
        /// </summary>
        /// <param name="newPrice"></param>
        public void SetPetrol(int newPrice)
        {
            this.petrol = newPrice;
            IObserver obj = new FuelObserve(newPrice, 0);
            Register(obj);
        }

        /// <summary>
        /// SetDiesel method.
        /// </summary>
        /// <param name="newPrice"></param>
        public void SetDiesel(int newPrice)
        {
            this.diesel = newPrice;
            IObserver obj = new FuelObserve(0, newPrice);
            Register(obj);
        }
    }
}