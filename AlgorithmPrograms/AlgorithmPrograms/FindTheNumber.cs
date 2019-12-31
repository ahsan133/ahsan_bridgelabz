// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindTheNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Find the number
    /// </summary>
    public class FindTheNumber
    {
        /// <summary>
        /// Numbers the specified lo.
        /// </summary>
        /// <param name="low">The lo.</param>
        /// <param name="high">The hi.</param>
        public static void Number(int low, int high)
        {
            int mid = low + ((high - low) / 2);
            if ((low != mid) || (mid != high))
            {
                while (low <= high)
                {
                    Console.WriteLine("is your number " + mid);
                    Console.WriteLine("enter 1 for yes and 0 for no");
                    int input = Utility.IsInteger(Console.ReadLine());
                    if (input != 1)
                    {
                        Console.WriteLine("is your number between " + low + " and " + mid);
                        Console.WriteLine("enter 1 for yes and 0 for no");
                        int result = Utility.IsInteger(Console.ReadLine());
                        if (result == 1)
                        {
                            Number(low, mid);
                        }
                        else
                        {
                            Number(mid + 1, high);
                        }                         
                    }
                    else
                    {
                        break;
                    }   
                    
                    break;
                }                          
            }
            else
            {
                Console.WriteLine("your number is " + mid);              
            }
        }

        /// <summary>
        /// Finds the number object.
        /// </summary>
        public static void FindTheNumberObj()
        {
            Console.WriteLine("enter the number which power of 2");
            int input = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("think of a number between 0 and " + input);
            Number(0, input);
        }
    }
}
