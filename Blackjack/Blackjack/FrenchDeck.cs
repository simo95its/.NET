﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class FrenchDeck
    {
        Card[] Deck { get; set; }

        public FrenchDeck()
        {
            Seed[] s = (Seed[])Enum.GetValues(typeof(Seed));
            Value[] v = (Value[])Enum.GetValues(typeof(Value));
            Deck = new Card[s.Length * v.Length];
        }

        public void Initialize()
        {
            int k = 0;
            foreach(Seed s in (Seed[])Enum.GetValues(typeof(Seed)))
            {
                foreach(Value v in (Value[])Enum.GetValues(typeof(Value)))
                {
                    Deck[k++] = new Card(s, v);
                }
            }
        }

        public void Shuffle()
        {
            Shuffle(150);
        }

        public void Shuffle(int n)
        {
            Random r = new Random();
            int p1;
            int p2;
            for(int i=0; i<n; i++)
            {
                p1 = r.Next(Deck.Length);
                do
                {
                    p2 = r.Next(Deck.Length);
                } while (p1 == p2);
                Card tmp = Deck[p1];
                Deck[p1] = Deck[p2];
                Deck[p2] = tmp;
            }
        }
    }
}
