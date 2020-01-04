// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rice.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Inventory_Management
{
    using System;   
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Rice list
    /// </summary>
    public class Rice
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight
        /// </summary>
        private double weight;

        /// <summary>
        /// The price
        /// </summary>
        private double price;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get => this.weight; set => this.weight = value; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get => this.price; set => this.price = value; }

        /// <summary>
        /// Rice the object.
        /// </summary>
        public static void RiceObj()
        {
            InventoryItems array = Utility.ReadJsonFile();
            foreach (var i in array.Rice)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Inserts the rice.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="price">The price.</param>
        public static void InsertRice(string name, double weight, double price)
        {
            InventoryItems array = Utility.ReadJsonFile();
            Rice obj = new Rice();
            obj.Name = name;
            obj.Weight = weight;
            obj.Price = price;
            array.Rice.Add(obj);
            Utility.WriteJsonFile(array);
        }

        /// <summary>
        /// Updates the rice.
        /// </summary>
        public static void UpdateRice()
        {
            int j = 1;
            InventoryItems array = Utility.ReadJsonFile();
            foreach (var i in array.Rice)
            {
                Console.WriteLine(j++ + "=" + i.Name);
            }

            Console.WriteLine("Enter the item");
            int itemNumber = Utility.IsInteger(Console.ReadLine());
            string name = array.Rice[itemNumber - 1].Name;
            foreach (var item in array.Rice)
            {
                if (item.Name != name)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("name = " + item.Name + "\nweight = " + item.Weight + "\nprice per kg =" + item.Price);
                }
            }

            Console.WriteLine("enter 1 to edit name");
            Console.WriteLine("enter 2 to edit weight");
            Console.WriteLine("enter 3 to edit price");

            int choice = Utility.IsInteger(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("enter a proper choice");
                choice = Utility.IsInteger(Console.ReadLine());
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter the new name");
                    string newName = Utility.IsString(Console.ReadLine());
                    array.Rice[itemNumber - 1].Name = newName;
                    break;
                case 2:
                    Console.WriteLine("enter the new weight");
                    double newWeight = Utility.IsDouble(Console.ReadLine());
                    array.Rice[itemNumber - 1].Weight = newWeight;
                    break;
                case 3:
                    Console.WriteLine("enter the new price");
                    double newPrice = Utility.IsDouble(Console.ReadLine());
                    array.Rice[itemNumber - 1].Price = newPrice;
                    break;
            }

            Utility.WriteJsonFile(array);
        }

        /// <summary>
        /// Deletes the rice.
        /// </summary>
        public static void DeleteRice()
        {
            int j = 1;
            InventoryItems array = Utility.ReadJsonFile();
            foreach (var i in array.Rice)
            {
                Console.WriteLine(j++ + "=" + i.Name);
            }

            Console.WriteLine("Enter the item to delete");
            int itemNumber = Utility.IsInteger(Console.ReadLine());           
            array.Rice.RemoveAt(itemNumber - 1);
            Utility.WriteJsonFile(array);
        }
    }  
}
