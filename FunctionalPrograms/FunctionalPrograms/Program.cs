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
                    TwoDArray.TwoDArrayObj();
                    break;
                case 2:
                    SumOfThree SumOfThree = new SumOfThree();
                    SumOfThree.SumOfThreeObj();
                    break;
                case 3:
                    Distance Distance = new Distance();
                    Distance.DistanceObj();
                    break;
                case 4:
                    Quadratic Quadratic = new Quadratic();
                    Quadratic.QuadraticObj();
                    break;
                case 5:
                    WindChill WindChill = new WindChill();
                    WindChill.WindChillObj();
                    break;
                default:
                    break;
            }
        }
    }
}
