using System;
using System.Diagnostics;

namespace reflection_attributter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Log("Logges dette");
            Console.WriteLine("Slut");

            // Test();  giver kompileringsfejl på designtime
        }

        [Conditional("DEBUG")]
        static void Log(string tekst)
        {
            Console.WriteLine(tekst);
        }

        [Obsolete("Må ikke bruges", true)]
        static void Test()
        {
            Console.WriteLine("I Test()");
        }

    }
}
