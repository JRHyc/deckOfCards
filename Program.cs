using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.shuffle();
            newDeck.reset();
            Player joanna = new Player();
            joanna.draw(newDeck);
            System.Console.WriteLine("Hello World");
        }
    }
}
