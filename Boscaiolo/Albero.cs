using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boscaiolo
{
    enum tipoalbero
    {
        acero,
        faggio,
        alberodellavita
    }
    class Albero
    {
        public readonly tipoalbero tipo;
        public int altezza;
        public int eta;
        private Random r = new Random();

        public Albero()
        {
            tipo = (tipoalbero) r.Next(3);
            altezza =  r.Next(20);
            eta =  r.Next(50);
        }
    }
}
