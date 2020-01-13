// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns
{
    using DesignPatterns.Adapterdesignpattern;
    using DesignPatterns.FacadeDesignPattern;
    using DesignPatterns.FactoryPatterns;
    using DesignPatterns.PrototypeDesignPatterns;
    using System;

    /// <summary>
    /// Main function program
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
            Console.WriteLine("1.Factory patterns\n2.Prototype Pattern\n3.Adapter Pattern\n4.FacadePattern\n5.Regular Expression");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Test test = new Test();
                    Test.TestObj();
                    break;
                case 2:
                    PrototypePattern prototypePattern = new PrototypePattern();
                    PrototypePattern.PrototypePatternObj();
                    break;
                case 3:
                    AdapterPattern adapterPattern = new AdapterPattern();
                    AdapterPattern.AdapterPatternObj();
                    break;
                case 4:
                    FacadePattern facadePattern = new FacadePattern();
                    FacadePattern.FacadePatternObj();
                    break;
                case 5:
                    RegularExpression RegularExpression = new RegularExpression();
                    RegularExpression.RegularExpressionObj();
                    break;
            }
        }
    }
}