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
        public static void Permute(string s,int lo,int hi)
        {
            if(lo==hi)
                Console.WriteLine(s);
            else
            {
                for(int i=lo;i<=hi;i++)
                {
                    s = Swap(s, lo, i);
                    Permute(s, lo + 1, hi);
                    s = Swap(s, lo, i);
                }
            }
        }
        //swap characters at i and j
        public static string Swap(string s,int i,int j)
        {

            char temp;
            char[] a = s.ToCharArray();
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            string str = new string(a);
            return str;
        }
        public static void PermutationsObj()
        {
            Console.WriteLine("enter the string");
            String s = Utility.IsString(Console.ReadLine());
            int n = s.Length;
            Permute(s, 0, n - 1);
        }
    }
}
