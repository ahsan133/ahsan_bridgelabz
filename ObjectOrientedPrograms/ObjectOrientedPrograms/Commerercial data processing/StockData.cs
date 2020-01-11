// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Commerercial_data_processing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Stock data class
    /// </summary>
    public class StockData
    {
        /// <summary>
        /// Stocks the data object.
        /// </summary>
        public static void StockDataObj()
        {
            Company[] file = Utility.ReadCompany();
            foreach (var i in file)
            {
                Console.WriteLine("name= " + i.Name);
                Console.WriteLine("no of shares= " + i.Shares);
                Console.WriteLine("share price= " + i.SharePrice);
                Console.WriteLine("symbol= " + i.Symbol);
                Console.WriteLine();
            }

            Console.WriteLine("enter operation");
            Console.WriteLine("1.Buy\n2.Sell");
            int operation = Utility.IsInteger(Console.ReadLine());
            while (operation != 1 && operation != 2)
            {
                Console.WriteLine("enter valid operation");
                operation = Utility.IsInteger(Console.ReadLine());
            }

            switch (operation)
            {
                case 1:
                    StockData.Buy();
                    break;
                case 2:
                    StockData.Sell();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Buys this instance.
        /// </summary>
        public static void Buy()
        {
          
            Console.WriteLine("enter your name");
            string memberName = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter company name");
            string name = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter number of shares to buy");
            int share = Utility.IsInteger(Console.ReadLine());
            Company[] file = Utility.ReadCompany();
            int count = 0;
            foreach (var i in file)
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

            file[count].Shares -= share;

            List<Member> array = Utility.ReadMember();
            Member obj = new Member();
            obj.Name = memberName;
            obj.SharesBought = share;
            obj.Symbol = file[count].Symbol;
            obj.Datetime = DateTime.Now;
            List<Member> list = new List<Member>();
            if (array != null)
            {
                foreach (var i in array)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(i.Name);
                    list.Add(obj);
                }
            }
            else
            {
                list.Add(obj);
            }
            

            Utility.WriteCompany(file);
            Utility.WriteMember(list);
        }

        /// <summary>
        /// Sells this instance.
        /// </summary>
        public static void Sell()
        {
            Console.WriteLine("enter company name");
            string name = Utility.IsString(Console.ReadLine());
            Console.WriteLine("enter number of shares to sell");
            int share = Utility.IsInteger(Console.ReadLine());
            Company[] file = Utility.ReadCompany();
            int count = 0;
            foreach (var i in file)
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

            file[count].Shares += share;

            Utility.WriteCompany(file);
        }
    }
}