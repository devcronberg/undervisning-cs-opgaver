using System;
using System.Net.Http.Headers;

namespace delegates_terning_ryst_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning(RystKunEtEllerSeks);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(t.Værdi);
                t.Ryst();
            }
            

        }

        static int RystKunSeks() {
            return 6;
        }
        static int RystKunEtEllerSeks()
        {
            // Enten 1 eller 2 som tilfældigt tal
            if (new Random().Next(1, 3) == 1)
                return 1;
            else
                return 6;
        }
        static int RystRandomOrg()
        {
            using (System.Net.WebClient w = new System.Net.WebClient())
            {
                string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
                return Convert.ToInt32(s);
            }
        }

    }

    public delegate int RystDelegate();

    public class Terning
    {

        public int Værdi { get; private set; }
        private RystDelegate rystMetode; 

        public void Ryst()
        {
            if (rystMetode != null)
                this.Værdi = rystMetode();
            else
                throw new ApplicationException("RystMetode ikke fundet!");

            if (this.Værdi < 1 || this.Værdi > 6)
                throw new ApplicationException("Forkert værdi fra RystMetode");
        }

        public Terning(RystDelegate rystMetode = null)
        {
            if (rystMetode == null)
                this.rystMetode = RystRandom;
            else
                this.rystMetode = rystMetode;
            Ryst();
        }

        private int RystRandom() {
            return new Random().Next(1, 7);
        }
    }

}
