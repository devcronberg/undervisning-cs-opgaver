using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_statisk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beregninger b = new Beregninger(); fejl
            int res = Beregninger.LægSammen(1, 1);
            Console.WriteLine(res);

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public static class Beregninger {
        public static int LægSammen(int a, int b) {
            return a + b;
        }
        public static int TrækFra(int a, int b)
        {
            return a - b;
        }

        private Beregninger()
        {

        }
    }
}
