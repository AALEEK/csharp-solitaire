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
        private static Random rng = new Random();

        public Deck()
        {
            Init();
            Shuffle();
        }

        private void Init()
        {
            if (deckList.Count > 0) {
                deckList.Clear();
            }

            //init Cards
            for (int i = 1; i <= 13; i++) {
                deckList.Add(new Card(i, CardSuit.SPADE));
                deckList.Add(new Card(i, CardSuit.HEART));
                deckList.Add(new Card(i, CardSuit.DIAMOND));
                deckList.Add(new Card(i, CardSuit.CLUB));
            }
        }

        public void Shuffle()
        {
            int n = deckList.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                Card temp = deckList[k];
                deckList[k] = deckList[n];
                deckList[n] = temp;
            }
        }

        public List<Card> GetList()
        {
            return deckList;
        }
    }
}
