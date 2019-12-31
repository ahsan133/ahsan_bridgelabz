// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Main program
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
            Console.WriteLine("1.2D Array\n2.sum of three\n3.Distance\n4.Quadratic\n5.Windchill");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TwoDArray twoDArray = new TwoDArray();
                    TwoDArray.TwoDArrayObj();
                    break;
                case 2:
                    SumOfThree sumOfThree = new SumOfThree();
                    SumOfThree.SumOfThreeObj();
                    break;
                case 3:
                    Distance distance = new Distance();
                    Distance.DistanceObj();
                    break;
                case 4:
                    Quadratic quadratic = new Quadratic();
                    Quadratic.QuadraticObj();
                    break;
                case 5:
                    WindChill windChill = new WindChill();
                    WindChill.WindChillObj();
                    break;
                default:
                    break;
            }
        }
    }
}
