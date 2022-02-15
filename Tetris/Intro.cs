using System;
using System.Drawing;
using System.Windows.Forms;


namespace Tetris
{
    public partial class Intro : Form
    {

        public Intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gioco gioco = new Gioco(this);
            gioco.Show();
            this.Hide();
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }

        private void Intro_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonCFG_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.ShowDialog();
        }
    }
}
