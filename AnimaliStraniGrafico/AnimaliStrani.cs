using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaliStraniGrafico
{
    class AnimaliStrani
    {
        public enum Tipo
        {
            ippogrifo,
            pegaso,
            unicorno
        }
        public readonly string nome;
        public int energia, energiamax;
        public readonly bool volo;
        public readonly Tipo tipo;

        public AnimaliStrani()
        {
            tipo = (Tipo)(new Random()).Next(3);
            switch (tipo)
            {
                case Tipo.ippogrifo:
                    volo = true;
                    energia = energiamax = 120;
                    break;

                case Tipo.pegaso:
                    volo = true;
                    energia = energiamax = 80;
                    break;

                case Tipo.unicorno:
                    volo = false;
                    energia = energiamax = 100;
                    break;
            }
        }

        public int GetEnergiaMax() { return energiamax; }
        public int GetEnergia() { return energia; }
        public void DecEnergia() { energia -= 1; }
        public void Veleno() { energia -= 20; }
        public void AddEnergia() 
        {  
            if(energia<energiamax)
                energia += 1; 
        }
        public string GetStatus(AnimaliStrani a)
        {
            string stato, v;

            if (a.volo == true)
                v = " sa volare ";
            else
                v = " non sa volare ";

            if (a.energia > a.energiamax * 0.8)
                stato = " è sazio";
            else
                if (a.energia > a.energiamax * 0.4 && a.energia < a.energiamax * 0.79)
                stato = " ha fame";
            else
                    if (a.energia == 0)
                stato = " è morto ";
            else
                stato = "sta morendo di fame";

            return a.tipo + a.nome + " ha " + a.energia + " quindi " + stato + "." + v;
        }
    }
}
