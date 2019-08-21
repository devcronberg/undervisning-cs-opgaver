using System;

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

            Console.ReadKey();
        }
    }

    public class Bæger
    {
        private Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
                terninger[i] = new Terning();
            Ryst();
        }

        public void Ryst()
        {
            for (int i = 0; i < 5; i++)
                terninger[i].Ryst();
        }

        public void Skriv()
        {
            for (int i = 0; i < 5; i++)
                terninger[i].Skriv();
            Console.WriteLine();
        }
    }


public class Terning
{
    // Ved .NET Core behøver den ikke være statisk!!
    private static Random rnd = new Random();
    public int værdi;

    public Terning()
    {
        this.værdi = 1;
    }

    public void Skriv()
    {
        Console.Write("[" + this.værdi + "]");
    }

    public void Ryst()
    {
        this.værdi = rnd.Next(1, 7);
    }
}
}
