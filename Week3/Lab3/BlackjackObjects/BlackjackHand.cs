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
            int aceCounter = 0;
            foreach (BlackjackCard h in _cards)
            {
                Score += h.Value;
                if (h.Face == CardFace.a)
                {
                    aceCounter++;
                }
            }
            while (Score > 21 && aceCounter > 0)
            {
                Score -= 10;
                aceCounter--;
            }

        }

        public override void Write(int x, int y, ConsoleColor color)
        {
            int posX = x;
            int posY = y;

            if (isDealer == true)
            {

                for (int i = 0; i < _cards.Count; i++)
                {

                    if (i == 0)
                    {
                        Console.SetCursorPosition(posX, posY);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[?????]");
                    }
                    else
                    {
                        _cards[i].WriteC(posX, posY, color);
                    }

                    posX += 7;

                }
            }
            else
            {
                //players hand
                base.Write(x, y, color);
                Console.SetCursorPosition(x, y + 2);
                Console.ResetColor();
                Console.Write(" Player Score " + Score);
            }

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


                isDealer = false;
                base.Write(x, y, color);
                isDealer = true;

            }
            else
            {

                base.Write(x + 5, y, color);


                Console.ResetColor();
                Console.Write(" Score When Reveal Called  " + Score);
            }
        }
    }
}
