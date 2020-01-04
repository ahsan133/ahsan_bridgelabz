// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCards.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Distributing 9 cards to 4 players 
    /// </summary>
    public class DeckOfCards
    {
        /// <summary>
        /// Decks the of cards object.
        /// </summary>
        public static void DeckOfCardsObj()
        {
            string[] suits = { "clubs", "hearts", "spades", "diamonds" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "jack", "queen", "king", "ace" };
            string[,] array = new string[4, 9];
            int k = 0;
            int i = 0;
            int cards = suits.Length * ranks.Length;
            string[] deck = new string[cards];
            for (i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    deck[k++] = ranks[j] + " of " + suits[i];
                }
            }
            
            for (i = 0; i < cards; i++)
            {
                int number = Utility1.RandomInt(0, cards - 1);
                string temp = deck[number];
                deck[number] = deck[i];
                deck[i] = temp;
            }

            i = 0;
            for (int players = 0; players < 4; players++)
            {
                Console.Write("player " + players + ":");
                for (int j = 0; j < 9; j++)
                {
                    array[players, j] = deck[i];
                    k++;
                    i++;
                }

                Console.WriteLine();
            }

            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine("player " + (i + 1) + ":");
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(array[i, j] + " ");
                }
            }
        }
    }
}
