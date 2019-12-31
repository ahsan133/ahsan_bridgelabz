// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace BasicProgram
{
    using System;
    using BasicPrograms;
    
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
            Console.WriteLine("1.leap year\n2.Power Of Two\n3.Harmonic number\n4.Flip coin\n5.Prime factors\n6.Hello");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LeapYear leapYear = new LeapYear();
                    LeapYear.LeapYearObj();
                    break;
                case 2:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    PowerOfTwo.PowerOfTwoObj();
                    break;
                case 3:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    HarmonicNumber.HarmonicNumberObj();
                    break;
                case 4:
                    FlipCoin flipCoin = new FlipCoin();
                    FlipCoin.FlipCoinObj();
                    break;
                case 5:
                    PrimeFactors primeFactors = new PrimeFactors();
                    PrimeFactors.PrimeFactorsObj();
                    break;
                case 6:
                    Hello hello = new Hello();
                    Hello.HelloObj();
                    break;
                default:
                    break;
            }
        }
    }
}
