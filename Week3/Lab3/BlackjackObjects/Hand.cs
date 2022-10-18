using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class Hand
    {
            #region fields        
            protected List<Card> _cards = new List<Card>();

            #endregion
        
        public virtual void AddCard(Card addH)
        {
             _cards.Add(addH);

        }

        public virtual void Write(int x, int y, ConsoleColor color)
        {

            int startX = x;
            int startY = y;

            foreach(Card c in _cards)
            {
                c.WriteC(startX, startY, color);
                startX += 7;
            }
        }

        public virtual void Clear()

        {
            _cards.Clear();
        }
    }
}
