using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimaliStraniGrafico
{
    public partial class frmAnimali : Form
    {
        public frmAnimali()
        {
            InitializeComponent();
        }
        private AnimaliStrani a;
        private void btnGeneraAnimale_Click(object sender, EventArgs e)
        {
            a = new AnimaliStrani();
            if (a.tipo == AnimaliStrani.Tipo.ippogrifo)
                pctAnimaletto.Image = Image.FromFile("IMMAGINI\\ippo2.png");
            else
                if (a.tipo == AnimaliStrani.Tipo.pegaso)
                    pctAnimaletto.Image = Image.FromFile("IMMAGINI\\pegaso1.jpg");
                else
                    pctAnimaletto.Image = Image.FromFile("IMMAGINI\\unicorno.jpg");

            lblTipo.Visible = true;
            lblTipo.Text = Convert.ToString(a.tipo);
            lblEnergiaMax.Visible = true;
            lblEnergiaMax.Text = Convert.ToString(a.energiamax);
            lblEnergia.Visible = true;
            lblEnergia.Text = Convert.ToString(a.energia);
            lblVolo.Visible = true;
            if (a.volo == true)
                lblVolo.Text = "SI";
            else
                lblVolo.Text = "NO";
            tmrTempo.Enabled = !(tmrTempo.Enabled);
            tmrTempo.Start();
        }
        private void btnAddEnergia_Click(object sender, EventArgs e)
        {
            if(a.energia>0)
            {
                lblEnergia.Visible = false;
                a.AddEnergia();
                lblEnergia.Text = Convert.ToString(a.energia);
                lblEnergia.Visible = true;
            }
        }
        
        private void btnVeleno_Click(object sender, EventArgs e)
        {
            if (a.energia > 20)
            {
                lblEnergia.Visible = false;
                a.energia -= 20;
                lblEnergia.Visible = true;
                lblEnergia.Text = Convert.ToString(a.energia);
            }
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            if (a.energia > 0)
            {
                lblEnergia.Visible = false;
                a.DecEnergia();
                lblEnergia.Visible = true;
                lblEnergia.Text = Convert.ToString(a.energia);
            }
            else
            {
                if (a.energia == 0)
                    pctAnimaletto.Image = Image.FromFile("IMMAGINI\\rip.jpg");
            }
        }
    }
}
