// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PowerOfTwo
    {
        public static void PowerOfTwoObj()
        {
            Console.WriteLine("enter the number");
            int num = Utility.IsInteger(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}