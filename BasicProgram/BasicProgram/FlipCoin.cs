// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using BasicPrograms;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class FlipCoin
    {
        public static void FlipCoinObj()
        {
            int tails = 0, heads = 0;
            Console.WriteLine("enter the number");
            int num = Utility.IsInteger(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                //taking random number from 0 to 1
                if (Utility.RandomDouble() < 0.5)
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
