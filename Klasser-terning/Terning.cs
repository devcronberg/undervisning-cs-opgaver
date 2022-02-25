using System;

namespace Klasser_terning
{
    public class Terning
    {

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
            this.værdi = 1;
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            Random rnd = new Random();
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }
    }
}
