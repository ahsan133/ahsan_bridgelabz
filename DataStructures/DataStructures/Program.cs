// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.UnorderedList\n2.OrderedList");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    UnorderedList UnorderedList = new UnorderedList();
                    UnorderedList.UnorderedListObj();
                    break;
                case 2:
                    OrderedList OrderedList = new OrderedList();
                    OrderedList.OrderedListObj();
                    return;
                default:
                    break;
            }
        }
    }
}