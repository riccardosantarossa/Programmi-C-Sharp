using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssociazioneCulturale
{
    public partial class Form1 : Form
    {
        GestioneAssociazione lstSoci = new GestioneAssociazione();
        GestioneAssociazione listaRicerche = new GestioneAssociazione();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Socio s = null;   
            if (rdbFondatore.Checked)
            {
                s = new SocioFondatore(txtNome.Text, (int)nmrNumeri.Value, Convert.ToString(cmbCarica.SelectedItem), "", 0, Convert.ToString(txtCodiceFiscale.Text));
                s.CalcolaQuota();
            }
            else
            {
                s = new SocioOrdinario(txtNome.Text, (int)nmrNumeri.Value, Convert.ToString(cmbCarica.SelectedItem), txtIscrizione.Text, 0);
                s.CalcolaQuota();
            }

            bool ok = lstSoci.InserisciSocio(s);
            txtNumeroSoci.Text = Convert.ToString(lstSoci.Count());
            nmrNumeri.Value++;
            txtNome.Text = "";
            txtCodiceFiscale.Text = "";
            txtIscrizione.Text = "";
            visualizzaDati();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            visualizzaDati();
        }

        private void btnCalcolaQuote_Click(object sender, EventArgs e)
        {
            double totaleQuote = 0;
            foreach (Socio s in lstSoci)
            {
                totaleQuote += s.CalcolaQuota();
            }
            txtCosto.Text = Convert.ToString(totaleQuote) + " €";
        }


        private void btnCercaTessera_Click(object sender, EventArgs e)
        {
            int numeroT = (int)nmrCercaTessera.Value;
            lstSoci.CercaTessera(numeroT,listaRicerche);
            VisualizzaRicerche();
        }

        private void rdbFondatore_CheckedChanged(object sender, EventArgs e)
        {
            txtIscrizione.Text = "";
            txtIscrizione.Enabled = false;
            txtCodiceFiscale.Enabled = true;
        }

        private void rdbOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            txtCodiceFiscale.Text = "";
            txtCodiceFiscale.Enabled = false;
            txtIscrizione.Enabled = true;
        }

        private void btnOrdinaNome_Click(object sender, EventArgs e)
        {
            lstSoci.OrdinaNome();
            visualizzaDati();
        }

        public void visualizzaDati()
        {
            string[] riga = new string[6];
            dtgSoci.Rows.Clear();
            foreach (Socio s in lstSoci)
            {
                riga = s.ToString().Split('|');
                dtgSoci.Rows.Add(riga);
            }
        }

        private void btnOrdinaTessera_Click(object sender, EventArgs e)
        {
            lstSoci.OrdinaTessera();
            visualizzaDati();
        }

        private void btnCercaPerCarica_Click(object sender, EventArgs e)
        {
            string carica = Convert.ToString(cmbCercaCarica.SelectedItem);
            lstSoci.CercaCarica(carica, listaRicerche);
            VisualizzaRicerche();
        }

        public void VisualizzaRicerche()
        {
            string[] riga = new string[6];
            dtgSoci.Rows.Clear();
            foreach (Socio s in listaRicerche)
            {
                riga = s.ToString().Split('|');
                dtgSoci.Rows.Add(riga);
            }
        }

    }
}
