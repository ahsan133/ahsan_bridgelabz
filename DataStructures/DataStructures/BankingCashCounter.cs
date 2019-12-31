// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankingCashCounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Cash counter using queue
    /// </summary>
    public class BankingCashCounter
    {
        /// <summary>
        /// Banking the cash counter object.
        /// </summary>
        public static void BankingCashCounterObj()
        {
            int i = 1, k = 1;
            int amount = 10000;
            Console.WriteLine("amount= " + amount);
            Console.WriteLine("enter the number of people");
            int n = Utility.IsInteger(Console.ReadLine());
            QueueClass<string> queue = new QueueClass<string>(n);
            Console.WriteLine("enter " + n + " names: ");
            while (i <= n)
            {
                string a = Utility.IsString(Console.ReadLine());
                queue.Add(a);
                i++;
            } 

            while (k <= n)
            {
                Console.WriteLine("people in queue are:");
                queue.Print();
                Console.WriteLine();
                Console.WriteLine("do you want to deposite or withdraw(w/d)?");
                string result = Console.ReadLine();
                if (result == "d")
                {
                    Console.WriteLine("enter the amount to deposite");
                    int am = Utility.IsInteger(Console.ReadLine());
                    amount += am;
                }
                else if (result == "w")
                {
                    Console.WriteLine("enter the amount to withdraw");
                    int newAmount = Utility.IsInteger(Console.ReadLine());
                    amount -= newAmount;
                }

                queue.Remove();
                Console.WriteLine("amount= " + amount);
                k++;
            }         
        }
    }
}
