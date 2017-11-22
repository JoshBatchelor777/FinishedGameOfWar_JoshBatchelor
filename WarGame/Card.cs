using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    // Cards have a suit and kind.
    public class Card
    {
        public string Suit { get; set; }
        public string Kind { get; set; }


        public int CardValue()
        {
            int value = 0;

            // Establish values, specify face card values.
            // Everything else, is the remaining value of Kind, 2-10.

            // These if statements are the same as the switch statement below.
            if (this.Kind == "Jack")
                value = 11;
            if (this.Kind == "Queen")
                value = 12;
            if (this.Kind == "King")
                value = 13;
            if (this.Kind == "Ace")
                value = 14;
            for (int i = 0; i < this.Kind.Length; i++)
            {
                value = this.Kind.ElementAt(i);
            }

            /*
            switch (this.Kind)
            {
                case "Jack":
                    value = 11;
                    break;
                case "Queen":
                    value = 12;
                    break;
                case "King":
                    value = 13;
                    break;
                case "Ace":
                    value = 14;
                    break;
                default:
                    value = int.Parse(this.Kind);
                    break;
             
            }
            */
            return value;
        }
    }
}
