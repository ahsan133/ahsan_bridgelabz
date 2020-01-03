using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.Inventory_Management
{
    public class InventoryMenu
    {
        public static void Menu()
        {
            Console.WriteLine("Select an category");
            Console.WriteLine("1.Rice\n2.Wheat\n3.Pulse");
            int category = Utility.IsInteger(Console.ReadLine());
            while (category != 1 && category != 2 && category != 3)
            {
                Console.WriteLine("item dosent exist");
                category = Utility.IsInteger(Console.ReadLine());
            }
            switch (category)
            {
                case 1:
                    Rice.RiceObj();
                    break;
                case 2:
                    Wheat.WheatObj();
                    break;
                case 3:
                    Pulse.PulseObj();
                    break;
                default:
                    break;
            }

            Console.WriteLine("select a operation to perform");
            Console.WriteLine("1.Add\n2.Update\n3.Delete");
            int operation = Utility.IsInteger(Console.ReadLine());
            while (operation != 1 && operation != 2 && operation != 3)
            {
                Console.WriteLine("operation dosent exist");
                operation = Utility.IsInteger(Console.ReadLine());
            }
            switch (operation)
            {
                case 1:
                    Operations.Insert(category);
                    break;
                case 2:
                    Operations.Update(category);
                    break;
                case 3:
                      Operations.Delete(category);
                    break;
                default:
                    break;
            }

        }
    }
}