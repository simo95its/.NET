using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public Seed Seed { get; set; }
        public Value Value { get; set; }
        public bool IsExtracted {get; set;}

        public Card(Seed seed, Value value)
        {
            Seed = seed;
            Value = value;
        }
    }
}
