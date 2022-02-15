using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boscaiolo
{
    public partial class Form1 : Form
    {
        Albero[] v= new Albero[1000];
        Boscaiolo b = new Boscaiolo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pctAlbero.Image = Image.FromFile("IMMAGINI\\foresta.jpg");
            pctBoscaiolo.Image = Image.FromFile("IMMAGINI\\boscaiolo.jpg");
            pctAscia.Image = Image.FromFile("IMMAGINI\\ascia.gif");
            
        }

        private void btnGeneraForesta_Click(object sender, EventArgs e)
        {
            bool flag=false;
            Albero a;
            int i;
            for ( i=0; i<1000; i++)
            {
                v[i] = new Albero();
                /*if (v[i].tipo == tipoalbero.alberodellavita)
                    if (flag == false)
                        flag = true;
                    else
                    {
                        a = new Albero();
                        while (a.tipo == tipoalbero.alberodellavita)
                        {
                            a = new Albero();
                        }
                        v[i] = a;
                    }  */ 
            }
        }

        private void btnTagliaAlberi_Click(object sender, EventArgs e)
        {
            foreach (Albero item in v)
            {
                if(item.tipo==tipoalbero.acero)
                {
                    lblAceri.Visible = false;
                    b.AceriAbbattuti++;
                    lblAceri.Text = Convert.ToString(b.AceriAbbattuti);
                    lblAceri.Visible = true;

                    lblAlberiTagliati.Visible = false;
                    b.AlberiAbbattuti++;
                    lblAlberiTagliati.Text = Convert.ToString(b.AlberiAbbattuti);
                    lblAlberiTagliati.Visible = true;

                    lblMetriSeccati.Visible = false;
                    b.MetriSeccati += item.altezza;
                    lblMetriSeccati.Text = Convert.ToString(b.MetriSeccati);
                    lblMetriSeccati.Visible = true;
                }
                else
                    if(item.tipo==tipoalbero.faggio)
                    {
                        lblFaggi.Visible = false;
                        b.FaggiAbbattuti++;
                        lblFaggi.Text = Convert.ToString(b.FaggiAbbattuti);
                        lblAceri.Visible = true;

                        lblAlberiTagliati.Visible = false;
                        b.AlberiAbbattuti++;
                        lblAlberiTagliati.Text = Convert.ToString(b.AlberiAbbattuti);
                        lblAlberiTagliati.Visible = true;

                        lblMetriSeccati.Visible = false;
                        b.MetriSeccati += item.altezza;
                        lblMetriSeccati.Text = Convert.ToString(b.MetriSeccati);
                        lblMetriSeccati.Visible = true;
                    }
                    else
                    {
                        lblAceri.Visible = true;
                        lblAlberiTagliati.Visible = true;
                        lblMetriSeccati.Visible = true;
                        lblVita.Text = "Il boscaiolo ha riacquistato la vista !";
                    }

             }
        }
    }
}
