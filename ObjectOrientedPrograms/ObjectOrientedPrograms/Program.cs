// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
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
            Console.WriteLine("1.Data Management\n2.Inventory Management\n3.Deck Of Cards");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DataManagement dataManagement = new DataManagement();
                    DataManagement.DataManagementObj();
                    break;
                case 2:
                    InventoryManagement inventoryManagement = new InventoryManagement();
                    InventoryManagement.InventoryManagementObj();
                    break;
                case 3:
                    DeckOfCards deckOfCards = new DeckOfCards();
                    DeckOfCards.DeckOfCardsObj();
                    break;
                default:
                    break;
            }
        }
    }
}
