using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_yatzybaeger
{
    class Program
    {
        static void Main(string[] args)
        {
Bæger b = new Bæger();
b.Skriv();
b.Ryst();
b.Skriv();
        }
    }

    public class Bæger
    {
        private Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
                terninger[i] = new Terning();

        }

        public void Ryst()
        {
            for (int i = 0; i < 5; i++)
                terninger[i].Ryst();
        }

        public void Skriv()
        {
            for (int i = 0; i < 5; i++)
                Console.Write(terninger[i].ToString());
            Console.WriteLine();
        }
    }


    public class Terning
    {
        private static System.Random rnd = new Random();
        private int _værdi;

        public int Værdi
        {
            get
            {

                return this._værdi;
            }

            set
            {
                if (value < 1 || value > 6)
                    throw new ApplicationException("Forkert værdi på terning");

                this._værdi = value;
            }
        }


        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }



        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"[{this.Værdi}]";
        }
    }
}
