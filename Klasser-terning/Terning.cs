using System;

namespace Klasser_terning
{
    public class Terning
    {
        private static Random rnd = new Random();
        public int værdi;
        private bool snyd;

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
            Ryst();
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }
    }
}
