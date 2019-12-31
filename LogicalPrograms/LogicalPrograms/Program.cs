// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace LogicalPrograms
{
    using System;

    /// <summary>
    /// Main function
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.Gambler\n2.Coupon number\n3.TicTacToe\n4.Stop watch");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Gambler gambler = new Gambler();
                    Gambler.GamblerObj();
                    break;
                case 2:
                    CouponNumbers couponNumbers = new CouponNumbers();
                    CouponNumbers.CouponNumbersObj();
                    break;
                case 3:
                    TicTacToe ticTacToe = new TicTacToe();
                    TicTacToe.TicTacToeObj();
                    break;
                case 4:
                    StopWatch stopWatch = new StopWatch();
                    StopWatch.StopWatchObj();
                    break;
                default:
                    break;
            }
        }
    }
}
