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
    public partial class Help : Form
    {
        public Form prevForm;

        public Help(Form prevForm)
        {
            this.prevForm = prevForm;
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Hide();
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Show();
            this.Hide();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}
