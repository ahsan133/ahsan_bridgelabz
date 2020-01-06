// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Address_Book
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Utility class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Determines whether the specified input is integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Returns the integer value
        /// </returns>
        public static int IsInteger(string input)
        {
            int number;
            if (int.TryParse(input, out number))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                while (int.TryParse(input, out number) == false)
                {
                    Console.WriteLine("please enter a proper integer");
                    input = Console.ReadLine();
                }

                return Convert.ToInt32(input);
            }
        }

        /// <summary>
        /// Determines whether the specified input is string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Returns the string
        /// </returns>
        public static string IsString(string input)
        {
            int flag = 1;
            do
            {
                ////check if the input has whitespace
                if (input.Contains(" "))
                {
                    Console.WriteLine("the string entered has a whitespace. please enter a proper string");
                    input = Console.ReadLine();
                }
                ////check if the input has number or not
                for (int i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("the string entered has a number. please enter a proper string");
                        input = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
            }
            while (flag == 1);

            return input;
        }

        /// <summary>
        /// Determines whether the specified input is double.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Returns the double value
        /// </returns>
        public static long IsLong(string input)
        {
            long number;
            if (long.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                while (long.TryParse(input, out number) == false)
                {
                    Console.WriteLine("please enter a proper integer");
                    input = Console.ReadLine();
                }

                return number;
            }
        }

        /// <summary>
        /// Reads the json.
        /// </summary>
        /// <returns>
        /// returns the json file
        /// </returns>
        public static string ReadJson()
        {
                string file = File.ReadAllText(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\Address Book\Addressjson.json");
                return file;
        }

        /// <summary>
        /// Writes the json.
        /// </summary>
        /// <param name="file">The file.</param>
        public static void WriteJson(string file)
        {
            File.WriteAllText(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\Address Book\Addressjson.json", file);
        }
    }
}
