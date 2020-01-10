using csharp_solitaire.src.game;
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
        Form prevForm;

        Deck deck;

        public Game(Form prevForm)
        {
            InitializeComponent();

            this.prevForm = prevForm;
        }

        public void StartingPos()
        {
            for (int i = 0; i < deck.GetList().Count; i++) {
                
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            deck = new Deck();

            foreach (Card card in deck.GetList()) {
                this.Controls.Add(card);
                card.MakeDraggable();
                card.FaceUp();
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
