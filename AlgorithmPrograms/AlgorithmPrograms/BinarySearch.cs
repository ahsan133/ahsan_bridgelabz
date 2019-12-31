// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Binary search a word in a txt file
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// The text
        /// </summary>
        public static readonly string Text = @"C:\Users\Admin\Desktop\ahsan\binary.txt";

        /// <summary>
        /// Middles the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        /// <param name="word">The word.</param>
        /// <returns>
        /// Returns if the word found or not
        /// </returns>
        public static int Middle(string[] array, int low, int high, string word)
        {
            int result = 0;          
            while (low <= high)
            {
                int mid = low + ((high - low) / 2);
                int compare = word.CompareTo(array[mid]);
                if (compare == 0)
                {
                    return 1;
                }
                else if (compare > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }                   
            }

            if (result == 1)
            {
                return 1;
            }              
            else
            {
                return 0;
            }              
        }

        /// <summary>
        /// Binaries the search object.
        /// </summary>
        public static void BinarySearchObj()
        {
            string[] array = File.ReadAllLines(Text);
            foreach (string line in array)
            {
                Console.WriteLine(line);
            }  
            
            int n = array.Length;
            Array.Sort(array);
            Console.WriteLine("enter the word");
            string word = Console.ReadLine();
            int flag = Middle(array, 0, n - 1, word);
            if (flag == 1)
            {
                Console.WriteLine("word found");
            }               
            else
            {
                Console.WriteLine("word not found");
            }                
        }
    }
}
