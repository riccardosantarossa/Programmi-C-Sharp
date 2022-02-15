using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Newtonsoft.Json;
using NAudio;
using NAudio.Wave;

namespace Tetris
{
    public partial class Gioco : Form
    {
        
        private Intro intro;

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFileReader;


        private Tetramino tetraminoAnteprima;
        private Tetramino tetraminoAttuale;  
        private Color[,] campoGioco=new Color[10, 16]; 
        private int livelloCorrente = 0;
        private int lineeFatte = 0;
        private int lineePerProssimoLivello = 0;
        private int speed = 0;
        private int punteggio = 0;

        public Gioco(Intro intro)
        {
            this.intro = intro;
            InitializeComponent();
        
            outputDevice = new WaveOutEvent();
            audioFileReader = new AudioFileReader("Audio\\tetris_arcade.mp3");
            outputDevice.Init(audioFileReader);
            outputDevice.Volume = Config.volumeAudio;

            //sistemo le dimensioni del gioco
            this.Height = campoGioco.GetLength(1) * Config.sizeTetramini + panelLeft.Padding.Top + panelLeft.Padding.Bottom + 42;//42 contiene la dimensione del tab del form e altre cose misteriose
            panelLeft.Width = campoGioco.GetLength(0) * Config.sizeTetramini + panelLeft.Padding.Left + panelLeft.Padding.Right + 2;
            this.Width = panelLeft.Width * 2;
            panelAnteprima.Size = new Size(Config.sizeTetramini * 4 + 2, Config.sizeTetramini * 4 + 2);

            outputDevice.Play();
        }

        private void Gioco_FormClosing(object sender, FormClosingEventArgs e)
        {
            outputDevice.Stop();

            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            intro.Show();
        }

        private void Gioco_Load(object sender, EventArgs e)
        {


            //Carico il livello
            CaricaLivello(0);

        }     

        private void CaricaLivello(int livelloDaCaricare)
        {
            lineeFatte = 0;
            Inizializza();//azzero l'array del campo gioco

            //Leggo il file contentente TUTTI i livelli
            StreamReader reader = new StreamReader("data\\levels.json");
            LevelsRoot livelli = JsonConvert.DeserializeObject<LevelsRoot>(reader.ReadToEnd());
            reader.Close();//meglio chiudere il file per evitare brutte sorprese

            //In base alla struttura di livelli aggiorno le variabili e la struttura del livello.
            //Non sarebbe necessario avere queste variabili (speed ...), potrei usare direttamente la lista livelli. Ma sono degli alias rapidi
            speed = livelli.Levels[livelloDaCaricare].Speed;
            lineePerProssimoLivello= livelli.Levels[livelloDaCaricare].NextLevel;

            foreach (Block item in livelli.Levels[livelloDaCaricare].Blocks)
            {
                campoGioco[item.x, item.y] = Color.Aqua;              
            }

            //Aggiungo i pannelli al campo gioco
            AddCampoGioco();
            //Genero i tetramini
            tetraminoAnteprima = new Tetramino(panelAnteprima);
            tetraminoAttuale = new Tetramino(panelCampoGioco);
            this.timerGioco.Interval = speed;
        }

        /// <summary>
        /// Semplicemente imposta la matrice ad un valore vuoto (nero)
        /// </summary>
        private void Inizializza()
        {

            //inizializzazione
            punteggio = 0;
            campoGioco = new Color[10, 16];
            for (int i = 0; i < campoGioco.GetLength(0); i++)
            {
                for (int j = 0; j < campoGioco.GetLength(1); j++)
                {
                    campoGioco[i, j] = Color.Black;
                }
            }

        }

        private void AddCampoGioco()
        {
            //Pulisco il campo
            panelCampoGioco.Controls.Clear();
            //Disegno i mattoncini del campo gioco
            for (int i = 0; i < campoGioco.GetLength(0); i++)
            {
                for (int j = 0; j < campoGioco.GetLength(1); j++)
                {
                    //Disegno
                    if (campoGioco[i, j] != Color.Black)
                    {
                        Panel panel = new Panel();
                        panel.BackColor = campoGioco[i, j];
                        panel.Location = new Point(i * Config.sizeTetramini, j * Config.sizeTetramini);
                        panel.Size = new Size(Config.sizeTetramini, Config.sizeTetramini);
                        panel.BorderStyle = BorderStyle.Fixed3D;
                        panelCampoGioco.Controls.Add(panel);
                    }
                }
            }
        }

