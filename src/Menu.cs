using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_solitaire.src
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Help help = new Help(this);
            this.Hide();
            help.ShowDialog(this);
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            Game game = new Game(this);
            this.Hide();
            game.ShowDialog(this);
        }
    }
}
