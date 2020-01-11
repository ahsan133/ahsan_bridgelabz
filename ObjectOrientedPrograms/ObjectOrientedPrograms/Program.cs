// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using ObjectOrientedPrograms.CardsUsingQueue;
    using ObjectOrientedPrograms.StockAccountManagement;
    using ObjectOrientedPrograms.Company_Shares;
    using ObjectOrientedPrograms.Address_Book;
    using System;
    using ObjectOrientedPrograms.Commerercial_data_processing;

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
            Console.WriteLine("1.Data Management\n2.Inventory Management\n3.Deck Of Cards\n4.Address Book\n5.Company Shares\n6.Stock Account\n" +
                "7.Deck of cards using queue\n8.Commercial data  processing");
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
                case 4:
                    AddressBook addressBook = new AddressBook();
                    AddressBook.AddressBookObj();
                    break;
                case 5:
                    CompanyShares CompanyShares = new CompanyShares();
                    CompanyShares.CompanySharesObj();
                    break;
                case 6:
                    StockAccount stockAccount = new StockAccount();
                    StockAccount.StockAccountObj();
                    break;
                case 7:
                    Deck deck = new Deck();
                    Deck.DeckObj();
                    break;
                case 8:
                    StockData stockData = new StockData();
                    StockData.StockDataObj();
                    break;

                default:
                    break;
            }
        }
    }
}
