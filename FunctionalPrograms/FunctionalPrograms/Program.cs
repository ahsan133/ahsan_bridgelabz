// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.2D Array\n2.sum of three\n3.Distance\n4.Quadratic\n5.Windchill");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TwoDArray TwoDArray = new TwoDArray();
                    TwoDArray.twodarray();
                    break;
                case 2:
                    SumOf3 SumOf3 = new SumOf3();
                    SumOf3.sumof3();
                    break;
                case 3:
                    Distance Distance = new Distance();
                    Distance.distance();
                    break;
                case 4:
                    Quadratic Quadratic = new Quadratic();
                    Quadratic.quad();
                    break;
                case 5:
                    WindChill WindChill = new WindChill();
                    WindChill.wind();
                    break;
                default:
                    break;
            }
        }
    }
}
