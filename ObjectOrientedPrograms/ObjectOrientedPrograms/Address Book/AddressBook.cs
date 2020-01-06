// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
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
    /// Address book with all contact info.
    /// </summary>
    public class AddressBook
    {
        /// <summary>
        /// Addresses the book object.
        /// </summary>
        public static void AddressBookObj()
        {
            string file = Utility.ReadJson();
            var array = JsonConvert.DeserializeObject<List<AddressMaintain>>(file);
            foreach (var i in array)
            {
                Console.WriteLine("firstname= " + i.FirstName);
                Console.WriteLine("lastname= " + i.LastName);
                Console.WriteLine("address= " + i.Address);
                Console.WriteLine("city= " + i.City);
                Console.WriteLine("state= " + i.State);
                Console.WriteLine("zip= " + i.Zip);
                Console.WriteLine("phone= " + i.Phone);
                Console.WriteLine();
            }

            Console.WriteLine("Enter 1 to add");
            Console.WriteLine("Enter 2 to remove");
            Console.WriteLine("Enter 3 to update");
            Console.WriteLine("Enter 4 to sort");

            int choice = Utility.IsInteger(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4)
            {
                Console.WriteLine("enter the valid choice");
                choice = Utility.IsInteger(Console.ReadLine());
            }

            switch (choice)
            {
                case 1:
                    Operations.Insert();
                    break;
                case 2:
                    Operations.Remove();
                    break;
                case 3:
                    Operations.Update();
                    break;
                case 4:
                    Operations.Sort();
                    break;
                default:
                    break;
            }
        }
    }
}