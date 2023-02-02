using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Poker
{
    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        public Card(string rank, string suit)
        {
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            Random randomRank = new Random();
            Random randomSuit = new Random();
            int k = randomSuit.Next(0, 3);
            int i = randomRank.Next(0, 12);
            rank = ranks[i];
            suit = suits[k];
            Rank = rank;
            Suit= suit;
        }
        public override string ToString()
        {
            return Rank + ' ' + Suit;
        }
    }
}