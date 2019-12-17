// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumbers
    {
        public static void prime()
        {
            Console.WriteLine("enter the range");
            int low = Convert.ToInt32(Console.ReadLine());
            int high= Convert.ToInt32(Console.ReadLine());
            while (low < high)
            {
                bool flag = false;
                for (int i = 2; i <= low / 2; ++i)
                {
                    if (low % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    Console.WriteLine(low + " ");
                ++low;
            }
        }
          
    }
}
