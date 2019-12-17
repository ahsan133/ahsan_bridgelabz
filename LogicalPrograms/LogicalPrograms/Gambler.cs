// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Gambler
    {
        public static void gambler()
        {
            Random random = new Random();
            int win = 0, loss = 0, i = 0;
            Console.WriteLine("enter stake and goal");
            int stake = Convert.ToInt32(Console.ReadLine());
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of times");
            int n = Convert.ToInt32(Console.ReadLine());
            while ((i != n) && (stake != goal))
            {
                //take random values
                if (random.NextDouble() < 0.5)
                {
                    win++;
                    stake++;
                }
                else
                {
                    loss++;
                    stake--;
                }
                i++;
            }
            //calculate percentage of wins and looses
            int wp = (win * 100) / n;
            int lp = (loss * 100) / n;
            Console.WriteLine("number of wins =" + win);
            Console.WriteLine("percentage wins =" + wp + "%");
            Console.WriteLine("percentage loss =" + lp + "%");
        }
    }
}
