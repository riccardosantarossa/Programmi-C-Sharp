using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Museo
{
    public partial class Form1 : Form
    {
        MuseoGestione gestore = new MuseoGestione();
        List<Opera> lstOpere = new List<Opera>();
        public Form1()
        {
            InitializeComponent();
        }

        //Creato il file all'apertura della form
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream("museo.dat", FileMode.Create);
        }

        //Aggiunte le opere a seconda del radiobutton cliccato
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //Uso del try catch per evitare crash dovuti ad un input sbagliato o mancante
            try
            {
                if (rdbArazzo.Checked)
                    gestore.Inserisciopera(new Opera(Opera.Cont, txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtAnno.Text), Tipologia.Arazzo));
                else if (rdbQuadro.Checked)
                    gestore.Inserisciopera(new Opera(Opera.Cont, txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtAnno.Text), Tipologia.Quadro));
                else if (rdbScultura.Checked)
                    gestore.Inserisciopera(new Opera(Opera.Cont, txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtAnno.Text), Tipologia.Scultura));

                txtAutore.Clear();
                txtTitolo.Clear();
                txtAnno.Clear();
                txtInfoFile.Text = gestore.InfoFile();
                Opera.Cont++;
                gestore.VisualizzaOpere(grdOpere);
            }
            catch
            {
                MessageBox.Show("ERRORE NELL'INPUT", "ERRORE");
            }
        }

        //Richiama la funzione visualizza della classe di gestione
        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            gestore.VisualizzaOpere(grdOpere);
        }

        //Richiama la funzione di infoFile della classe di gestionee scrive su una texbox con multiline
        private void btnInfo_Click(object sender, EventArgs e)
        {
            txtInfoFile.Text = gestore.InfoFile();
        }

        //Crea un'opera da passare alla classe di gestione per essere modificata.
        private void btnModificaOpera_Click(object sender, EventArgs e)
        {
            //I cambiamenti apportati all'opera con l'utilizzo dei vari campi vengono quindi registrati in un'opera creata ad hoc
            //Uso del try catch per evitare crash dovuti ad un input sbagliato o mancante
            try
            {
                Opera op = null;
                if (rdbArazzo.Checked)
                    op = new Opera(int.Parse(txtModificaCodice.Text), txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtAnno.Text), Tipologia.Arazzo);
                else if (rdbQuadro.Checked)
                    op = new Opera(int.Parse(txtModificaCodice.Text), txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtAnno.Text), Tipologia.Quadro);
                else if (rdbScultura.Checked)
                    op = new Opera(int.Parse(txtModificaCodice.Text), txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtAnno.Text), Tipologia.Scultura);

                gestore.ModificaOpera("museo.dat", op);
                gestore.VisualizzaOpere(grdOpere);
                txtAutore.Clear();
                txtTitolo.Clear();
                txtAnno.Clear();
            }
            catch
            {
                MessageBox.Show("ERRORE NELL'INPUT", "ERRORE");
            }
        }

        //Dato in input il nome dell'autore visualizza le opere a lui appartenenti grazie alla funzione della classe di gestione 
        private void btnCercaAutore_Click(object sender, EventArgs e)
        {
            //Uso del try catch per evitare crash dovuti ad un input sbagliato o mancante
            try
            {
                gestore.RicercaOpere("museo.dat", lstOpere, txtCercaAutore.Text);
                VisualizzaLista();
            }
            catch
            {
                MessageBox.Show("ERRORE NELL'INPUT", "ERRORE");
            }
        }

        //Elimina un'opera dato il suo codice grazie alla funzione dellea classe di gestione
        private void btnElimina_Click(object sender, EventArgs e)
        {
            //Uso del try catch per evitare crash dovuti ad un input sbagliato o mancante
            try
            {
                gestore.EliminaOpera("museo.dat", Convert.ToInt32(txtCodiceElimina.Text));
            }
            catch
            {
                MessageBox.Show("ERRORE NELL'INPUT", "ERRORE");
            }
        }

        //Funzione creata per visualizzare la lista delle opere creata dalla funzione, qui si scorre la lista e non il file.
        //Funzione creata a parte date le differenze nelle operazioni di lettura tra lista e file binario
        public void VisualizzaLista()
        {
            string[] riga = new string[9];
            grdOpere.Rows.Clear();
            foreach (Opera o in lstOpere)
            {
                riga = o.ToString().Split('|');
                grdOpere.Rows.Add(riga);
            }
        }

    }
}
