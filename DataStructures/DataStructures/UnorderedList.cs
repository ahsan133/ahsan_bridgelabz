// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnorderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Unordered list using linked list
    /// </summary>
    public class UnorderedList
    {
        /// <summary>
        /// The text
        /// </summary>
        public static readonly string Text = @"C:\Users\Admin\Desktop\ahsan\unordered.txt";

        /// <summary>
        /// The text result
        /// </summary>
        public static readonly string TextResult = @"C:\Users\Admin\Desktop\ahsan\unordered_result.txt";

        /// <summary>
        /// Unordered the list object.
        /// </summary>
        public static void UnorderedListObj()
        {
            LinkedListClass<string> list = new LinkedListClass<string>();
            string[] s = File.ReadAllLines(Text);
            foreach (string line in s)
            {
                Console.WriteLine(line);
            }
                
            int i = 0;
            int n = s.Length;
            while (i != n)
            {
                string[] a = s[i].Split(" ");
                for (int j = 0; j < a.Length; j++)
                {
                    list.Insert(a[j]);
                }    
                
                i++;
            }

            list.Print();
            Console.WriteLine();
            Console.WriteLine("enter the word to be searched");
            string word = Utility.IsString(Console.ReadLine());
            if (list.Search(word))
            {
                list.Remove(word);
            }               
            else
            {
                list.Insert(word);
            }
                
            list.Print();
            Console.WriteLine();
            int l = list.Size();
            string[] arr = new string[l];
            for (i = 0; i < l; i++)
            {
                arr[i] = list.Get(i);
            }
               
            File.WriteAllLines(TextResult, arr);
        }
    }
}    