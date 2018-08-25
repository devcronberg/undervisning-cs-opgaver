using System;

namespace MinApp
{
    class Program
    {
        static void Main(string[] args)
        {


            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);


            Person p;	// (eller Person p = new Person();)
            p.id = 1;
            p.navn = "Mikkel";
            Console.WriteLine(p.navn);


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    public struct Person
    {
        public int id;
        public string navn;
    }

    public enum FilTyper
    {
        pdf,
        txt,
        csv
    }
}
