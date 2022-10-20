using BlackjackClassLibrary;
using PG2Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSailCasino
{
    public class BlackjackGame
    {
        protected BlackjackHand _dealer = new BlackjackHand(true);
        protected BlackjackHand _player = new BlackjackHand();
        protected BlackjackDeck _deck = new BlackjackDeck();
        protected int _playerWins;
        protected int _dealerWins;

        public void PlayRound()// more to do
        {

        }

        public void DrawTable(bool reveaal = false)// still more to do
        {

            _player.Clear();
            _dealer.Clear();    
            Console.WriteLine("Players Hands");
            _player.Write(0, 2, ConsoleColor.White);

            Console.SetCursorPosition(0, 4);
            Console.Write("Dealer Hand");
            _dealer.Write(0, 6, ConsoleColor.White);
            DrawWins();
            

        }
        public void DrawWins()
        {
            Console.WriteLine($"Player Wins: {_playerWins}    Dealer Wins: {_dealerWins}");

        }

        public void DealIntialCard()
        {
            Card card = _deck.NextCard();
            _player.AddCard(card);
            Card card2 = _deck.NextCard();
            _dealer.AddCard(card2);
            Card card3 = _deck.NextCard();
            _player.AddCard(card3);
            Card card4 = _deck.NextCard();
            _dealer.AddCard(card4);
        }

        public void PlayersTurn()
        {
            int turn = 0;
            string[] playerOptions = new string[] { "1. Hit", "2. Stand" };

            while(_player.Score < 21)
            {
                Console.WriteLine("Players Hands");
                _player.Write(0, 2, ConsoleColor.White);
                Input.GetMenuChoice("", playerOptions, out turn);
                switch(turn)
                {
                    case 1:
                        _player.AddCard(_deck.NextCard());
                        break;
                    case 2:
                        break;
                }

            }
        }

        public void DealersTurn()
        {
            _dealer.Reveal(0, 6, ConsoleColor.White);
            while(_dealer.Score < 17)
            {
                _dealer.AddCard(_deck.NextCard());
            }

        }

        public void DeclareWinner()
        {
            if (_player.Score > 21)
            {
                _dealerWins++;

            }
            else if (_dealer.Score > 21)
            {
                _playerWins++;
            }
            else if (_player.Score > _dealer.Score)
            {
                _playerWins++;
            }
            else if (_dealer.Score > _player.Score)
            {
                _dealerWins++;
            }
            else if (_player.Score == _dealer.Score)
            {

            }
                                   
        }

    }
}
