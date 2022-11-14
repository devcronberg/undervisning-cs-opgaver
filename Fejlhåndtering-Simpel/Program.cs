using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using Polly; kræver Polly (NuGet)

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
                //BrugPolly();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl " + ex.Message);
            }

        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
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
        }

        //static void BrugPolly() { 
        //    Policy.Handle<FormatException>().Retry(3).Execute(Run);
        //}
    }

}
