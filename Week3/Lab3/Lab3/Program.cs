using System;
using PG2Input;
using BlackjackClassLibrary;
using System.Collections.Generic;

namespace Lab3
{
    //
    //------------Lab 3 Notes-------------
    //      Add your classes to the BlackjackClassLibrary project.
    //      Add the menu code to the Main method.
    //


    //
    //------------Lab 4 Notes-------------
    //      This project and file will be reused for lab 4. 
    //      When you start working on lab 4...
    //          Add your BlackjackGame class to the FullSailCasino project.
    //          update the menu code for Play Blackjack menu option
    //

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
                        sample.WriteC(14, 4, ConsoleColor.Red);
                        Console.ResetColor();
                        break;

                    case 2:
                        Deck deckC2 = new Deck();
                        deckC2.Shuffle();
                        deckC2.WriteD(ConsoleColor.Red);
                        Console.ResetColor();
                        break;
                    case 3:
                        BlackjackDeck blackjackDeckC3  = new BlackjackDeck();
                        blackjackDeckC3.Shuffle();
                        BlackjackHand blackjackHandPlayer = new BlackjackHand();
                        BlackjackHand blackjackHandDealer = new BlackjackHand(true);
                       
                        blackjackHandPlayer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandPlayer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandPlayer.Write(0, 0, ConsoleColor.Red);
                        
                        blackjackHandDealer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandDealer.AddCard(blackjackDeckC3.NextCard());
                        blackjackHandDealer.Write(0, 4, ConsoleColor.Red);


                        Console.ResetColor();
                        break;
                    case 4:
                        //TBA
                        break;

                }
                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
