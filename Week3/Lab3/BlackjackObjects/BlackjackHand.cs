using System;
using System.Collections.Generic;

namespace BlackjackClassLibrary
{
    public class BlackjackHand : Hand
    {
        #region Properties
        public int Score { get; private set; }
        public bool isDealer { get; set; }
        #endregion

        //public Blackjackhand(bool isDealer = false)
        //{
        //    this.isDealer = isDealer;
        //}

        public BlackjackHand(bool isDealer = false)
        {
            this.isDealer = isDealer;
        }

        public override void AddCard(Card addH)
        {
            base.AddCard(addH);
            CalculateScore();
        }

        public void CalculateScore()
        {
            int score = Score;
            List<Card> hand = _cards;
            for (int i = 0; i < hand.Count; i++)
            {
                foreach (BlackjackCard h in hand)
                {
                    if (h.Face == CardFace.a && score + h.Value > 21)
                    {
                        h.Value = 1;
                    }
                    else if (h.Face == CardFace.a && score + h.Value <= 21)
                    {
                        h.Value = 11;
                    }
                    Score += h.Value;
                }
                
            }
        }

        public override void Write(int x, int y, ConsoleColor color)
        {
            if (isDealer == true)
            {
                for (int i = 0; i < _cards.Count; i++)
                {
                    if (_cards[0].Suit == CardSuit.spades || _cards[0].Suit == CardSuit.clubs || _cards[0].Suit == CardSuit.hearts || _cards[0].Suit == CardSuit.diamond)
                    {
                        _cards[0].WriteC(x, y, ConsoleColor.White);
                        Console.ResetColor();
                        Console.WriteLine("          " + Score);
                    }
                }
            }
            else
            {
                base.Write(x, y, color);
                Console.ResetColor();
                Console.WriteLine("  " + Score);
            }
            base.Write(x, y, color);
        }

        public override void Clear()
        {
            base.Clear();
        }

        public void Reveal(int x, int y, ConsoleColor color)
        {
            if (isDealer == true)
            {
                isDealer = false;
                for (int i = 1; i < _cards.Count; i++)
                {
                    _cards[i].WriteC(x, y, color);
                    x += 4;
                }

            }
            else
            {
                for (int i = 1; i < _cards.Count; i++)
                {
                    _cards[i].WriteC(x, y, color);
                    x += 4;

                }
            }
        }
    }
}
