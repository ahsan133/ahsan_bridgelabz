// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
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
    /// Anagram of two strings
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// Compares the specified chars1.
        /// </summary>
        /// <param name="chars1">The chars1.</param>
        /// <param name="chars2">The chars2.</param>
        /// <returns>
        /// Returns a boolean value if the characters are equal or not
        /// </returns>
        public static bool Compare(char[] chars1, char[] chars2)
        {
            int length = chars1.Length, count = 0;
            Array.Sort(chars1);
            Array.Sort(chars2);
            for (int i = 0; i < length; i++)
            {
                if (chars1[i] == chars2[i])
                {
                    count++;
                }                   
            }

            if (count == length)
            {
                return true;
            }                
            else
            {
                return false;
            }                
        }

        /// <summary>
        /// Anagrams the object.
        /// </summary>
        public static void AnagramObj()
        {
            bool flag = false;
            Console.WriteLine("enter the first string");
            string string1 = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter the second string");
            string string2 = Utility.IsString(Console.ReadLine());
            int length1 = string1.Length;
            int length2 = string2.Length;
            if (length1 != length2)
            {
                Console.WriteLine("the two strings are not anagram");
            }               
            else
            {
                char[] chars1 = string1.ToCharArray();
                char[] chars2 = string2.ToCharArray();
                ////compare two strings
                flag = Compare(chars1, chars2);
            }

            if (flag)
            {
                Console.WriteLine("the two strings are anagram");
            }                
            else
            {
                Console.WriteLine("the two strings are not anagram");
            }               
        }
    }
}