        private void TimerGioco_Tick(object sender, EventArgs e)
        {
             //"IA"
            DownTetramino();            

            //Output 
            tetraminoAttuale.update();

        }

        #region Gestione della logica del gioco (collisioni,rimozione righe, compatta, trasferimento tetramino)
        /// <summary>
        /// Verifico se c'è una intersezione/collisione tra il tetramino ed il campo gioco
        /// </summary>
        /// <param name="XtoAdd">Coordinata nelle X da aggiungere per fare il test. Utile per vedere se il tetramino colliderà (in futuro)</param>
        /// <param name="YtoAdd">Coordinata nelle Y da aggiungere per fare il test. Utile per vedere se il tetramino colliderà (in futuro)</param>
        /// <returns>il solito booleano se si è verificata la collisione</returns>
        private bool collisione(int XtoAdd,int YtoAdd)
        {
            int[,] struttura = tetraminoAttuale.getStruttura();
            for (int riga = 0; riga < struttura.GetLength(0); riga++)
                for (int colonna = 0; colonna < struttura.GetLength(1); colonna++)
                {
                    if (struttura[riga, colonna] == 1)
                    {
                        //il try catch per quando con l'avanzamento va oltre i limiti della matrice, ma il caso è già trattato nell'if
                        try
                        {
                            if (campoGioco[ colonna + tetraminoAttuale.position.X+ XtoAdd, riga + tetraminoAttuale.position.Y+ YtoAdd] != Color.Black)
                                return true;
                        }
                        catch { }
                    }
                }
            return false;
        }

        /// <summary>
        /// Rimuove le linee completate e calcola quante linee vengono rimosse
        /// </summary>
        /// <returns>Il numero di righe rimosse(massimo 4 ovviamente)</returns>
        public int RimuoviRigheComplete()
        {
            int righeRimosse = 0;
            int contatore;
            for (int riga = 0; riga < campoGioco.GetLength(1); riga++)
            {
                contatore = 0;
                //Conto i blocchi pieni in quella riga
                for (int colonna = 0; colonna < campoGioco.GetLength(0); colonna++)
                {                    
                    if (campoGioco[colonna, riga] != Color.Black)
                    {
                        contatore++;
                    }
                }
                //se il numero di blocchi pieni è uguale alla larghezza della matrice, allora la linea è completa
                if (contatore == campoGioco.GetLength(0))
                {
                    righeRimosse++;
                    CompattaRighe(riga);
                }
            }

            return righeRimosse;
        }

        //Data una riga, la elimino spostando tutte le righe in basso di una.
        //Presa la riga selezionata, copio il contenuto di quella di sopra e poi rendo vuota quella superiore
        private void CompattaRighe(int myriga)
        {
            for (int riga = myriga; riga >= 1; riga--)
                for (int colonna = 0; colonna < campoGioco.GetLength(0); colonna++)
                {
                    campoGioco[colonna,riga ] = campoGioco[colonna,riga - 1 ];
                    campoGioco[colonna,riga - 1] = Color.Black;
                }
        }

        /// <summary>
        /// Trasferisco il tetramino nel campo di gioco ed eventualmetne rimuovo le righe
        /// </summary>
        private void TrasferisciTetraminoInCampoGioco()
        {
            int[,] struttura = tetraminoAttuale.getStruttura();

            for (int riga = 0; riga < struttura.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < struttura.GetLength(1); colonna++)
                {
                    if (struttura[riga, colonna] == 1)
                    {
                        campoGioco[colonna + tetraminoAttuale.position.X, riga + tetraminoAttuale.position.Y] = tetraminoAttuale.getColor();
                    }
                }
            }

