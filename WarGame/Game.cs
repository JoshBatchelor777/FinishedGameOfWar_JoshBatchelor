using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    // A game has 2 players.
    // Something has to be played in a game.
    // Game Class should construct how a game should be.
    public class Game
    {
        // A game has 2 players.
        public Player _player1 { get; set; }
        public Player _player2 { get; set; }
        public string GetResult { get; set; }

        // Game constructor.
        // Every game has 2 players.
        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };
        }

        // Something has to be played in a game.
        // Play function for an instance of Game to carry out.
        public string Play()
        {
            // Deal the new "deck" instance.
            Deck deck = new Deck();
            deck.Deal(_player1, _player2);

            string result = deck.Deal(_player1, _player2);

            // Below are the Battle mechanics per comparison of 2 cards.
            int round = 0; // Limit game length to rounds.
            while (_player1.Cards.Count != 0 && _player2.Cards.Count != 0)
            {
                Battle battle = new Battle();
                result += battle.performBattle(_player1, _player2);

                round++;
                if (round > 40)
                    break;
            }
            // Determine the winner
            result += determineWinner();
            GetResult += determineWinner();
            GetResult += "That game took " + round + " rounds!\n";
            return result;
        }

        public string determineWinner()
        {
            string result = "";
            if (_player1.Cards.Count > _player2.Cards.Count)
            {
                result = "Player 1 Wins!\n";
            }

            else
            {
                result = "Player 2 Wins!\n";
            }

            return result;
        }


    }
}
