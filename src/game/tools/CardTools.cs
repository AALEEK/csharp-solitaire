using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace csharp_solitaire.src.game.tools
{
    class CardTools
    {
        public static Bitmap GetFrontBitmap(CardSuit suit, int value)
        {
            Bitmap image = Properties.Resources.red_back;

            if (suit.Value.Equals(CardSuit.CLUB.Value)) {
                if (value == 1) {
                    image = Properties.Resources._1C;
                }
                else if (value == 2) {
                    image = Properties.Resources._2C;
                }
                else if (value == 3) {
                    image = Properties.Resources._3C;
                }
                else if (value == 4) {
                    image = Properties.Resources._4C;
                }
                else if (value == 5) {
                    image = Properties.Resources._5C;
                }
                else if (value == 6) {
                    image = Properties.Resources._6C;
                }
                else if (value == 7) {
                    image = Properties.Resources._7C;
                }
                else if (value == 8) {
                    image = Properties.Resources._8C;
                }
                else if (value == 9) {
                    image = Properties.Resources._9C;
                }
                else if (value == 10) {
                    image = Properties.Resources._10C;
                }
                else if (value == 11) {
                    image = Properties.Resources._11C;
                }
                else if (value == 12) {
                    image = Properties.Resources._12C;
                }
                else if (value == 13) {
                    image = Properties.Resources._13C;
                }
            }
            else if (suit.Value.Equals(CardSuit.DIAMOND.Value)) {
                if (value == 1) {
                    image = Properties.Resources._1D;
                }
                else if (value == 2) {
                    image = Properties.Resources._2D;
                }
                else if (value == 3) {
                    image = Properties.Resources._3D;
                }
                else if (value == 4) {
                    image = Properties.Resources._4D;
                }
                else if (value == 5) {
                    image = Properties.Resources._5D;
                }
                else if (value == 6) {
                    image = Properties.Resources._6D;
                }
                else if (value == 7) {
                    image = Properties.Resources._7D;
                }
                else if (value == 8) {
                    image = Properties.Resources._8D;
                }
                else if (value == 9) {
                    image = Properties.Resources._9D;
                }
                else if (value == 10) {
                    image = Properties.Resources._10D;
                }
                else if (value == 11) {
                    image = Properties.Resources._11D;
                }
                else if (value == 12) {
                    image = Properties.Resources._12D;
                }
                else if (value == 13) {
                    image = Properties.Resources._13D;
                }
            }
            else if (suit.Value.Equals(CardSuit.HEART.Value)) {
                if (value == 1) {
                    image = Properties.Resources._1H;
                }
                else if (value == 2) {
                    image = Properties.Resources._2H;
                }
                else if (value == 3) {
                    image = Properties.Resources._3H;
                }
                else if (value == 4) {
                    image = Properties.Resources._4H;
                }
                else if (value == 5) {
                    image = Properties.Resources._5H;
                }
                else if (value == 6) {
                    image = Properties.Resources._6H;
                }
                else if (value == 7) {
                    image = Properties.Resources._7H;
                }
                else if (value == 8) {
                    image = Properties.Resources._8H;
                }
                else if (value == 9) {
                    image = Properties.Resources._9H;
                }
                else if (value == 10) {
                    image = Properties.Resources._10H;
                }
                else if (value == 11) {
                    image = Properties.Resources._11H;
                }
                else if (value == 12) {
                    image = Properties.Resources._12H;
                }
                else if (value == 13) {
                    image = Properties.Resources._13H;
                }
            }
            else if (suit.Value.Equals(CardSuit.SPADE.Value)) {
                if (value == 1) {
                    image = Properties.Resources._1S;
                }
                else if (value == 2) {
                    image = Properties.Resources._2S;
                }
                else if (value == 3) {
                    image = Properties.Resources._3S;
                }
                else if (value == 4) {
                    image = Properties.Resources._4S;
                }
                else if (value == 5) {
                    image = Properties.Resources._5S;
                }
                else if (value == 6) {
                    image = Properties.Resources._6S;
                }
                else if (value == 7) {
                    image = Properties.Resources._7S;
                }
                else if (value == 8) {
                    image = Properties.Resources._8S;
                }
                else if (value == 9) {
                    image = Properties.Resources._9S;
                }
                else if (value == 10) {
                    image = Properties.Resources._10S;
                }
                else if (value == 11) {
                    image = Properties.Resources._11S;
                }
                else if (value == 12) {
                    image = Properties.Resources._12S;
                }
                else if (value == 13) {
                    image = Properties.Resources._13S;
                }
            }

            return image;
        }
    }
}
