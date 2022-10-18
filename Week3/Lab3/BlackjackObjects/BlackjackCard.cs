using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class BlackjackCard : Card
    {
        public int Value { get; set; }
        public BlackjackCard(CardFace face, CardSuit suit) : base(face, suit)
        {
            CalculateValue();
        }

        public void CalculateValue()
        {
            switch (Face)
            {
                case CardFace.a:
                    Value = 1;
                    break;
                case CardFace.two:
                    Value = 2;
                    break;
                case CardFace.three:
                    Value = 3;
                    break;
                case CardFace.four:
                    Value = 4;
                    break;
                case CardFace.five:
                    Value = 5;
                    break;
                case CardFace.six:
                    Value = 6;
                    break;
                case CardFace.seven:
                    Value = 7;
                    break;
                case CardFace.eight:
                    Value = 8;
                    break;
                case CardFace.nine:
                    Value = 9;
                    break;
                case CardFace.ten:
                    Value = 10;
                    break;
                case CardFace.j:
                    Value = 10;
                    break;
                case CardFace.q:
                    Value = 10;
                    break;
                case CardFace.k:
                    Value = 10;
                    break;

            }
        }
    }
}
