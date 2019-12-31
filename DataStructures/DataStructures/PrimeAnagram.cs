// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagram.cs" company="Bridgelabz">
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
    /// Prime number anagrams and non anagrams
    /// </summary>
    public class PrimeAnagram
    {
        /// <summary>
        /// Primes the anagram object.
        /// </summary>
        public static void PrimeAnagramObj()
        {
            int p = 0;
            int q = 0;
            int[,] array = new int[2, 100000];
            int[] arr = Utility.PrimeNumbers(0, 1000);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Utility.Anagram(arr[i], arr[j]))
                    {
                        array[0, p++] = arr[i];
                        array[0, p++] = arr[j];
                    }
                    else
                    {
                        array[1, q++] = arr[i];
                        array[1, q++] = arr[j];
                    }
                }
            }

            ////Printing the 2D array
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 100; j++)
                {
                    Console.Write(array[i, j] + " ");
                }                   
            }
        }
    }
}
