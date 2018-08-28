using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabler_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? res;
            res = HentFraDb(1);
            Console.WriteLine($"resultat = {res}");

            res = HentFraDb(2);
            Console.WriteLine($"resultat = {res}"); 

            res = HentFraDb(3);
            Console.WriteLine($"resultat = {res}");


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }


        static bool? HentFraDb(int id)
        {
            if (id == 1)
                return true;
            if (id == 2)
                return false;
            return null;
        }
    }
}
