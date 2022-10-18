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
            Score = 0;

            foreach (BlackjackCard h in _cards)
            {

                if (h.Face == CardFace.a && Score + h.Value > 21)
                {
                    h.Value = 1;
                }
                else if (h.Face == CardFace.a && Score + h.Value <= 21)
                {
                    h.Value = 11;
                }
                Score += ((BlackjackCard)h).Value;
            }




        }

        public override void Write(int x, int y, ConsoleColor color)
        {
            if (isDealer == true)
            {
                for (int i = 1; i < _cards.Count; i++)
                {
                    if (_cards[1].Suit == CardSuit.spades || _cards[1].Suit == CardSuit.clubs || _cards[1].Suit == CardSuit.hearts || _cards[1].Suit == CardSuit.diamond)
                    {
                        _cards[1].WriteC(x, y, ConsoleColor.White);// i dont get why this doesnt print a white box 
                        Console.ResetColor();
                        Console.Write("          " + "??");
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
                    _cards[1].WriteC(x, y, color);
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
