// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Deck.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.CardsUsingQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// sorting cards and inserting in queue
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Decks the object.
        /// </summary>
        public static void DeckObj()
        {
            QueueClass<string> queue = new QueueClass<string>();

            string[] suits = { "clubs", "hearts", "spades", "diamonds" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
            int cards = suits.Length * ranks.Length;
            string[] deck = new string[cards];
            int k = 0;
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    deck[k++] = ranks[j] + " of " + suits[i];
                }
            }

            ////shuffling the cards
            for (int i = 0; i < cards; i++)
            {
                int number = Utility.RandomInt(0, cards - 1);
                string temp = deck[number];
                deck[number] = deck[i];
                deck[i] = temp;
            }

            ////sorting the deck and inserting in queue
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    for (k = 0; k < cards; k++)
                    {
                        string[] split = deck[k].Split(" ");
                        if (suits[i] == split[2] && ranks[j] == split[0])
                        {
                            queue.Insert(deck[k]);
                        }
                    }                   
                }
            }

            queue.Print();
        }     
    }
}