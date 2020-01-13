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
        List<Card> cardPile = new List<Card>();

        public Game(Form prevForm)
        {
            InitializeComponent();

            this.prevForm = prevForm;
        }



        public void StartingPos()
        {
            Queue<Card> cardsToMove = new Queue<Card>(deck.GetList());

            const int SPACING = 24;

            for (int i = 0; i < 24; i++) {
                Card temp = cardsToMove.Dequeue();
                temp.SetInPile(true, cardPile);
                cardPile.Add(temp);
            }

            Card pos1 = cardsToMove.Dequeue();
            pos1.UpdateLocation(CardX.POS_1, -1);
            pos1.FaceUp();
            pos1.MakeDraggable();

            for (int i = 0; i < 2; i++) {
                Card temp = cardsToMove.Dequeue();
                temp.UpdateLocation(CardX.POS_2, temp.Location.Y + i * SPACING);
                if (i == 1) {
                    temp.FaceUp();
                    temp.MakeDraggable();
                }
            }

            for (int i = 0; i < 3; i++) {
                Card temp = cardsToMove.Dequeue();
                temp.UpdateLocation(CardX.POS_3, temp.Location.Y + i * SPACING);
                if (i == 2) {
                    temp.FaceUp();
                    temp.MakeDraggable();
                }
            }

            for (int i = 0; i < 4; i++) {
                Card temp = cardsToMove.Dequeue();
                temp.UpdateLocation(CardX.POS_4, temp.Location.Y + i * SPACING);
                if (i == 3) {
                    temp.FaceUp();
                    temp.MakeDraggable();
                }
            }

            for (int i = 0; i < 5; i++) {
                Card temp = cardsToMove.Dequeue();
                temp.UpdateLocation(CardX.POS_5, temp.Location.Y + i * SPACING);
                if (i == 4) {
                    temp.FaceUp();
                    temp.MakeDraggable();
                }
            }

            for (int i = 0; i < 6; i++) {
                Card temp = cardsToMove.Dequeue();
                temp.UpdateLocation(CardX.POS_6, temp.Location.Y + i * SPACING);
                if (i == 5) {
                    temp.FaceUp();
                    temp.MakeDraggable();
                }
            }

            for (int i = 0; i < 7; i++) {
                Card temp = cardsToMove.Dequeue();
                temp.UpdateLocation(CardX.POS_7, temp.Location.Y + i * SPACING);
                if (i == 6) {
                    temp.FaceUp();
                    temp.MakeDraggable();
                }
            }

            for (int i = deck.GetList().Count - 1; i >= 0; i--) {
                this.Controls.Add(deck.GetList()[i]);
            }

        }

        private void Game_Load(object sender, EventArgs e)
        {
            deck = new Deck();

            StartingPos();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Dispose();
        }
    }
}
