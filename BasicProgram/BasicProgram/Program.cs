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
                    leapYear.Leap();
                    break;
                case 2:
                    PowerOfTwo PowerOfTwo = new PowerOfTwo();
                    PowerOfTwo.Power();
                    break;
                case 3:
                    HarmonicNumber HarmonicNumber = new HarmonicNumber();
                    HarmonicNumber.harmonic();
                    break;
                case 4:
                    FlipCoin FlipCoin = new FlipCoin();
                    FlipCoin.flipcoin();
                    break;
                case 5:
                    PrimeFactors PrimeFactors = new PrimeFactors();
                    PrimeFactors.factors();
                    break;
                case 6:
                    Hello Hello = new Hello();
                    Hello.hello();
                    break;
                default :
                    break;
            }





        }
    }
}
