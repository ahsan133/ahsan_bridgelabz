// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyShares.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Company_Shares
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Company shares class
    /// </summary>
    public class CompanyShares
    {
        /// <summary>
        /// Prints the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void Print(LinkedListClass<Share> list)
        {
            int count = list.GetCount();
            for (int i = 0; i < count; i++)
            {
                Share b = list.GetAt(i);
                Console.WriteLine("name= " + b.Name);
                Console.WriteLine("shares= " + b.Shares + "\n");
            }
        }

        /// <summary>
        /// Inserts the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void Insert(LinkedListClass<Share> list)
        {
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<Share>>(json);
            Console.WriteLine("enter name of company");
            string name = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter the shares");
            int share = Utility.IsInteger(Console.ReadLine());

            Share obj = new Share();
            obj.Name = name;
            obj.Shares = share;
            list.Insert(obj);
            array.Add(obj);

            string file = JsonConvert.SerializeObject(array);
            Utility.WriteJson(file);
        }

        /// <summary>
        /// Removes the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void Remove(LinkedListClass<Share> list)
        {
            int count = 0;
            Console.WriteLine("enter the company name to remove");
            string name = Utility.IsString(Console.ReadLine());
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<Share>>(json);
            foreach (var i in array)
            {
                if (Equals(i.Name, name))
                {
                    break;                   
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            list.Remove(count);
            array.RemoveAt(count);

            string file = JsonConvert.SerializeObject(array);
            Utility.WriteJson(file);
        }

        /// <summary>
        /// Companies the shares object.
        /// </summary>
        public static void CompanySharesObj()
        {
            LinkedListClass<Share> list = new LinkedListClass<Share>();
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<Share>>(json);
            foreach (var i in array)
            {
                list.Insert(i);
            }

            CompanyShares.Print(list);

            Console.WriteLine("enter the operation to perform");
            Console.WriteLine("1.add\n2.remove");
            int operation = Utility.IsInteger(Console.ReadLine());
            while (operation != 1 && operation != 2)
            {
                Console.WriteLine("enter valid operation to perform");
                operation = Utility.IsInteger(Console.ReadLine());
            }

            switch (operation)
            {
                case 1:
                    CompanyShares.Insert(list);
                    break;
                case 2:
                    CompanyShares.Remove(list);
                    break;
                default:
                    break;
            }
            
            CompanyShares.Print(list);
        }
    }
}
