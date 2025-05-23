﻿using System;
using PG2Input;
using BlackjackClassLibrary;
using System.Collections.Generic;
using FullSailCasino;

namespace Lab3
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("\u2663 club");
            //Console.WriteLine("\u2660 spades");
            //Console.WriteLine("\u2666 diamond");
            //Console.WriteLine("\u2665 heaarts");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.CursorLeft = 1;
            //Console.Write("A");
            //Console.Write(" ".PadRight(40));

            //Card abu2 = new Card(CardFace.a, CardSuit.diamond);
            //abu2.Write(6,5, ConsoleColor.Red);
            //Card sadiq = new Card(CardFace.five, CardSuit.spades);
            //sadiq.Write(7,6, ConsoleColor.Red);
            //Console.ReadLine();

            string[] playOptions = new string[] { "1. Sample Card", "2. Shuffle and Show Deck", "3. Sample Blackjack", "4. Play Blackjack", "5. Exit" };
            int selection = 0;

            while (selection != 5)
            {
                Input.GetMenuChoice("", playOptions, out selection);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Card sample = new Card(CardFace.a, CardSuit.diamond);
                        sample.WriteC(14, 4, ConsoleColor.White);
                        Console.ResetColor();
                        break;

                    case 2:
                        Deck deckC2 = new Deck();
                        deckC2.Shuffle();
                        deckC2.WriteD(ConsoleColor.White);
                        Console.ResetColor();
                        break;
                    case 3:
                        BlackjackDeck blackjackDeckC3  = new BlackjackDeck();
                        blackjackDeckC3.Shuffle();
                        BlackjackHand blackjackHandPlayer = new BlackjackHand();
                        BlackjackHand blackjackHandDealer = new BlackjackHand(true);
                       
                        blackjackHandPlayer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandPlayer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandPlayer.Write(0, 0, ConsoleColor.White);
                        
                        blackjackHandDealer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandDealer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandDealer.Write(0, 4, ConsoleColor.White);
                        Console.ResetColor();
                        break;
                    case 4:
                        //TBA
                        BlackjackGame game = new BlackjackGame();
                        string[] playOrNo = { "1. Yes ", "2. No" };
                        int choice = 0;
                        Input.GetMenuChoice("", playOrNo, out choice);

                        while (choice != 2)
                        {
                            game.PlayRound();
                            Console.ResetColor();
                        }


                        break;

                }
                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
