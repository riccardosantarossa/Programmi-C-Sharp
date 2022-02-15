using System;

namespace CiaoZombie
{
    class Program
    {
        public class Zombie
        {
            public int cervelliMangiati;
            public string nome;

            private Enum Status
            {
               non_morto,
               morto_morto,
            }
            public Zombie()
            {
                nome = "MrDead";
            }
            static void Parla()
            {
                Console.Write("gnnrrrnggg");      
            }

            static void MangiaCervelli()
            {
                cervelliMangiati++;
            }
            static void Main(string[] args)
            {
                Random rnd = new Random();
                Zombie z = new Zombie();
                int n;

                Console.WriteLine("Lo zombie si chiama " + z.nome);
                Parla();
                z.cervelliMangiati =0;
                n = rnd.Next(11);
                for(int i=0; i<n;i++)
                {
                    MangiaCervelli();
                }
                Console.WriteLine("Lo zombie " + z.nome + " ha mangiato " + z.cervelliMangiati);


                
            }
        }
    }
}
