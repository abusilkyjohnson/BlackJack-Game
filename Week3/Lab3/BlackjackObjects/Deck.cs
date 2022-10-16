using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class Deck
    {
        #region Fields
        List<Card> _cards = new List<Card>();
        #endregion

        public Deck()
        {
            CreateAllCards();
        }


        public void CreateAllCards()
        {

            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    CardFactory.CreateCard((CardFace)i, (CardSuit)j);
                }
            }


        }

        public Card NextCard()
        {
            Card anotherOne = _cards.First();
            _cards.Remove(anotherOne);
            if (_cards.Count == 0)
            {
                CreateAllCards();
            }
            return anotherOne;

        }



        public void Shuffle()
        {
            int n = _cards.Count;
            Random random = new Random();
            int cardRando = 0;
            Card temp;
            for (int i = 0; i < n; i++)
            {
                cardRando = random.Next(0, 51);
                temp = _cards[i];
                Card card = _cards[cardRando];
                _cards[i] = card;
                card = temp;


            }
        }

        public void WriteD(ConsoleColor color)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color;
            List<Card> clone4Deck = _cards.ToList();
            int x = 0;
            int y = 0;

            for (int i = 0; i < _cards.Count; i++)
            {
                _cards[i].WriteC(x, y, color);
                x += 2;
                if (i == _cards.Count - 1)
                {
                    Console.Write(" ");
                }


            }




        }


    }
}
