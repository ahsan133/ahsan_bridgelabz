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
        /// Buying the shares and storing in stack
        /// </summary>
        /// <param name="stack"></param>
        public static void Buy(StackClass<int> stack)
        {
            Console.WriteLine("enter company name");
            string name = Utility.IsString(Console.ReadLine());
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<Share>>(json);
            int count = 0;
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

            Console.WriteLine("how many shares do you want to buy?");
            int buy = Utility.IsInteger(Console.ReadLine());
            while (array[count].Shares < buy || buy < 0)
            {
                Console.WriteLine("not enough shares\nenter valid shares to buy");
                buy = Utility.IsInteger(Console.ReadLine());
            }

            stack.Push(buy);
            array[count].Shares -= buy;
            string file = JsonConvert.SerializeObject(array);
            Utility.WriteJson(file);
        }

        /// <summary>
        /// selling the shares and storing in stack
        /// </summary>
        /// <param name="stack"></param>
        public static void Sell(StackClass<int> stack)
        {
            Console.WriteLine("enter company name");
            string name = Utility.IsString(Console.ReadLine());
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<Share>>(json);
            int count = 0;
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

            Console.WriteLine("how many shares do you want to sell?");
            int sell = Utility.IsInteger(Console.ReadLine());
            stack.Push(sell);
            array[count].Shares += sell;
            string file = JsonConvert.SerializeObject(array);
            Utility.WriteJson(file);
        }

        /// <summary>
        /// Companies the shares object.
        /// </summary>
        public static void CompanySharesObj()
        {
            StackClass<int> stack = new StackClass<int>();
            LinkedListClass<Share> list = new LinkedListClass<Share>();
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<Share>>(json);
            foreach (var i in array)
            {
                list.Insert(i);
            }

            CompanyShares.Print(list);

            Console.WriteLine("enter the operation to perform");
            Console.WriteLine("1.add\n2.remove\n3.Buy\n4.Sell");
            int operation = Utility.IsInteger(Console.ReadLine());
            while (operation != 1 && operation != 2 && operation != 3 && operation != 4)
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
                case 3:
                    CompanyShares.Buy(stack);
                    break;
                case 4:
                    CompanyShares.Sell(stack);
                    break;
                default:
                    break;
            }

            string file = Utility.Readjson();
            var files = JsonConvert.DeserializeObject<List<Share>>(file);
            foreach (var i in files)
            {
                Console.WriteLine("name= :" + i.Name);
                Console.WriteLine("shares= :" + i.Shares);
                Console.WriteLine();
            }

            Console.WriteLine("no of shares bought and sold:");
            stack.Print(); 
        }
    }
}
