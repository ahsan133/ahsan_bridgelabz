// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class FlipCoin
    {
        public static void flipcoin()
        {
            Random random = new Random();
            int tails = 0, heads = 0;
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                //taking random number from 0 to 1
                if (random.NextDouble() < 0.5)
                    tails++;
                else
                    heads++;
            }
            double h = (heads * 100) / num;
            double t = (tails * 100) / num;
            Console.WriteLine("heads= " + h + "%");
            Console.WriteLine("tails= " + t + "%");
        }
    }
}
