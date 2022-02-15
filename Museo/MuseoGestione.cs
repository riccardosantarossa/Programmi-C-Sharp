using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Museo
{
    class MuseoGestione
    {

        public void Inserisciopera(Opera o)
        {
            FileStream fs = new FileStream("museo.dat", FileMode.Append, FileAccess.Write);
            BinaryWriter scrittore = new BinaryWriter(fs);

            //Usa la funzione di scrittura per inserire un nuovo record nel file
            UsaScrivi(scrittore, o);

            scrittore.Close();
            fs.Close();
        }

        public void VisualizzaOpere(DataGridView griglia)
        {
            FileStream fs = new FileStream("museo.dat", FileMode.Open, FileAccess.Read);
            BinaryReader lettore = new BinaryReader(fs);
            Opera op = new Opera();
            griglia.Rows.Clear();
            
            //Legge tutto il file e usa la funzione di lettura
            while (lettore.PeekChar() != -1)
            {
                UsaLeggi(lettore, op);
                //Controlla che il codice dell'opera sia diverso da 0. In quel caso significa che l'opera è stata eliminata
                if (op.Codice != 0)
                    griglia.Rows.Add(op.ToString().Split('|'));   
            }

            lettore.Close();
            fs.Close();
        }

        //Mostra le informazioni del file in tempo reale, sia all'inserimento che al click del bottone apposito
        public string  InfoFile()
       {
           string strInfo = "";
           DateTime dt;
           long numeroRecord;

           FileInfo fi = new FileInfo("museo.dat");

           strInfo = "File: " + fi.DirectoryName + "\\" + "museo.dat" + "\n";
           strInfo += "Dim: " + (fi.Length) + " Byte," + (fi.Length / 1024) + " KB," +
                                                         (float)(fi.Length / 1024 / 1024) + " MB" + "\n";
           dt = fi.CreationTime;
           strInfo += "Data di creazione: " + dt.ToString() + "\n";
           dt = fi.LastAccessTime;
           strInfo += "Data ultimo accesso: " + dt.ToString() + "\n";
           numeroRecord = fi.Length / Opera.numByteRec;
           strInfo += "Numero Record: " + numeroRecord;

           return strInfo;
       }

        public void ModificaOpera(string nomeFile, Opera o)
        {

            FileStream fs = new FileStream(nomeFile, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter scrittore = new BinaryWriter(fs);
            BinaryReader lettore = new BinaryReader(fs);
            bool trov = false;
            long pos = 0;
            
            //Per modificare l'opera utilizza, un'istanza gia' modificata passata come parametro di ingresso
            while ((lettore.PeekChar() != -1) && (!trov))
            {
                Opera op = new Opera();	   
                //Salva la posizione e legge il record
                pos = fs.Position;
                UsaLeggi(lettore, op);

                trov = (op.Codice==o.Codice); 
            }
            //Se il confornto ctra i codici va a buon fine, si sovrascrivono i dati dell'opera in ingresso su quella già salvata
            if (trov)
            {
                fs.Seek(pos, SeekOrigin.Begin);
                UsaScrivi(scrittore, o);
            }
            lettore.Close();
            scrittore.Close();
            fs.Close();
        }

        //Restituisce una lista di opere contenenti quelle dell'autore dato in input
        public List<Opera> RicercaOpere(string nomeFile,List<Opera> l, string a)
        {
            FileStream fs = new FileStream(nomeFile, FileMode.Open, FileAccess.Read);
            BinaryReader lettore = new BinaryReader(fs);
            l.Clear(); 
           
            //Confronta l'autore dell'opera con quello da cercare e aggiunge alla lista in caso di corrispondenza
            while ((lettore.PeekChar() != -1))
            {
                Opera op = new Opera();
                UsaLeggi(lettore,op);
                if (op.Autore == a)
                    l.Add(op);
            }

            lettore.Close();
            fs.Close();

            return l;
        }

        public void EliminaOpera(string nomeFile, int cElim)
        {
            FileStream fs = new FileStream(nomeFile, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader lettore = new BinaryReader(fs);
            BinaryWriter scrittore = new BinaryWriter(fs);
            bool flag = false;
            long pos = 0;

            while (lettore.PeekChar() != -1 && flag == false)
            {
                //Per eliminare l'opera si confronta il codice con quello dato in ingresso
                Opera op = new Opera();
                pos = fs.Position;
                UsaLeggi(lettore, op);

                flag = (op.Codice == cElim);

            }

            //In caso di corrispondenza si cambia il codice a 0. Il visualizza quindi non lo stamperà.
            //Dopo aver premuto il tasto elimina, servirà premere il visualizza per avere un riscontro visivo dell'eliminazione
            if(flag)
            {
                fs.Seek(pos, SeekOrigin.Begin);
                scrittore.Write(0);
            }


            scrittore.Close();
            lettore.Close();
            fs.Close();
        }

        //Funzioni leggi e scrivi usate per raggruppare le operazzioni ausiliarie di lettura e scrittura del file
        public void UsaLeggi(BinaryReader lettore, Opera op)
        {
            op.Codice = lettore.ReadInt32();
            op.Autore = lettore.ReadString().Trim();
            op.Titolo = lettore.ReadString().Trim();
            op.AnnoRealizzazione = lettore.ReadInt32();
            op.Tipo = (Tipologia)Enum.Parse(typeof(Tipologia), lettore.ReadString().Trim(), true);
        }

        public void UsaScrivi(BinaryWriter scrittore, Opera o)
        {
            scrittore.Write(o.Codice);
            scrittore.Write(o.Autore);
            scrittore.Write(o.Titolo);
            scrittore.Write(o.AnnoRealizzazione);
            scrittore.Write(o.Tipo.ToString().PadRight(50, ' '));
        }

    }
}
