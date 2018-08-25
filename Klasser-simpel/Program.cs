using System;

namespace Teknologisk.MinApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Efternavn = "cronberg";
            p1.Fornavn = "mathias";
            p1.Fødselsår = 2006;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());


            Person p2 = new Person("mikkel", "cronberg", 2006);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        // default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        // Custom constructor
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
    }
}

