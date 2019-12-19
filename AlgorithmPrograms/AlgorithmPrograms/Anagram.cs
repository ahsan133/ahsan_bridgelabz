// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Anagram
    {
        public static bool Compare(char[] a, char[] b)
        {
            int n = a.Length, count = 0;
            Array.Sort(a);
            Array.Sort(b);
            for (int i = 0; i < n; i++)
            {
                if (a[i] == b[i])
                    count++;
            }
            if (count == n)
                return true;
            else
                return false;
        }
        public static void AnagramObj()
        {
            bool flag = false;
            Console.WriteLine("enter the first string");
            String s1 = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter the second string");
            String s2 = Utility.IsString(Console.ReadLine());
            int n1 = s1.Length;
            int n2 = s2.Length;
            if (n1 != n2)
                Console.WriteLine("the two strings are not anagram");
            else
            {
                char[] c1 = s1.ToCharArray();
                char[] c2 = s2.ToCharArray();
                //compare two strings
                flag = Compare(c1, c2);
            }
            if (flag)
                Console.WriteLine("the two strings are anagram");
            else
                Console.WriteLine("the two strings are not anagram");
        }
    }
}

