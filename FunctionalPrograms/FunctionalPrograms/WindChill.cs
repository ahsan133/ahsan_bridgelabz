// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public static void WindChillObj()
        {
            Console.WriteLine("enter the value of t and v");
            int t = Utility.IsInteger(Console.ReadLine());
            int v = Utility.IsInteger(Console.ReadLine());
            // the formula is not valid if t is larger than 50 in absolute value or if v is larger than 120 or less than 3
            if ((t > 50) || (v > 120) || (v < 3))
            {
                Console.WriteLine("'t' cannot be greater than 50 and 'v'should be greater than 3 and less than 120");
            }
            else
            {
                double w = 35.74 + (0.6215 * t) + (0.4275 * t - 35.75) * (Math.Pow(v, 0.16));
                Console.WriteLine("windchill=" + w);
            }
        }
    }
}
