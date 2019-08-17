using System;


namespace operatoroverload_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund() { Navn = "A", LydNiveau = 30 };
            Hund h2 = new Hund() { Navn = "B", LydNiveau = 20 };
            Console.WriteLine(h1 > h2);

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Hund
    {
        public static bool operator >(Hund o1, Hund o2)
        {
            return o1.LydNiveau > o2.LydNiveau;
        }
        public static bool operator <(Hund o1, Hund o2)
        {
            return o1.LydNiveau > o2.LydNiveau;
        }

        public string Navn { get; set; }
        public int LydNiveau { get; set; }
    }

}
