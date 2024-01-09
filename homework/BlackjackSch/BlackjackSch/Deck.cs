using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSch
{
    internal class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (var suit in suits)
            {
                foreach (var face in faces)
                {
                    int value = (face == "A") ? 11 : (face == "J" || face == "Q" || face == "K") ? 10 : int.Parse(face);
                    cards.Add(new Card { Suit = suit, Face = face, Value = value });
                }
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            cards = cards.OrderBy(c => rand.Next()).ToList();
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("No more cards in the deck!");
                return null;
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}
