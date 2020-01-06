using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_solitaire.src.game
{
    class Card : PictureBox
    {
        private bool mouseDown;
        private Point lastLocation;

        public Card(int value, CardSuit suit, CardColor color, Point location)
        {
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = global::csharp_solitaire.Properties.Resources.red_back;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Location = location;
            Size = new System.Drawing.Size(80, 128);
            TabIndex = 0;
            TabStop = false;
        }

        public Card(int value, CardSuit suit, CardColor color) : this(value, suit, color, new Point(12, 12)) { }

        public Card() : this(1, CardSuit.DIAMOND, CardColor.BLACK, new Point(12, 12)) { }

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
