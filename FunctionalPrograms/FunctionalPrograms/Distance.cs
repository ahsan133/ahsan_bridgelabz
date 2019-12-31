// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calculating distance between origin and two points
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Distances the object.
        /// </summary>
        public static void DistanceObj()
        {
            Console.WriteLine("enter the value of x");
            int x = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("enter the value of y");
            int y = Utility.IsInteger(Console.ReadLine());
            double distance = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("distance = " + distance);
        }
    }
}
