using System;

namespace ConsoleApplication6
{

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Mikkel";
            p.Efternavn = "Cronberg";
            Console.WriteLine(p.FuldtNavn());

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length < 3)
                {
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }
            }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

}
