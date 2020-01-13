using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_solitaire.src.game.tools;

namespace csharp_solitaire.src.game
{
    class Card : PictureBox
    {
        private bool mouseDown;
        private Point lastLocation;

        private CardSuit suit;
        private int value;

        private bool inPile = false;
        private bool isOutOfPile = false;
        private List<Card> pileCards = new List<Card>();

        public Card(int value, CardSuit suit, Point location)
        {
            this.suit = suit;
            this.value = value;

            this.MouseDown += Card_MouseDown;
            this.MouseUp += Card_MouseUp;

            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Zoom;
            Location = location;
            Size = new Size(80, 128);
            TabIndex = 0;
            TabStop = false;

            FaceDown();
        }

        public Card(int value, CardSuit suit) : this(value, suit, new Point(12, 12)) { }

        public Card() : this(1, CardSuit.DIAMOND) { }

        public void UpdateLocation(int x, int y)
        {
            if (y < 0) {
                y = Location.Y;
            }
            if (x < 0) {
                x = Location.X;
            }
            Location = new Point(x, y);
        }

        public void SetInPile(bool val)
        {
            inPile = val;
        }

        public void SetInPile(bool val, List<Card> pile)
        {
            inPile = val;
            pileCards.AddRange(pile);
        }

        public bool InPile()
        {
            return inPile;
        }

        public void SetOutOfPile(bool val)
        {
            isOutOfPile = val;
        }

        public bool OutOfPile()
        {
            return isOutOfPile;
        }

        public void FaceUp()
        {
            BackgroundImage = CardTools.GetFrontBitmap(suit, value);
        }

        public void FaceDown()
        {
            BackgroundImage = Properties.Resources.red_back;
        }

        public void MakeDraggable()
        {
            this.MouseMove += Card_MouseMove;
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            this.BringToFront();
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) {
                Card card = (Card)sender;
                card.Location = new Point(
                    (card.Location.X - lastLocation.X) + e.X, (card.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

            if (inPile && !isOutOfPile) {
                const int SPACING = 48;
                int k = 3;

                for (int i = pileCards.Count - 1; i >= pileCards.Count - 3; i--) {
                    pileCards[i].UpdateLocation(pileCards[i].Location.X, pileCards[i].Location.Y + k * SPACING);
                    pileCards[i].SetOutOfPile(true);
                    k++;
                    Card item = pileCards[i];
                    pileCards.Remove(item);
                    pileCards.Insert(0, item);
                }
            }
        }
    }
}
