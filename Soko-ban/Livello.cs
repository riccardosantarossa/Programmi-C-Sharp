﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Soko_ban
{
    public partial class frmLivello : Form
    {
        public int sizePacchi = 48;
        private int[,] campoGioco;
        private List<Pacco> lstPacchi = new List<Pacco>();
        private Magazziniere m;
        public int livello;
        private Image muro, pacco, magazzinieredwn, magazziniereup, magazzinieredx, magazzinieresx, trigger, cassatriggered;
        private int tempo;
        LevelsRoot livelli;
        Panel pnlCampoGioco;

        public void LivShow()
        {            
            Show();
        }

        public frmLivello()
        {
            InitializeComponent();
        }
        
        private void Livello_Load(object sender, EventArgs e)
        {            
            //apertura file JSON e assegnazione di tutto il suo contenuto a livelli facente parte della classe LevelsRoot
            StreamReader reader = new StreamReader("..\\..\\resources\\livelli.json");
            livelli = JsonConvert.DeserializeObject<LevelsRoot>(reader.ReadToEnd());                        

            muro = Image.FromFile("..\\..\\images\\mattoni.jpg");
            pacco = Image.FromFile("..\\..\\images\\cassa.jpg");
            magazzinieredwn = Image.FromFile("..\\..\\images\\down.jpg");
            magazziniereup = Image.FromFile("..\\..\\images\\up.jpg");
            magazzinieredx = Image.FromFile("..\\..\\images\\dx.jpg");
            magazzinieresx = Image.FromFile("..\\..\\images\\sx.jpg");
            trigger = Image.FromFile("..\\..\\images\\trigger.jpg");
            cassatriggered = Image.FromFile("..\\..\\images\\cassatriggered.jpg");

            reader.Close();
            CaricaLivello(livello);
        }     

        private void CaricaLivello(int livello)
        {
            int cont = 0;
            this.livello = livello;            

            Point triggerI = new Point(livelli.Levels[livello].TriggerXi, livelli.Levels[livello].TriggerYi);
            Point triggerF = new Point(livelli.Levels[livello].TriggerXf, livelli.Levels[livello].TriggerYf);            

            campoGioco = new int[livelli.Levels[livello].Matrixr, livelli.Levels[livello].Matrixc];

            //generazione nuovo pannello            
            pnlCampoGioco = new Panel();            
            Controls.Add(pnlCampoGioco);
            pnlCampoGioco.Location = new Point(0, 30);
            pnlCampoGioco.Visible = true;
            statusBar.Value = 0;            

            //pulizia label punti e tempo
            lstPacchi.Clear();
            lblMosse.Text = "0";
            lblPushes.Text = "0";
            tempo = 0;
            barrasotto.Text = "00:00:00";
            Text = lblLivello.Text = livelli.Levels[livello].Name;             

            //cicli necessari per inserire i valori successivi della lista in una matrice ordinata
            do
            {
                for (int i = 0; i < livelli.Levels[livello].Matrixr; i++)
                {
                    for (int j = 0; j < livelli.Levels[livello].Matrixc; j++)
                    {
                        campoGioco[i, j] = livelli.Levels[livello].Matrix[cont];
                        cont++;
                    }
                }
            } while (cont < livelli.Levels[livello].Matrixr * livelli.Levels[livello].Matrixc);
            pnlCampoGioco.Size = new Size(campoGioco.GetLength(1) * sizePacchi, (campoGioco.GetLength(0) * sizePacchi) + 48);

            #region Aggiunta alla form di tutte le componenti necessarie
            //posizionato prima questo for in modo che il magazziniere e i pacchi si sovrappongano a tutto il resto (triggerzone)
            for (int i = 0; i < campoGioco.GetLength(1); i++)
            {
                for (int j = 0; j < campoGioco.GetLength(0); j++)
                {
                    if (campoGioco[j, i] == 3)
                    {
                        m = new Magazziniere(j, i, sizePacchi, magazzinieresx);
                        pnlCampoGioco.Controls.Add(m.pboxm);
                    }
                    else if (campoGioco[j, i] == 2)
                        lstPacchi.Add(new Pacco(j, i, sizePacchi, pacco, cassatriggered, triggerI, triggerF));
                }
            }

            foreach (Pacco p in lstPacchi) //aggiunta al pannello dei pacchi generati
            {
                p.pboxp.Location = new Point(p.Posy * sizePacchi, p.Posx * sizePacchi);
                pnlCampoGioco.Controls.Add(p.pboxp);
            }

            //aggiunta di tutte le altre picturebox riguardanti il magazino
            for (int i = 0; i < campoGioco.GetLength(1); i++)
            {
                for (int j = 0; j < campoGioco.GetLength(0); j++)
                {
                    if (campoGioco[j, i] == -1)
                    {
                        PictureBox pboxm = new PictureBox()
                        {
                            Image = trigger,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Visible = true,
                            Location = new Point(i * sizePacchi, j * sizePacchi),
                            Size = new Size(sizePacchi, sizePacchi)
                        };                        
                        pnlCampoGioco.Controls.Add(pboxm);                        
                    }
                    else if (campoGioco[j, i] == 1)
                    {
                        PictureBox pbox = new PictureBox()
                        {
                            Image = muro,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Visible = true,
                            Location = new Point(i * sizePacchi, j * sizePacchi),
                            Size = new Size(sizePacchi, sizePacchi)
                        }; 
                        pnlCampoGioco.Controls.Add(pbox);
                    }                    
                }
            }
            #endregion
        }

        #region Gestione tasti e gestione della triggerzone
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tmrTempo.Enabled == false)
                tmrTempo.Enabled = true;
            switch (e.KeyCode)
            {
                case Keys.Left:                    
                    KeyFunc(m.Posx, m.Posy, 0, -1);
                    m.pboxm.Image = magazzinieresx;
                    break;
                case Keys.Right:                    
                    KeyFunc(m.Posx, m.Posy, 0, 1);
                    m.pboxm.Image = magazzinieredx;
                    break;
                case Keys.Up:                    
                    KeyFunc(m.Posx, m.Posy, -1, 0);
                    m.pboxm.Image = magazziniereup;
                    break;
                case Keys.Down:                    
                    KeyFunc(m.Posx, m.Posy, 1, 0);
                    m.pboxm.Image = magazzinieredwn;
                    break;
            }
        }        

        private void KeyFunc(int mx, int my, int x, int y)
        {
            if (campoGioco[mx + x, my + y] == 0 || campoGioco[mx + x, my + y] == -1)
            {
                campoGioco[mx, my] = 0;                               
                m.Posy += y;
                m.Posx += x;
                m.Mosse++;
            }
            else if (campoGioco[mx + x, my + y] == 2)
            {
                if (campoGioco[mx + (x * 2), my + (y * 2)] == 0 || campoGioco[mx + (x * 2), my + (y * 2)] == -1)
                {
                    campoGioco[mx, my] = 0;                    
                    campoGioco[mx + (x * 2), my + (y * 2)] = 2;
                    m.Posy += y;
                    m.Posx += x;

                    Pacco pacco = lstPacchi.Find(s => s.Posx == mx + x && s.Posy == my + y);
                    pacco.Posx += x;
                    pacco.Posy += y;
                    m.Spinte++;
                    m.Mosse++;                    
                }
            }
            lblMosse.Text = Convert.ToString(m.Mosse);
            lblPushes.Text = Convert.ToString(m.Spinte);            
        }        

        private void TriggerZone()
        {
            int nPacchiOK = 0;
            int inc;                                

            foreach (Pacco pacco in lstPacchi)
            {
                if (pacco.PaccoOk())
                    nPacchiOK++;
            }

            if (nPacchiOK == lstPacchi.Count)
            {
                tmrTempo.Stop();
                pnlRisultato.Visible = true;
                lblMosseRisultato.Text = Convert.ToString(m.Mosse);
                lblSpinteRisultato.Text = Convert.ToString(m.Spinte);
                lblTempoRisultato.Text = Convert.ToString(TimeSpan.FromSeconds(tempo));
            }

            inc = (nPacchiOK * 100) / livelli.Levels[livello].nPacchi;
            statusBar.Value = inc;            
        }

        #endregion

        #region Bottoni barra strumenti
        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void manualeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementazione menu manuale non ancora terminata");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sokoban for Windows 10 versione 1.0", "Sokoban for Windows");
        }

        private void ricaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCampoGioco.Visible = false;
            pnlCampoGioco.Controls.Clear();
            CaricaLivello(livello);
        }
        #endregion

        private void btnContinua_Click(object sender, EventArgs e)
        {
            pnlRisultato.Visible = false;
            pnlCampoGioco.Visible = false;
            pnlCampoGioco.Controls.Clear();
            if (livelli.Levels.Count <= livello + 1)
            {
                MessageBox.Show("HAI COMPLETATO IL GIOCO!!");
                Close();
            }
            else
                CaricaLivello(livello + 1);
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            tempo++;
            lblTempo.Text = Convert.ToString(TimeSpan.FromSeconds(tempo));
            TriggerZone();            
        }
    }
}