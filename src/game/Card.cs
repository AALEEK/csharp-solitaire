using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_solitaire.src.game
{
    class Card : PictureBox
    {
        public Card(string name)
        {
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = global::csharp_solitaire.Properties.Resources.red_back;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Location = new System.Drawing.Point(12, 12);
            Name = name;
            Size = new System.Drawing.Size(80, 128);
            TabIndex = 0;
            TabStop = false;
        }
    }
}
