// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Operations.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Inventory_Management
{
    using System;     
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Calling functions to perform operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Inserts the specified category.
        /// </summary>
        /// <param name="category">The category.</param>
        public static void Insert(int category)
        {         
            Console.WriteLine("enter name");
            string name = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter weight");
            double weight = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("enter price per kg");
            double price = Utility.IsInteger(Console.ReadLine());
            if (category == 1)
            {
                Rice.InsertRice(name, weight, price);
            }
            else if (category == 2)
            {
                Wheat.InsertWheat(name, weight, price);
            }
            else if (category == 3)
            {
                Pulse.InsertPulse(name, weight, price);
            }
           
            Console.WriteLine("item is added");
        }

        /// <summary>
        /// Updates the specified category.
        /// </summary>
        /// <param name="category">The category.</param>
        public static void Update(int category)
        {
            if (category == 1)
            {
                Rice.UpdateRice();
            }
            else if (category == 2)
            {
                Wheat.UpdateWheat();
            }
            else if (category == 3)
            {
                Pulse.UpdatePulse();
            }
        }

        /// <summary>
        /// Deletes the specified category.
        /// </summary>
        /// <param name="category">The category.</param>
        public static void Delete(int category)
        {
            if (category == 1)
            {
                Rice.DeleteRice();
            }
            else if (category == 2)
            {
                Wheat.DeleteWheat();
            }
            else if (category == 3)
            {
                Pulse.DeletePulse();
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public static void Print()
        {
            InventoryItems array = Utility.ReadJsonFile();
            Console.WriteLine("Rice:");
            foreach (var i in array.Rice)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }

            Console.WriteLine("Wheat:");
            foreach (var i in array.Wheat)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }

            Console.WriteLine("Pulse:");
            foreach (var i in array.Pulse)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }
        }
    }
}
