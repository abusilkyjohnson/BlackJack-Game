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
        public List<Card>  _cards = new List<Card>();
        #endregion

        public Deck()
        {
            CreateAllCards();
        }


        public virtual void CreateAllCards()
        {
            Card deckL = null;

            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                   deckL = (CardFactory.CreateCard((CardFace)i, (CardSuit)j));
                    _cards.Add(deckL);

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
                temp = _cards[cardRando];
                _cards[cardRando] = _cards[n - 1];
                _cards[n - 1] = temp;
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
                x += 4;
                if (i == _cards.Count - 1)
                {
                    Console.Write("");
                }
                if(i % 7 == 0 && i != 0)
                {
                    y += 2;
                    x = 0;
                }

            }




        }


    }
}
