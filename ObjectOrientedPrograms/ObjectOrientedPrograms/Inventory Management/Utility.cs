using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOrientedPrograms.Inventory_Management;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms
{
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
        public static InventoryItems ReadJsonFile()
        {

            if (File.Exists(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventory Management\InventoryManage.json"))
            {
                string files = File.ReadAllText(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventory Management\InventoryManage.json");
                InventoryItems array = JsonConvert.DeserializeObject<InventoryItems>(files);
                return array;
            }
            else
            {
                Console.WriteLine("path does not exist");
                return new InventoryItems();
            }
        }

        public static void WriteJsonFile(InventoryItems file)
        {
            string json = JsonConvert.SerializeObject(file);
            File.WriteAllText(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventory Management\json1.json", json);
        }

       

      
    }   
}
