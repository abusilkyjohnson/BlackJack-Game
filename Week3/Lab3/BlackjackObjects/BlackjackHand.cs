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

                base.Write(x, y, color);
                Console.ResetColor();
                color = ConsoleColor.White;
                Console.ResetColor();
                Console.Write("     " + "??");
                Console.ResetColor();


            }
            else
            {
                base.Write(x, y, color);
                Console.ResetColor();
                Console.Write("  " + Score);
            }
            base.Write(x, y, color);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 4);
            Console.Write("0000");
        }

        public override void Clear()
        {
            base.Clear();
            Score = 0;
        }

        public void Reveal(int x, int y, ConsoleColor color)
        {
            if (isDealer == true)
            {
                for (int i = 1; i < _cards.Count; i++)
                {
                    base.Write(x, y, color);
                    x += 4;
                }

            }
            else
            {
                for (int i = 1; i < _cards.Count; i++)
                {
                    base.Write(x + 5, y, color);
                    x += 4;

                }
            }
            Console.ResetColor();
            Console.Write("  " + Score);
        }
    }
}
