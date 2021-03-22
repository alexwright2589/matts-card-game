﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call method to start the program
            DrawCards();

            Console.ReadKey();
        }

        // Short program which deals one card from deck at a time and also shuffles the deck
        private static void DrawCards()
        {
            Deck newDeck = new Deck();

            Console.WriteLine("Would you like to shuffle your deck of cards? (type yes)");
            string option = Console.ReadLine();
            if(option == "yes" || option == "Yes")
            {
                newDeck.Shuffle();
                Console.Clear();
            }

            while(true)
            {
                Console.WriteLine("\nWould you like to draw a card? (type y)");
                string answer = Console.ReadLine();
                if (answer == "yes" || answer == "Yes" || answer == "y")
                {
                    Console.WriteLine("> " + newDeck.Deal());
                }
                else
                {
                    break;
                }
            }
        }
    }
}