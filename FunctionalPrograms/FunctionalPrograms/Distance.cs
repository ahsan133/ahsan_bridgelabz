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
        public static void distance()
        {
            Console.WriteLine("enter the value of x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y");
            int y = Convert.ToInt32(Console.ReadLine());
            double distance = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("distance = " + distance);
        }
    }
}
