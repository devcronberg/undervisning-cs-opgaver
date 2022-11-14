using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using Polly; // Kræver Polly (Nuget) - lidt avanceret men blot til orientering

namespace Fejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {

            Simpel();
            //PrøvIgen();
            //BrugPolly();


        }

        private static void Simpel()
        {
            int tal1 = HentTal("Indtast 1. tal");
            int tal2 = HentTal("Indtast 2. tal");
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }

        private static int HentTal(string tekst)
        {
            try
            {
                Console.WriteLine(tekst);
                int tal = Convert.ToInt32(Console.ReadLine());
                return tal;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl " + ex.Message);
                throw;  // samme som throw ex;
            }
        }

        static void PrøvIgen()
        {
            int prøvAntalGange = 3;
            int antal = 0;
            while (antal < prøvAntalGange)
            {
                try
                {
                    int tal1 = HentTal("Indtast 1. tal");
                    int tal2 = HentTal("Indtast 2. tal");
                    int res = tal1 + tal2;
                    Console.WriteLine("resultatet er " + res);
                    break;
                }
                catch (Exception)
                {
                    antal++;
                }
            }
        }

        //static void BrugPolly()
        //{
        //    int tal1 = 0, tal2 = 0;
        //    Policy.Handle<FormatException>().Retry(3).Execute(() =>
        //    {
        //        tal1 = HentTal("Indtast 1. tal");
        //    });
        //    Policy.Handle<FormatException>().Retry(3).Execute(() =>
        //    {
        //        tal2 = HentTal("Indtast 2. tal");
        //    });
        //    int res = tal1 + tal2;
        //    Console.WriteLine("resultatet er " + res);

        //}
    }
}
