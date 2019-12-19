// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
        //file location
        static readonly string text = @"C:\Users\Admin\Desktop\ahsan\binary.txt";
        public static int Middle(string[] s, int lo, int hi, string word)
        {
            int res = 0;          
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                int a = word.CompareTo(s[mid]);
                if (a == 0)
                    return 1;
                else if (a > 0)
                    lo = mid + 1;
                else
                    hi = mid - 1;
            }
            if (res == 1)
               return 1;
            else
               return 0;
        }
        public static void BinarySearchObj()
        {
            //read text from file
            string[] s = File.ReadAllLines(text);
            foreach (string line in s)
            Console.WriteLine(line);
            int n = s.Length;
            Array.Sort(s);
            Console.WriteLine("enter the word");
            string word = Console.ReadLine();
            int flag=Middle(s, 0, n-1, word);
            if(flag==1)
                Console.WriteLine("word found");
            else
                Console.WriteLine("word not found");
        }
    }
}
