// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
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
    /// Percentage of coin flip
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// Flips the coin object.
        /// </summary>
        public static void FlipCoinObj()
        {
            int tails = 0, heads = 0;
            Console.WriteLine("enter the number");
            int num = Utility.IsInteger(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                ////taking random number from 0 to 1
                if (Utility.RandomDouble() < 0.5)
                {
                    tails++;
                }                   
                else
                {
                    heads++;
                }                    
            }

            double head = (heads * 100) / num;
            double tail = (tails * 100) / num;
            Console.WriteLine("heads= " + head + "%");
            Console.WriteLine("tails= " + tail + "%");
        }
    }
}
