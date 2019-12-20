using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solitaire.src.game
{
    class CardSuit
    {
        private CardSuit(string value) { Value = value; }

        public string Value { get; set; }

        public static CardSuit SPADE { get { return new CardSuit("SPADE"); } }
        public static CardSuit HEART { get { return new CardSuit("HEART"); } }
        public static CardSuit CLUB { get { return new CardSuit("CLUB"); } }
        public static CardSuit DIAMOND { get { return new CardSuit("DIAMOND"); } }
    }
}
