using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociazioneCulturale
{
   
    abstract class Socio
    {
        protected string nome;
        protected int numeroTessera;
        protected static double quotabase;
        protected static double quotaeffettiva=0;
        protected string carica;
        protected string annoIscrizione;
        public string Nome
        {
            get => nome;
            set => nome =value;
        }

        public int Numerotessera
        {
            get => numeroTessera;
            set => numeroTessera = value;
        }

        public string Carica
        {
            get => carica;
            set => carica = value;
        }

        public string Annoiscrizione
        {
            get => annoIscrizione;
            set => annoIscrizione = value;
        }

        public Socio(string n,int numT, string c, string annoI, double quotae)
        {
            nome = n;
            numeroTessera = numT;
            carica = c;
            quotabase = 100;
            quotaeffettiva = quotae;
            annoIscrizione = annoIscrizione;
        }

        public abstract double CalcolaQuota();

        public override string ToString()
        {
            return numeroTessera + " | " + Nome + " | " + carica + " | " + annoIscrizione + " | " + String.Format("{0:C2}", CalcolaQuota());
        }

    }
}
