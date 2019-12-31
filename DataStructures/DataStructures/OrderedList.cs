// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
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
    /// Ordered list using linked list
    /// </summary>
    public class OrderedList
    {
        /// <summary>
        /// The text
        /// </summary>
        public static readonly string Text = @"C:\Users\Admin\Desktop\ahsan\ordered.txt";

        /// <summary>
        /// The text result
        /// </summary>
        public static readonly string TextResult = @"C:\Users\Admin\Desktop\ahsan\ordered_result.txt";

        /// <summary>
        /// Ordered the list object.
        /// </summary>
        public static void OrderedListObj()
        {
            LinkedListClass<int> list = new LinkedListClass<int>();
            string[] arr = File.ReadAllLines(Text);
            
            int n = arr.Length;
            int i = 0;
            while (i != n)
            {
                string[] a = arr[i].Split(" ");
                for (int j = 0; j < a.Length; j++)
                {
                    int b = Convert.ToInt32(a[j]);
                    list.InsertAscending(b);
                }

                i++;
            }

            list.Print();
            Console.WriteLine();
            Console.WriteLine("enter a number");
            int num = Utility.IsInteger(Console.ReadLine());
            if (list.Search(num))
            {
                list.Remove(num);
            }               
            else
            {
                list.InsertAscending(num);
            }
                
            list.Print();
            int length = list.Size();
            string[] array = new string[length];
            for (int k = 0; k < length; k++)
            {
                array[k] = list.Get(k).ToString();
            }
                
            File.WriteAllLines(TextResult, array);
        }
    }
}
