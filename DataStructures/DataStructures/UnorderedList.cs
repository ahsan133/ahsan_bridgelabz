// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnorderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class UnorderedList
    {
        static readonly string text = @"C:\Users\Admin\Desktop\ahsan\unordered.txt";
        static readonly string textRes = @"C:\Users\Admin\Desktop\ahsan\unordered_result.txt";
        public static void UnorderedListObj()
        {

            Utility<string> list = new Utility<string>();
            string[] s = File.ReadAllLines(text);
            foreach (string line in s)
                Console.WriteLine(line);

            int i = 0;
            int n = s.Length;
            while (i != n)
            {
                string[] a = s[i].Split(" ");
                for (int j = 0; j < a.Length; j++)
                    list.Insert(a[j]);
                i++;
            }
            list.Print();
            Console.WriteLine();
            Console.WriteLine("enter the word to be searched");
            string word = Console.ReadLine();
            if (list.Search(word))
                list.Remove(word);
            else
                list.Insert(word);
            list.Print();
            Console.WriteLine();
            int l = list.Size();
            string[] arr = new string[l];
            for ( i = 0; i < l; i++)
                arr[i] = list.Get(i);
            File.WriteAllLines(textRes, arr);
            

        }
    }
}    