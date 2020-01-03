using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.Inventory_Management
{
    class Operations
    {
        public static void Insert(int category)
        {         
            Console.WriteLine("enter name");
            string name = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter weight");
            int weight = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("enter price per kg");
            int price = Utility.IsInteger(Console.ReadLine());
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

        public static void Delete(string name)
        {

        }

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
            foreach(var i in array.Wheat)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }
            Console.WriteLine("Pulse:");
            foreach(var i in array.Pulse)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }
        }

    }
}
