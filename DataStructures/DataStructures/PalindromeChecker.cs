// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
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
    /// Palindrome checking
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Palindromes the checker object.
        /// </summary>
        public static void PalindromeCheckerObj()
        {
            bool flag = false;
            Console.WriteLine("enter the string");
            string word = Utility.IsString(Console.ReadLine());
            char[] ch = word.ToCharArray();
            int n = ch.Length;
            DequeClass<char> deque = new DequeClass<char>(n);
            for (int i = 0; i < n; i++)
            {
                deque.AddRear(ch[i]);
            }
                
            char[] reverse = new char[n];
            for (int i = 0; i < n; i++)
            {
                reverse[i] = deque.PeekRear();
                deque.RemoveRear();
            }

            for (int i = 0; i < n; i++)
            {
                if (ch[i] != reverse[i])
                {
                    flag = false;
                    break;
                }                  
                else
                {
                    flag = true;
                }                   
            }

            Console.WriteLine(flag);
        }
    }
}
