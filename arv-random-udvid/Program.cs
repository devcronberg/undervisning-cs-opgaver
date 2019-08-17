using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) < 501;
        }
    }
}
