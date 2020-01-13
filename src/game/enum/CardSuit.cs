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

        public static List<CardSuit> GetAll()
        {
            List<CardSuit> list = new List<CardSuit>();

            list.Add(SPADE);
            list.Add(HEART);
            list.Add(CLUB);
            list.Add(DIAMOND);

            return list;
        }
    }
}
