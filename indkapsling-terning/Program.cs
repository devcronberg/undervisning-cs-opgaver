using System;

namespace MinTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Værdi = 7;
            t.Skriv();
            t = new Terning(6);
            t.Skriv();

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Terning
    {
        private static System.Random rnd = new Random();
        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

    }
}
