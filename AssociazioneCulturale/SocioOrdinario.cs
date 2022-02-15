using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociazioneCulturale
{
    class SocioOrdinario : Socio
    {

        public SocioOrdinario(string n, int numT, string c, string annoI, double quotae) : base(n,numT,c,annoI,quotae)
        {
            annoIscrizione=annoI;
            quotaeffettiva = quotae;
        }

        public override double CalcolaQuota()
        {
            if (2021-int.Parse(annoIscrizione) >= 1)
                return quotabase * 0.9;
            else
                return quotabase;
        }

        public override string ToString()
        {
            return base.ToString() + " | " +  " | " + "";
        }
    }
}
