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
        protected BlackjackHand _dealer;
        protected BlackjackHand _player;
        protected BlackjackDeck _deck;
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
            if (_player.Score != 21 && _dealer.Score != 21)
            {

                PlayersTurn();
                DealersTurn();
                DrawTable(true);
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

            // dealer section
            Console.SetCursorPosition(10, 2);
            Console.Write("Dealer Hand");
            if (reveaal == true)
            {
                _dealer.Reveal(10, 4, ConsoleColor.White);
            }
            else if (reveaal == false)
            {
                _dealer.Write(10, 4, ConsoleColor.White);
            }

            // player section

            Console.ResetColor();

            Console.SetCursorPosition(10, 8);
            Console.Write("Player Hand");
            _player.Write(10, 10, ConsoleColor.White);


            Console.SetCursorPosition(0, 20);
            DrawWins();
            Console.ResetColor();
        }
        public void DrawWins()
        {
            Console.ResetColor();
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

            while (turn != 2)
            {
                Console.WriteLine("Players Hands");
                Input.GetMenuChoice("", playerOptions, out turn);
                switch (turn)
                {
                    case 1:
                        _player.AddCard(_deck.NextCard());
                        DrawTable();
                        break;
                    case 2:
                        break;
                }

            }
        }

        public void DealersTurn()
        {
            _dealer.Write(0, 6, ConsoleColor.White);
            while (_dealer.Score < 17)
            {
                _dealer.AddCard(_deck.NextCard());
                DrawTable();
            }

        }

        public void DeclareWinner()
        {
            Console.SetCursorPosition(40, 10);
            if (_player.Score > 21)
            {
                Console.WriteLine("Dealer WINS");
                _dealerWins++;
            }
            else if (_dealer.Score > 21)
            {
                Console.WriteLine("Player WINS");
                _playerWins++;
            }
            else if (_player.Score > _dealer.Score)
            {
                Console.WriteLine("Player WINS");
                _playerWins++;
            }
            else if (_dealer.Score > _player.Score)
            {
                Console.WriteLine("Dealer WINS");
                _dealerWins++;
            }
            else if (_player.Score == _dealer.Score) { }
            Console.ReadKey();


        }

    }
}
