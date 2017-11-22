using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame
{
    // A deck contains Cards of several different types.
    // Deck Class will contain these cards in a list.
    // Cards are randomized in the Deck.
    // Player Class should assign 26 random cards to a player
    // when "Deal" button is pressed & print their quantity to
    // "Player 1 Cards" group box.
    public class Deck
    {
        private List<Card> _deck = new List<Card>(); // _deck is a List of type: Card. A list of suit and kind properties.
        private Random _random = new Random();
        private StringBuilder _sb = new StringBuilder();

        // A constructor for how a Deck should be.
        public Deck()
        {
            // Invoke properties to apply to the constructor.
            _deck = new List<Card>();
            _random = new Random();
            _sb = new StringBuilder();

            // Construct how Cards should look via arrays.
            string[] suit = new string[] { "Diamonds", "Spades", "Hearts", "Clubs" };
            string[] kind = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "Jack", "Queen", "King", "Ace" }; // Numbers and Face cards and Ace.

            // Here a deck is constructed.
            // Do this for each of the 4 suits.
            foreach (var suits in suit)
            {
                foreach (var kinds in kind)
                {
                    // Add Cards, new instance of a Card. Cards have a suit and a kind. 
                    _deck.Add(new Card { Suit = suits, Kind = kinds}); // Card properties = the iterative object (suits / kinds).
                }
            }
        }

        public bool didDealHappen = true;

        // Deal cards function to be called by "Deal" button.
        // A deal function should deal to players, so pass 2 instances of a Player.
        public string Deal(Player _player1, Player _player2)
        {
            // Maintain the count of cards.
            // While there are still cards in the deck, invoke what should
            // happen for each individual card.
            while (_deck.Count > 0) //&& player1.Cards.Count > 26 && player2.Cards.Count > 26
            {
                dealCard(_player1);
                dealCard(_player2);
            }
            didDealHappen = true;
            return _sb.ToString();
        }
        // A player should recieve a card, so make new instance of a Player.
        // And cards are being dealed so make new instance of Card.
        public void dealCard(Player player)
        {
            // A new instance of Card is dealt. That new instance is a 
            // random Element in _deck, within range of the count of the deck
            // which can only be the length of my _deck.Add statement in the nested
            // foreach statements above. 52 cards.
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            // Every time a card is added, print the suit and kind and who has the card.
            // Using a string builder saves me from having to tell this class what each
            // Label is.
            _sb.Append(player.Name + " has the " + card.Kind + " of " + card.Suit + "\n");
        }
    }
}
