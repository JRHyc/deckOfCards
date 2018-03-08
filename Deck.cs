using System;
using System.Collections.Generic;

namespace deckOfCards
{
    public class Deck
    {
        List<Card> cards = new List<Card>();
        string[] stringVals = new string[]{"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        string[] suits = new string[]{"Spades", "Hearts", "Diamonds", "Clubs"};

        public Card deal()
        {
            Card dealCard = cards[cards.Count - 1];
            cards.Remove(dealCard);
            return dealCard;
        }

        public Deck()
        {
            foreach(string suit in suits)
            {
                int count = 1;
                foreach(string stringVal in stringVals)
                {
                    Card card = new Card(suit, stringVal, count);
                    cards.Add(card);
                    count++;
                }
            }
        }

        public Deck shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i < cards.Count; i++)
            {
                int idx = rand.Next(0, 53);
                Card temp = cards[i];
                cards[i] = cards[idx];
                cards[idx] = temp;
            }
            return this;
        }

        public Deck reset()
        {
            cards = new List<Card>();
            foreach(string suit in suits){
                int count = 1;
                foreach(string stringVal in stringVals)
                {
                    Card card = new Card(suit, stringVal, count);
                    cards.Add(card);
                    count++;
                }
            }
            return this;
        }
    }
}