            //rimuovo le righe e calcolo l'eventuale punteggio. Rimuovi righe restituisce un numero da 0 a 4
            int lineeAppenaRimosse = RimuoviRigheComplete();
            lineeFatte += lineeAppenaRimosse;
            switch (lineeAppenaRimosse)
            {
                case 1:
                    punteggio += 10;
                    AddCampoGioco();
                    break;
                case 2:
                    punteggio += 25;
                    AddCampoGioco();
                    break;
                case 3:
                    punteggio += 40;
                    AddCampoGioco();
                    break;
                case 4://se si è fatto tetris, allora assegno un bel bonus...
                    punteggio += 69;
                    AddCampoGioco();
                    break;
                default://se non sono state rimosse linee
                    break;
            }



            //Nuovo tetramino che discende dall'alto
            tetraminoAttuale = tetraminoAnteprima;
            foreach (var item in tetraminoAttuale.panels)
                panelCampoGioco.Controls.Add(item);

            if (lineeFatte >= this.lineePerProssimoLivello)
            {         //Carico il livello seguente se ho vinto
                try
                {
                    CaricaLivello(++livelloCorrente);
                }catch
                {
                    MessageBox.Show("Non ci sono altri livelli da caricare...sorry");
                }
                lineeFatte = 0;
            }
            panelAnteprima.Controls.Clear();
            tetraminoAnteprima = new Tetramino(panelAnteprima);

            //Se quando nasce il nuovo tetramino questo collide, allora è GAME OVER
            if (collisione(0, 0))
            {
                timerGioco.Enabled = false;
                MessageBox.Show("Hai perso, gne gneee!!!");
                this.Close();
                
            }
        }
        #endregion

        #region Gestione Key 
        /// <summary>
        /// Funzione che fa scendere di una posizione nelle y il tetramino
        /// </summary>
        private void DownTetramino()
        {
            if ((tetraminoAttuale.position.Y + tetraminoAttuale.getHeight() < campoGioco.GetLength(1) ) && !collisione(0,1))
                tetraminoAttuale.position.Y++;
            else
            {
                TrasferisciTetraminoInCampoGioco();
                labelPunteggio.Text = punteggio.ToString();

            }
            tetraminoAttuale.update();
        }

        /// <summary>
        /// Funzione che sposta a sinistra il tetramino
        /// </summary>
        private void LeftTetramino()
        {
            if ((tetraminoAttuale.position.X > 0) && !collisione(-1, 0))
                tetraminoAttuale.position.X--;
            tetraminoAttuale.update();
        }

        /// <summary>
        /// Funzione che sposta a destra il tetramino
        /// </summary>
        private void RightTetramino()
        {
            if ((tetraminoAttuale.position.X + tetraminoAttuale.getWidth() < campoGioco.GetLength(0)) && !collisione(1, 0))
                tetraminoAttuale.position.X++;
            tetraminoAttuale.update();
        }

        /// <summary>
        /// Funzione che ruota il tetramino
        /// </summary>
        private void UpTetramino()
        {
            tetraminoAttuale.routa();//RUOTO IL TETRAMINO
            //SE PARTE DEL TETRAMINO RUOTATO è FUORI DALLO SCHERMO O COLLIDE, ALLORA TORNO INDIETRO NELLA ROTAZIONE.
            if (tetraminoAttuale.position.X + tetraminoAttuale.getWidth() > campoGioco.GetLength(0) || tetraminoAttuale.position.Y + tetraminoAttuale.getHeight() > campoGioco.GetLength(1) || collisione(0, 0))
                tetraminoAttuale.routaBack();
            tetraminoAttuale.update();
        }

        private void Gioco_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    LeftTetramino();
                    break;
                case Keys.Right:
                    RightTetramino();
                    break;
                case Keys.Up:
                    UpTetramino();
                    break;
                case Keys.Down:
                    DownTetramino();                    
                    break;
                default:
                    break;
            }
        }
        #endregion


    }

    #region Classe speciale che ha due metodi utili ad impedire l'effetto sfarfallio nel draw
    class DrawingControl
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
    #endregion
}
