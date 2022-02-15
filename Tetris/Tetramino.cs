using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    enum TipoTetramino
    {
        T,
        L,
        I,
        O,
        J,
        Z,
        S
    }

    class Tetramino
    {
        public  Point position;
        private int angolo;
        private TipoTetramino tipoTetramino;
        private static Random random=new Random();
        private Panel panelContenitore;
        public readonly Panel[] panels=new Panel[4];

        public Tetramino(Panel panelContenitore)
        {
            position = new Point();
            position.X = position.Y= angolo = 0;
            tipoTetramino =(TipoTetramino)random.Next(Enum.GetNames(typeof(TipoTetramino)).Length);
            this.panelContenitore = panelContenitore;

            int[,] struttura = this.getStruttura();
            int incr = 0;
            for (int riga = 0; riga < struttura.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < struttura.GetLength(1); colonna++)
                {
                    if (struttura[riga, colonna] == 1)
                    {
                        
                        panels[incr] = new Panel();
                        panels[incr].BackColor = this.getColor();
                        panels[incr].Location = new Point(Config.sizeTetramini * (this.position.X + colonna), Config.sizeTetramini * (this.position.Y + riga));
                        panels[incr].Size = new Size(Config.sizeTetramini, Config.sizeTetramini);
                        panels[incr].BorderStyle = BorderStyle.Fixed3D;
                        this.panelContenitore.Controls.Add(panels[incr]);
                        incr++;
                    }
                }
            }
        }


        public void update()
        {
            int[,] struttura = this.getStruttura();
            int incr = 0;
            for (int riga = 0; riga < struttura.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < struttura.GetLength(1); colonna++)
                {
                    if (struttura[riga, colonna] == 1)
                    {
                        
                        panels[incr].Location = new Point(Config.sizeTetramini * (this.position.X + colonna), Config.sizeTetramini * (this.position.Y + riga));
                        incr++;
                    }
                }
            }
        }

        public void routa()
        {
            angolo += 90;
            angolo %= 360;
        }
        public void routaBack()
        {
            angolo -= 90;
            angolo %= 360;
        }
        private int getDim(bool width)
        {
            //cheat, vedi sotto
            if (width && (tipoTetramino == TipoTetramino.Z|| tipoTetramino == TipoTetramino.S) && (angolo == 0 || angolo == 180))
                return 3;
            if (width && (tipoTetramino == TipoTetramino.Z || tipoTetramino == TipoTetramino.S) && (angolo == 90 || angolo == 270))
                return 2;
            if (!width && (tipoTetramino == TipoTetramino.Z || tipoTetramino == TipoTetramino.S) && (angolo == 0 || angolo == 180))
                return 2;
            if (!width && (tipoTetramino == TipoTetramino.Z || tipoTetramino == TipoTetramino.S) && (angolo == 90 || angolo == 270))
                return 3;
            //algoritmo errato, da fare patendo dall'ultimo elemento.La S sennò non va e per ora metto il cheat
            int[,] blocchetti = getStruttura();
            int contatore = 0;
            int larghezza = 0;
            for (int riga = 0; riga < blocchetti.GetLength(0); riga++)
            {
                contatore = 0;
                for (int colonna = 0; colonna < blocchetti.GetLength(1); colonna++)
                {
                    if (width && blocchetti[riga,colonna] == 1)
                    {
                        contatore++;
                    }
                    else if (!width && blocchetti[colonna,riga] == 1)
                    {
                        contatore++;
                    }
                }
                if (contatore > larghezza)
                    larghezza = contatore;
            }
            return larghezza;
        }

        public int getWidth()
        {
            return getDim(true);
        }

        public int getHeight()
        {
            return getDim(false);
        }


        public int[,] getStruttura()
        {
            int[,] blocchetti = new int[4, 4];

            switch (tipoTetramino)
            {
                case TipoTetramino.O:
                    blocchetti = new int[4, 4]{    { 1, 1, 0, 0 },
                                                   { 1, 1, 0, 0 },
                                                   { 0, 0, 0, 0 },
                                                   { 0, 0, 0, 0 } };
                    break;
                case TipoTetramino.I:
                    if (angolo == 0 || angolo == 180)
                    {
                        blocchetti = new int[4, 4]{ { 1, 0, 0, 0 },
                                                   { 1, 0, 0, 0 },
                                                   { 1, 0, 0, 0 },
                                                   { 1, 0, 0, 0 } };
                    }
                    else
                    {
                        blocchetti = new int[4, 4]{ { 1, 1, 1, 1 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    break;
                case TipoTetramino.J:
                    if (angolo == 0)
                    {
                        blocchetti = new int[4, 4]{ { 0, 1, 0, 0 },
                                                     { 0, 1, 0, 0 },
                                                     { 1, 1, 0, 0 },
                                                     { 0, 0, 0, 0 } };
                    }
                    else if (angolo == 90)
                    {
                        blocchetti = new int[4, 4]{ { 1, 0, 0, 0 },
                                                    { 1, 1, 1, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else if (angolo == 180)
                    {
                        blocchetti = new int[4, 4]{ { 1, 1, 0, 0 },
                                                    { 1, 0, 0, 0 },
                                                    { 1, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else
                    {
                        blocchetti = new int[4, 4]{ { 1, 1, 1, 0 },
                                                    { 0, 0, 1, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    break;

                case TipoTetramino.L:
                    if (angolo == 0)
                    {
                        blocchetti = new int[4, 4]{ { 1, 0, 0, 0 },
                                                    { 1, 0, 0, 0 },
                                                    { 1, 1, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else if (angolo == 90)
                    {
                        blocchetti = new int[4, 4]{ { 1, 1, 1, 0 },
                                                    { 1, 0, 0, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else if (angolo == 180)
                    {
                        blocchetti = new int[4, 4]{ { 1, 1, 0, 0 },
                                                    { 0, 1, 0, 0 },
                                                    { 0, 1, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else
                    {
                        blocchetti = new int[4, 4]{ { 0, 0, 1, 0 },
                                                    { 1, 1, 1, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    break;
                case TipoTetramino.T:
                    if (angolo == 0)
                    {
                        blocchetti = new int[4, 4]{ { 0, 1, 0, 0 },
                                                    { 1, 1, 1, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else if (angolo == 90)
                    {
                        blocchetti = new int[4, 4]{ { 1, 0, 0, 0 },
                                                    { 1, 1, 0, 0 },
                                                    { 1, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else if (angolo == 180)
                    {
                        blocchetti = new int[4, 4]{ { 1, 1, 1, 0 },
                                                    { 0, 1, 0, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else
                    {
                        blocchetti = new int[4, 4]{ { 0, 1, 0, 0 },
                                                    { 1, 1, 0, 0 },
                                                    { 0, 1, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    break;
                case TipoTetramino.S:
                    if (angolo == 0 || angolo == 180)
                    {
                        blocchetti = new int[4, 4]{ { 0, 1, 1, 0 },
                                                    { 1, 1, 0, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else
                    {
                        blocchetti = new int[4, 4]{ { 1, 0, 0, 0 },
                                                    { 1, 1, 0, 0 },
                                                    { 0, 1, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    break;
                case TipoTetramino.Z:
                    if (angolo == 0 || angolo == 180)
                    {
                        blocchetti = new int[4, 4]{ { 1, 1, 0, 0 },
                                                    { 0, 1, 1, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    else
                    {
                        blocchetti = new int[4, 4]{ { 0, 1, 0, 0 },
                                                    { 1, 1, 0, 0 },
                                                    { 1, 0, 0, 0 },
                                                    { 0, 0, 0, 0 } };
                    }
                    break;
            }

            return blocchetti;
        }

        public Color getColor()
        {
            switch (tipoTetramino)
            {
                case TipoTetramino.T:
                    return Color.Violet;
                case TipoTetramino.L:
                    return Color.OrangeRed;
                case TipoTetramino.I:
                    return Color.BlueViolet;
                case TipoTetramino.O:
                    return Color.LightGoldenrodYellow;
                case TipoTetramino.J:
                    return Color.DarkBlue;
                case TipoTetramino.Z:
                    return Color.DarkRed;
                case TipoTetramino.S:
                    return Color.DarkGreen;
            }
            return Color.Pink;
        }
    }
}
