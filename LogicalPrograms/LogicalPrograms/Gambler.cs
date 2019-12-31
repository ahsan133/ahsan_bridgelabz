// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------

namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Gambler Simulation.
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Gamblers the object.
        /// </summary>
        public static void GamblerObj()
        {
            int win = 0, loss = 0, i = 0;
            Console.WriteLine("enter stake and goal");
            int stake = Utility.IsInteger(Console.ReadLine());
            int goal = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("enter number of times");
            int n = Utility.IsInteger(Console.ReadLine());
            while ((i != n) && (stake != goal))
            {
                ////take random values
                if (Utility.RandomDouble() < 0.5)
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
            ////calculate percentage of wins and looses
            int winPercentage = (win * 100) / n;
            int loosePercentage = (loss * 100) / n;
            Console.WriteLine("number of wins =" + win);
            Console.WriteLine("percentage wins =" + winPercentage + "%");
            Console.WriteLine("percentage loss =" + loosePercentage + "%");
        }
    }
}
