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

        public Card(int value, CardSuit suit, Point location)
        {
            this.suit = suit;
            this.value = value;

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
            this.MouseDown += Card_MouseDown;
            this.MouseMove += Card_MouseMove;
            this.MouseUp += Card_MouseUp;
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
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
        }
    }
}
