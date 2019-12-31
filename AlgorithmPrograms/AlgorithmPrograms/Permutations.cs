// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Permutations.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// All permutations of a string
    /// </summary>
    public class Permutations
    {
        /// <summary>
        /// Permutes the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        public static void Permute(string word, int low, int high)
        {
            if (low == high)
            {
                Console.WriteLine(word);
            }
            else
            {
                for (int i = low; i <= high; i++)
                {
                    word = Swap(word, low, i);
                    Permute(word, low + 1, high);
                    word = Swap(word, low, i);
                }
            }
        }

        /// <summary>
        /// Swaps the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        /// <returns>
        /// Returns swapped string
        /// </returns>
        public static string Swap(string word, int i, int j)
        {
            char temp;
            char[] chars = word.ToCharArray();
            temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
            string swapped = new string(chars);
            return swapped;
        }

        /// <summary>
        /// Permutations the object.
        /// </summary>
        public static void PermutationsObj()
        {
            Console.WriteLine("enter the string");
            string word = Utility.IsString(Console.ReadLine());
            int size = word.Length;
            Permute(word, 0, size - 1);
        }
    }
}
