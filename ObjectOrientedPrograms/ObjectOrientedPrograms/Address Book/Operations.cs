// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Operations.cs" company="Bridgelabz">
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
    /// Address book operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Inserts this instance.
        /// </summary>
        public static void Insert()
        {
            string file = Utility.ReadJson();
            var array = JsonConvert.DeserializeObject<List<AddressMaintain>>(file);

            AddressMaintain obj = new AddressMaintain();
            Console.WriteLine("enter first name");
            obj.FirstName = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter last name");
            obj.LastName = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter address");
            obj.Address = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter city");
            obj.City = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter state");
            obj.State = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter zip code");
            obj.Zip = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("enter phone");
            obj.Phone = Utility.IsLong(Console.ReadLine());
            array.Add(obj);

            string json = JsonConvert.SerializeObject(array);
            Utility.WriteJson(json);
            Console.WriteLine("added to address book");
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public static void Remove()
        {
            string file = Utility.ReadJson();
            var array = JsonConvert.DeserializeObject<List<AddressMaintain>>(file);

            int count = 0;
            Console.WriteLine("enter the first name to delete");
            string name = Utility.IsString(Console.ReadLine());
            foreach (var i in array)
            {
                if (i.FirstName != name)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            array.RemoveAt(count);
            string json = JsonConvert.SerializeObject(array);
            Utility.WriteJson(json);
            Console.WriteLine("name deleted");
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public static void Update()
        {
            string file = Utility.ReadJson();
            var array = JsonConvert.DeserializeObject<List<AddressMaintain>>(file);

            int count = 0;
            Console.WriteLine("enter the first name to update");
            string name = Utility.IsString(Console.ReadLine());
            foreach (var i in array)
            {
                if (i.FirstName != name)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("enter 1 to update first name");
            Console.WriteLine("enter 2 to update last name");
            Console.WriteLine("enter 3 to update address");
            Console.WriteLine("enter 4 to update city");
            Console.WriteLine("enter 5 to update state");
            Console.WriteLine("enter 6 to update zip code");
            Console.WriteLine("enter 7 to update phone");
            int choice = Utility.IsInteger(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter the new first name");
                    string newFirstName = Utility.IsString(Console.ReadLine());
                    array[count].FirstName = newFirstName;
                    break;
                case 2:
                    Console.WriteLine("enter the new last name");
                    string newLastName = Utility.IsString(Console.ReadLine());
                    array[count].LastName = newLastName;
                    break;
                case 3:
                    Console.WriteLine("enter the new address");
                    string newaddress = Utility.IsString(Console.ReadLine());
                    array[count].Address = newaddress;
                    break;
                case 4:
                    Console.WriteLine("enter the new city");
                    string newCity = Utility.IsString(Console.ReadLine());
                    array[count].City = newCity;
                    break;
                case 5:
                    Console.WriteLine("enter the new state");
                    string newState = Utility.IsString(Console.ReadLine());
                    array[count].State = newState;
                    break;
                case 6:
                    Console.WriteLine("enter the new zip code");
                    int newZip = Utility.IsInteger(Console.ReadLine());
                    array[count].Zip = newZip;
                    break;
                case 7:
                    Console.WriteLine("enter the new phone number");
                    long newPhone = Utility.IsLong(Console.ReadLine());
                    array[count].Phone = newPhone;
                    break;
            }

            string json = JsonConvert.SerializeObject(array);
            Utility.WriteJson(json);
            Console.WriteLine("name updated");
        }

        /// <summary>
        /// Sorts this instance.
        /// </summary>
        public static void Sort()
        {
            string file = Utility.ReadJson();
            var array = JsonConvert.DeserializeObject<List<AddressMaintain>>(file);

            int count = 0;

            foreach (var i in array)
            {
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    int result = array[i].FirstName.CompareTo(array[j].FirstName);
                    if (result > 0)
                    {
                        AddressMaintain temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            string json = JsonConvert.SerializeObject(array);
            Utility.WriteJson(json);
        }
    }
}
