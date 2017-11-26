using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame
{
    public class Battle
    {
        private List<Card> _bounty;
        private StringBuilder _sb;
        public Random _random { get; set; }

        public Battle()
        {
            _random = new Random();
            _bounty = new List<Card>();
            _sb = new StringBuilder();
        }

        public string performBattle(Player player1, Player player2)
        {
            // two new instances of card lists to store what cards are being compared in.
            Card p1Card = getCard(player1);
            Card p2Card = getCard(player2);

            // Simply compare the value of the two cards randomly dealt, and that are in 
            // position 1 of the Cards list.
            performEvaluation(player1, player2, p1Card, p2Card);
            return _sb.ToString();
        }

        // Get whatever card was randomly dealt to a player, in the first potision of the Cards list.
        public Card getCard(Player player)
        {
            // Selects ONE random card in the range of whatever cards are in the players hands.
            // Grabbing a random value of an already random selection eventually caused
            // an "Indexer out of Range" error. So I should add limiters, or exceptions
            // but to save time, I'm going to have the drawn from each pile = index 0.
            //Card card = player.Cards.ElementAt(_random.Next(player.Cards.Count));
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _bounty.Add(card);
            return card;
        }

        // Compare two cards.
        private void performEvaluation(Player player1, Player player2, Card card1, Card card2)
        {
            displayBattleCards(card1, card2);
            // Check if cards are equal in value.
            if (card1.CardValue() == card2.CardValue())
                War(player1, player2);

            // Check which card is greater in value.
            if (card1.CardValue() > card2.CardValue())
                awardWinner(player1);
            else
                awardWinner(player2);
        }

        private void awardWinner(Player player)
        {
            displayBountyCards();
            player.Cards.AddRange(_bounty);
            _sb.Append("\n" + player.Name + " Wins!\n");
            // empty all items in the _bounty List after each comparison.
            _bounty.Clear();
        }

        private void War(Player player1, Player player2)
        {
            _sb.Append("\n" + "=======___WAR!___=======" + "\n");
            // War Scenario dictates that when two cards are the same,
            // each player draws 2 cards, and a 3rd is also drawn and played.

            // Get 3 cards, 1 of which is the warCard.
            getCard(player1);
            Card  warCard1 = getCard(player1);
            getCard(player1);

            getCard(player2);
            Card warCard2 = getCard(player2);
            getCard(player2);

            // warCard is special because it's the only 1 of the 3 being evaluated.
            // perform evaluation on just war cards...
            performEvaluation(player1, player2, warCard1, warCard2);

        }

        private void displayBattleCards(Card card1, Card card2)
        {
            _sb.Append("\nBattle Cards: ");
            _sb.Append(card1.Kind);
            _sb.Append(" of ");
            _sb.Append(card1.Suit);
            _sb.Append(" vs. ");
            _sb.Append(card2.Kind + " of " + card2.Suit);
        }

        private void displayBountyCards()
        {
            _sb.Append("\n Bounty ...");

            foreach (var card in _bounty)
            {
                _sb.Append("\n" + card.Kind + " of " + card.Suit);
            }

        }
        
    }
}
