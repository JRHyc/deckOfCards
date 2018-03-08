using System;
using System.Collections.Generic;

namespace deckOfCards
{
    public class Player
    {
        List<Card> hand = new List<Card>();
        public Card draw(Deck deck)
        {
            Card drawCard = deck.deal();
            hand.Add(drawCard);
            return drawCard;
        }

        public Card discard(int idx)
        {
            if(idx < hand.Count)
            {
                Card removeCard = hand[idx];
                hand.Remove(removeCard);
                return removeCard;
            }
            return null;
        }
    }
}