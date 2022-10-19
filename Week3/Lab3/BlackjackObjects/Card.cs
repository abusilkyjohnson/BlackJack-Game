using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class Card
    {
        #region properties
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }
        #endregion

        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
           
        }

        public void WriteC(int x, int y, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = color;
            Console.ForegroundColor = ConsoleColor.Red;
            switch (Face)
            {
                case CardFace.a:
                    Console.Write("A");
                    break;
                case CardFace.two:
                    Console.Write("2");
                    break;
                case CardFace.three:
                    Console.Write("3");
                    break;
                case CardFace.four:
                    Console.Write("4");
                    break;
                case CardFace.five:
                    Console.Write("5");
                    break;
                case CardFace.six:
                    Console.Write("6");
                    break;
                case CardFace.seven:
                    Console.Write("7");
                    break;
                case CardFace.eight:
                    Console.Write("8");
                    break;
                case CardFace.nine:
                    Console.Write("9");
                    break;
                case CardFace.ten:
                    Console.Write("10");
                    break;
                case CardFace.j:
                    Console.Write("J");
                    break;
                case CardFace.q:
                    Console.Write("Q");
                    break;
                case CardFace.k:
                    Console.Write("K");
                    break;
                default:
                    break;


            }
            switch (Suit)
            {
                case CardSuit.spades:
                    Console.Write("\u2660");
                    break;
                case CardSuit.hearts:
                    Console.Write("\u2665");
                    break;
                case CardSuit.clubs:
                    Console.Write("\u2663");
                    break;
                case CardSuit.diamond:
                    Console.Write("\u2666");
                    break;
                default:
                    break;
            }
        }
    }
}
