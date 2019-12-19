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
        public static void PrimeNumbersObj()
        {
            Console.WriteLine("enter the range");
            int low = Utility.IsInteger(Console.ReadLine());
            int high= Utility.IsInteger(Console.ReadLine());
            int[] array=Utility.PrimeNumbers(low, high);
            for (int i=0;i<array.Length;i++)
                Console.WriteLine(array);
        }
          
    }
}
