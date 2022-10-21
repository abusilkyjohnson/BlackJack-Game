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
        protected BlackjackHand _dealer = new BlackjackHand();
        protected BlackjackHand _player = new BlackjackHand();
        protected BlackjackDeck _deck = new BlackjackDeck();
        protected int _playerWins;
        protected int _dealerWins;

        public void PlayRound()
        {
            _dealer = new BlackjackHand(true);
            _player = new BlackjackHand();
            _deck = new BlackjackDeck();
            
            _deck.Shuffle();
            DealIntialCard();
            DrawTable();
            if (_player.Score != 21 || _dealer.Score != 21)
            {

                PlayersTurn();
                DealersTurn();
                DeclareWinner();

            }
            else
            {
                DeclareWinner();
            }

        }

        public void DrawTable(bool reveaal = false)// still more to do
        {
            Console.ResetColor();
            
                Console.Clear();
                _player.Clear();
                _dealer.Clear();
                Console.SetCursorPosition(10, 10);
                Console.Write("Players Hand");
                _player.Write(10, 14, ConsoleColor.White);

                Console.SetCursorPosition(10, 4);
                Console.Write("Dealer Hand");
                _dealer.Write(10, 2, ConsoleColor.White);

            
            Console.SetCursorPosition(0, 20);
            DrawWins();
        }
        public void DrawWins()
        {
            Console.WriteLine($"Player Wins: {_playerWins}    Dealer Wins: {_dealerWins}");

        }

        public void DealIntialCard()
        {
            
            _deck.Shuffle();
            _player.AddCard(_deck.NextCard());
            _dealer.AddCard(_deck.NextCard());
            _player.AddCard(_deck.NextCard());
            _dealer.AddCard(_deck.NextCard());
            DrawTable();
        }

        public void PlayersTurn()
        {
            int turn = 0;
            string[] playerOptions = new string[] { "1. Hit", "2. Stand" };

            while(_player.Score < 21)
            {
                Console.WriteLine("Players Hands");
                Input.GetMenuChoice("", playerOptions, out turn);
                switch(turn)
                {
                    case 1:
                        _player.AddCard(_deck.NextCard());
                        DrawTable();
                        break;
                    case 2:
                        DrawTable();
                        break;
                }

            }
        }

        public void DealersTurn()
        {
            _dealer.Write(0, 6, ConsoleColor.White);
            while(_dealer.Score < 17)
            {
                _dealer.AddCard(_deck.NextCard());
                DrawTable();
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
            else if (_player.Score == _dealer.Score) { }
                                   
        }

    }
}
