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
        public static void Power()
        {
            Console.WriteLine("enter the number");
            string s = Console.ReadLine();
            int num = Convert.ToInt32(s);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}