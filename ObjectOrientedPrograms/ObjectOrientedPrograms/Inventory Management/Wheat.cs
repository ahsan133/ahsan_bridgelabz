﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.Inventory_Management
{
    public class Wheat
    {
        private string name;
        private int weight;
        private int price;

        public string Name { get => this.name; set => this.name = value; }
        public int Weight { get => this.weight; set => this.weight = value; }
        public int Price { get => this.price; set => this.price = value; }


        public static void WheatObj()
        {
            InventoryItems array = Utility.ReadJsonFile();
            foreach (var i in array.Wheat)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
                Console.WriteLine();
            }
        }

        public static void InsertWheat(string name, int weight, int price)
        {
            InventoryItems array = Utility.ReadJsonFile();
            Wheat obj = new Wheat();
            obj.Name = name;
            obj.Weight = weight;
            obj.Price = price;
            array.Wheat.Add(obj);
            Utility.WriteJsonFile(array);
        }

        public static void UpdateWheat()
        {
            int j = 1;
            InventoryItems array = Utility.ReadJsonFile();
            foreach (var i in array.Wheat)
            {
                Console.WriteLine(j++ + ".name =" + i.Name);
            }

            Console.WriteLine("Enter the item");
            int itemNumber = Utility.IsInteger(Console.ReadLine());
            string name = array.Wheat[itemNumber - 1].Name;
            foreach (var item in array.Wheat)
            {
                if (item.Name != name)
                {
                    continue; ;
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
                    array.Wheat[choice].Name = newName;
                    break;
                case 2:
                    Console.WriteLine("enter the new weight");
                    int newWeight = Utility.IsInteger(Console.ReadLine());
                    array.Wheat[choice].Weight = newWeight;
                    break;
                case 3:
                    Console.WriteLine("enter the new price");
                    int newPrice = Utility.IsInteger(Console.ReadLine());
                    array.Wheat[choice].Price = newPrice;
                    break;
            }

            Utility.WriteJsonFile(array);

        }
    }
}
