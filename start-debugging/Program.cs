using System;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Debug demo");

            // Variabel
            int x = 10;
            Console.WriteLine($"x = {x}");
            x++;
            Console.WriteLine($"x = {x}");
            x = x * 2;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("Tæller til 10 og retter farve");
            for (int i = 0; i < 4; i++)
            {
                if (i < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            // Kalder metode
            int res = LæggerToTalSammen(2, 2);
            Console.WriteLine($"Resultat = {res}");

            // kalder metode (der kalder metode)
            MetodeA();

            // Break ud i kode er også muligt
            // System.Diagnostics.Debugger.Break();

        }

        static int LæggerToTalSammen(int a, int b)
        {
            return a + b;
        }

        static void MetodeA()
        {
            Console.WriteLine("I metode A");
            MetodeB();
        }
        static void MetodeB()
        {
            Console.WriteLine("I metode B");
            MetodeC();
        }
        static void MetodeC()
        {
            Console.WriteLine("I metode C");
        }

    }
}