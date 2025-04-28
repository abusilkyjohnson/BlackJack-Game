using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class BlackjackDeck : Deck
    {
        public override void CreateAllCards()
        {

            
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Card deckL = (CardFactory.CreateBlackjackCard((CardFace)i, (CardSuit)j));
                    _cards.Add(deckL);

                }
            }
        }
    }
}
