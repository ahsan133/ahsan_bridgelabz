// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
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
