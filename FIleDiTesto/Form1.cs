using System;
using System.IO;
using System.Windows.Forms;


namespace FIleDiTesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SaveFileDialog salva = new SaveFileDialog();
            salva.InitialDirectory = Application.StartupPath;
            salva.Filter = "File di testo (*.txt)|*.txt";
            if (salva.ShowDialog() == DialogResult.OK)
            {
                StreamWriter scrittore = new StreamWriter(salva.FileName);
                scrittore.WriteLine(txtScrivi.Text);
                scrittore.Close();
            }
            txtScrivi.Clear();
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();
            apri.InitialDirectory = Application.StartupPath;
            apri.Filter = "File di testo (*.txt)|*.txt";
            if (apri.ShowDialog() == DialogResult.OK)
            {
                StreamReader lettore = new StreamReader(apri.FileName);
                txtScrivi.Text = lettore.ReadToEnd();
                lettore.Close();
            }
        }
        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
