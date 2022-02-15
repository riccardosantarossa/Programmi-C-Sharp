using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociazioneCulturale
{
    class GestioneAssociazione : List<Socio>
    {
         
        public void OrdinaNome()
        {
            Sort((s1, s2) => s1.Nome.CompareTo(s2.Nome));
        }

        public bool InserisciSocio(Socio socio)
        {
            Socio sTrovato = Find(s => s.Numerotessera == socio.Numerotessera);
            if (sTrovato == null)
            {
                Add(socio);
                return true;
            }
            else
                return false;
        }

        public void OrdinaTessera()
        {
            Sort((s1, s2) => s1.Numerotessera.CompareTo(s2.Numerotessera));
        }

        public void CercaTessera(int nT,GestioneAssociazione listaR)
        {
            listaR.Clear();
            listaR.AddRange(FindAll(Socio => Socio.Numerotessera ==nT));
        }

        public void CercaCarica(string c, GestioneAssociazione listaR)
        {
           listaR.Clear(); 
           listaR.AddRange(FindAll(Socio => Socio.Carica == c));
        }

    }
}
