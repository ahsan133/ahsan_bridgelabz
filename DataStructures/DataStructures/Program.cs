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
            Console.WriteLine("1.UnorderedList\n2.OrderedList\n3.Balanced Parenthesis\n4.Banking Cash Counter\n5.Palindrome Checker");
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
                case 3:
                    BalancedParenthesis BalancedParenthesis = new BalancedParenthesis();
                    BalancedParenthesis.BalancedParenthesisObj();
                    return;
                case 4:
                    BankingCashCounter BankingCashCounter = new BankingCashCounter();
                    BankingCashCounter.BankingCashCounterObj();
                    return;
                case 5:
                    PalindromeChecker PalindromeChecker = new PalindromeChecker();
                    PalindromeChecker.PalindromeCheckerObj();
                    return;
                default:
                    break;
            }
        }
    }
}