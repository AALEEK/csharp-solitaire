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
        Form prevForm;

        public Help(Form prevForm)
        {
            InitializeComponent();

            this.prevForm = prevForm;
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Hide();
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
