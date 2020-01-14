// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObserverDesign.cs" company="Bridgelabz">
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
    /// main program
    /// </summary>
    public class ObserverDesign
    {
        /// <summary>
        /// Observers the design object.
        /// </summary>
        public static void ObserverDesignObj()
        {
            Fuel fuel = new Fuel();

            fuel.SetPetrol(78);
            fuel.SetDiesel(68);
        }
    } 
}