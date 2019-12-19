// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using BasicPrograms;
using System;

namespace BasicProgram
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.leap year\n2.Power Of Two\n3.Harmonic number\n4.Flip coin\n5.Prime factors\n6.Hello");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    leapYear leapYear = new leapYear();
                    leapYear.LeapYearObj();
                    break;
                case 2:
                    PowerOfTwo PowerOfTwo = new PowerOfTwo();
                    PowerOfTwo.PowerOfTwoObj();
                    break;
                case 3:
                    HarmonicNumber HarmonicNumber = new HarmonicNumber();
                    HarmonicNumber.HarmonicNumberObj();
                    break;
                case 4:
                    FlipCoin FlipCoin = new FlipCoin();
                    FlipCoin.FlipCoinObj();
                    break;
                case 5:
                    PrimeFactors PrimeFactors = new PrimeFactors();
                    PrimeFactors.PrimeFactorsObj();
                    break;
                case 6:
                    Hello Hello = new Hello();
                    Hello.HelloObj();
                    break;
                default :
                    break;
            }





        }
    }
}
