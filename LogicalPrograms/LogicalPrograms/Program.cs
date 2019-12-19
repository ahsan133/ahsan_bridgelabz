// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------

using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.Gambler\n2.Coupon number\n3.TicTacToe\n4.Stop watch");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Gambler Gambler = new Gambler();
                    Gambler.GamblerObj();
                    break;
                case 2:
                    CouponNumbers CouponNumbers = new CouponNumbers();
                    CouponNumbers.CouponNumbersObj();
                    break;
                case 3:
                    TicTacToe TicTacToe = new TicTacToe();
                    TicTacToe.TicTacToeObj();
                    break;
                case 4:
                    StopWatch StopWatch = new StopWatch();
                    StopWatch.StopWatchObj();
                    break;
                default:
                    break;

            }
        }
    }
}
