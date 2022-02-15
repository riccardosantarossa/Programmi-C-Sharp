using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    //Enum per le tipologie dell'opera
    enum Tipologia
    {
        Quadro,
        Scultura,
        Arazzo
    }
    class Opera
    {
        //Proprietà della classe incapsulate con get e set
        private static int cont=1;
        private int codice;
        private string autore;
        private string titolo;
        private int annoRealizzazione;
        public static int numByteRec = 161;
        private Tipologia tipo;

        public string Autore { get => autore; set => autore = value; }
        public string Titolo { get => titolo; set => titolo = value; }
        public int AnnoRealizzazione { get => annoRealizzazione; set => annoRealizzazione = value; }
        internal Tipologia Tipo { get => tipo; set => tipo = value; }
        public static int Cont { get => cont; set => cont = value; }
        public int Codice { get => codice; set => codice = value; }

        //Costruttore con parametri per la generazione iniziale
        public Opera(int c, string aut, string t, int annor, Tipologia tip)
        {
            Codice = c;
            if (aut.Length > 50)
                aut = aut.Substring(0, 49);
            autore = aut.PadRight(50, ' ');

            if (t.Length > 50)
                t = t.Substring(0, 49);
            titolo = t.PadRight(50, ' ');
            
            AnnoRealizzazione = annor;
            Tipo = tip;
        }

        //Costruttore di default per le opere "fittizie" usate in lettura e scrittura
        public Opera()
        {
            Codice = cont;
            Autore = "";
            Titolo = "";
            AnnoRealizzazione = 0;
            Tipo = Tipologia.Arazzo;
        }

        //Funzione override di ToString usata per compilare la datagridview
        public override string ToString()
        {
            return Convert.ToString(Codice) + " | " + autore + " | " + titolo + " | " + Convert.ToString(annoRealizzazione) + " | " + Convert.ToString(tipo);
        }
    }
}
