// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace BasicProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BasicPrograms;      
    
    /// <summary>
    /// Prime factors of a number
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// Calculating prime factors of a number
        /// </summary>
        public static void PrimeFactorsObj()
        {
            Console.WriteLine("enter the number");
            int num = Utility.IsInteger(Console.ReadLine());
            //// traverse till i*i <= num
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num /= i;
                }
            }

            if (num > 2)
            {
                Console.WriteLine(num);
            }               
        }
    }
}
