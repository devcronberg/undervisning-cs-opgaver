using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.5398
            double res3 = BeregnBeløbEfterMoms(100, .25);
            Console.WriteLine(res3); // 125
            Udskriv("Dette er en test"); // Dette er en test


            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        static double BeregnBeløbEfterMoms(double tal, double momsPct)
        {
            return tal * (1 + momsPct);
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(double radius)
        {
            return (radius * radius) * 3.1415;
        }

        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }

    }
}
