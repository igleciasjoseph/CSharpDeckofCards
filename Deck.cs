using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Deck{
        private List<Card> cards;
        public List<Card> ResetPile;

        public Card TopCard {
            get {
                return Draw();
            }
        }

        public Deck() {
            cards = new List<Card>();
            ResetPile = new List<Card>();
            Dictionary<string, int> types = new Dictionary<string, int>()
            {
                {"Ace", 1},
                {"Two", 2},
                {"Three", 3},
                {"Four", 4},
                {"Five", 5},
                {"Six", 6},
                {"Seven", 7},
                {"Eight", 8},
                {"Nine", 9},
                {"Ten", 10},
                {"Jack", 11},
                {"Queen", 12},
                {"King", 13},
            };
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };

            foreach (var suit in suits) {
                foreach (var type in types) {
                    Card card = new Card(type.Key, suit, type.Value);
                    cards.Add(card);
                }
            }

            Shuffle();
        }

        public Card Draw() {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public void Reset(List<Card> cards){
            ResetPile.AddRange(cards);
        }

        public void Shuffle() {
            if (ResetPile.Count > 0)
            {
                cards.AddRange(ResetPile);
                ResetPile.Clear();
            }
            Random ran = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = ran.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
    }



}