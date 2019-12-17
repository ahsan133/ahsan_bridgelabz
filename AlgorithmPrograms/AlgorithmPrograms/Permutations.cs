// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Permutations.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Permutations
    {
        public static void permute(string s,int lo,int hi)
        {
            if(lo==hi)
                Console.WriteLine(s);
            else
            {
                for(int i=lo;i<=hi;i++)
                {
                    s = swap(s, lo, i);
                    permute(s, lo + 1, hi);
                    s = swap(s, lo, i);
                }
            }
        }
        //swap characters at i and j
        public static string swap(string s,int i,int j)
        {

            char temp;
            char[] a = s.ToCharArray();
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            string str = new string(a);
            return str;
        }
        public static void permutation()
        {
            Console.WriteLine("enter the string");
            String s = Console.ReadLine();
            int n = s.Length;
            permute(s, 0, n - 1);
        }
    }
}
