// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindANumber.cs" company="Bridgelabz">
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
    /// Finding a number in a txt file
    /// </summary>
    public class FindANumber
    {
        /// <summary>
        /// The text
        /// </summary>
        public static readonly string Text = @"C:\Users\Admin\Desktop\ahsan\hashing.txt";

        /// <summary>
        /// Finds a number object.
        /// </summary>
        public static void FindANumberObj()
        {
            int location = 0;
            Hashing<int, int> hash = new Hashing<int, int>();
            string[] numbers = File.ReadAllLines(Text);
            for (int i = 0; i < numbers.Length; i++)
            {
                string[] number = numbers[i].Split(" ");
                for (int j = 0; j < number.Length; j++)
                {
                    int integer = Convert.ToInt32(number[j]);
                    location = integer % 11;
                    hash.Insert(location, integer);
                }                    
            }

            hash.Print();
            Console.WriteLine("enter the number to search");
            int num = Utility.IsInteger(Console.ReadLine());
            location = num % 11;
            if (hash.Search(num))
            {
                hash.Remove(location, num);
            }               
            else
            {
                hash.Insert(location, num);
            }
            
            hash.Print();
        }
    }
}
