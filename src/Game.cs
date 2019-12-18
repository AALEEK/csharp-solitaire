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
    public partial class Game : Form
    {
        public Form prevForm;

        public Game(Form prevForm)
        {
            this.prevForm = prevForm;
            InitializeComponent();
        }


        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
