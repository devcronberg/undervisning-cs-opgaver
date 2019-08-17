using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlhåndtering_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
                //PrøvIgen();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl " + ex.Message);
            }

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + tal1 + tal2);
        }

        static void PrøvIgen()
        {
            int prøvAntalGange = 3;
            int antal = 0;
            while (antal < prøvAntalGange)
            {
                try
                {
                    Run();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Der er sket en fejl " + ex.Message);
                    antal++;
                }
            }


            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}
