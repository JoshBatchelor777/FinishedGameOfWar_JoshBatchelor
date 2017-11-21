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
        public bool canDeal = true;

        // Game constructor.
        // Every game has 2 players.

        public Game(string player1Name, Color p1NameColor, string player2Name, Color p2NameColor)
        {
            _player1 = new Player() { Name = player1Name, NameColor = p1NameColor};
            _player1.PlayerScore = _player1.Cards.Count;
            _player2 = new Player() { Name = player2Name, NameColor = p2NameColor };
            _player2.PlayerScore = _player2.Cards.Count;
        }

        // Something has to be played in a game.
        // Play function for an instance of Game to carry out.
        public string Play()
        {
            Deck deck = new Deck();
            deck.Deal(_player1, _player2);

            if (deck.didDealHappen == true)
                canDeal = false;
            return deck.Deal(_player1, _player2);
        }
    }
}
