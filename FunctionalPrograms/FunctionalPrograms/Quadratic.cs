// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Quadratic
    {
        public static void QuadraticObj()
        {
            double root1 = 0;
            double root2 = 0;
            Console.WriteLine("enter the value of a b c");
            int a = Utility.IsInteger(Console.ReadLine());
            int b = Utility.IsInteger(Console.ReadLine());
            int c = Utility.IsInteger(Console.ReadLine());
            int delta = (b * b) - (4 * a * c);
            //for different values of delta
            if (delta == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("the roots are " + root1 + " and " + root2);
            }
            else if (delta > 0)
            {
                root1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                root2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("the roots are " + root1 + " and " + root2);
            }
            else if (delta < 0)
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
                //taking 2 digits after decimal
                Console.WriteLine("the roots are " + realPart + "+" + imaginaryPart + "i" + " and " + realPart + "-" + imaginaryPart + "i");
            }
        }
    }
}

