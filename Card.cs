using System;

namespace deckOfCards
{
    public class Card {
        private string _stringVal;
        private string _suit;
        private int _val;

        public string stringVal {
            get {
                return _stringVal;
            }
        }

        public string suit {
            get {
                return _suit;
            }
        }

        public int val {
            get {
                return _val;
            }
        }
        
        public Card(string stringval, string suit, int val) {
            this._stringVal = stringval;
            this._suit = suit;
            this._val = val;
        }
    }
}