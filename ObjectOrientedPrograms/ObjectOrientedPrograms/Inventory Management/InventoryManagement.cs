// --------------------------------------------------------------------------------------------------------------------
// <copyright file="inventoryManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using ObjectOrientedPrograms.Inventory_Management;          

    /// <summary>
    /// Managing the inventory
    /// </summary>
    public class InventoryManagement
    {
        /// <summary>
        /// Inventories the management object.
        /// </summary>
        public static void InventoryManagementObj()
        {
            InventoryMenu.Menu();
            Console.WriteLine("do you want to exit(y/n)");
            string response = Console.ReadLine();

            ////Repeating the function again
            while (response == "n" || response == "N")
            {
                InventoryMenu.Menu();
                Console.WriteLine("do you want to exit(y/n)");
                response = Console.ReadLine();
            }         
        }
    }
}