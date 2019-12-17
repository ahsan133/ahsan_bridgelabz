// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Factors.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class PrimeFactors
    {
        public static void factors()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            // traverse till i*i <= num
            for (int i=2;i<Math.Sqrt(num);i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num /= i;
                }
            }
            if(num>2)
                Console.WriteLine(num);
        }
    }
}
