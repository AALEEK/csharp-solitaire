using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solitaire.src.game
{
    class CardColor
    {
        private CardColor(string value) { Value = value; }

        public string Value { get; set; }

        public static CardColor BLACK { get { return new CardColor("BLACK"); } }
        public static CardColor RED { get { return new CardColor("RED"); } }
    }
}
