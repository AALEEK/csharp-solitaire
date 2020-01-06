using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solitaire.src.game
{
    class Deck
    {
        private List<Card> deckList = new List<Card>();

        public Deck()
        {
            FillDeck();
        }

        private void FillDeck()
        {
            if (deckList.Count > 0) {
                deckList.Clear();
            }

            //init Spades
            for (int i = 1; i <= 13; i++) {
                deckList.Add(new Card(i, CardSuit.SPADE, CardColor.BLACK));
            }

            //init Hearts
            for (int i = 1; i <= 13; i++) {
                deckList.Add(new Card(i, CardSuit.HEART, CardColor.BLACK));
            }

            //init Diamonds
            for (int i = 1; i <= 13; i++) {
                deckList.Add(new Card(i, CardSuit.DIAMOND, CardColor.BLACK));
            }

            //init Clubs
            for (int i = 1; i <= 13; i++) {
                deckList.Add(new Card(i, CardSuit.CLUB, CardColor.BLACK));
            }
        }

        public List<Card> GetList()
        {
            return deckList;
        }
    }
}
