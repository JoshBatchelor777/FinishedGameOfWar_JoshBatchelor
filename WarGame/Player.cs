using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    // Players have Cards and a name (for the sake of printing functionality).
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards;

        // Constructor for how a Player should be.
        // A player has a list of Cards to be invoked in Deck 
        // because Cards are a player property.
        public Player()
        {
            Cards = new List<Card>();

        }
    }
}
