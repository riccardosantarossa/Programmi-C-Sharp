using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociazioneCulturale
{
    class SocioFondatore : Socio
    {
        public string codFiscale;

        public string Codfiscale
        {
            get => codFiscale;
            set => codFiscale = value;
        }

        public SocioFondatore(string n, int numT, string c, string annoI, double quotae, string codF) : base(n,numT,c,annoI,quotae)
        {
            codFiscale = codF;
            quotaeffettiva = quotae;
        }

        public override double CalcolaQuota()
        {
            return quotabase * 0.5;
        }

        public override string ToString()
        {
            return base.ToString() + " | " + codFiscale;
        }
    }

}
