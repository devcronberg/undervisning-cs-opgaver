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
            res = HentVærdiFraDb(1);
            Console.WriteLine($"resultat = {res}");

            res = HentVærdiFraDb(2);
            Console.WriteLine($"resultat = {res}"); 

            res = HentVærdiFraDb(3);
            Console.WriteLine($"resultat = {res}");

            Person p = HentPersonFraDb(1);
            Console.WriteLine(p.Navn);
            Console.WriteLine(p.Fødselsdato.HasValue);
            try
            {
                p = HentPersonFraDb(2);
            }
            catch (Exception)
            {
                Console.WriteLine("Fejl");
                
            }


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }


        static bool? HentVærdiFraDb(int id)
        {
            if (id == 1)
                return true;
            if (id == 2)
                return false;
            return null;
        }

        static Person HentPersonFraDb(int personId)
        {
            if (personId == 1) {
                return new Person {
                    PersonId =1,
                    Navn = "a",
                    ErILive = null,
                    Fødselsdato = null
                };
            }
            throw new ApplicationException("Person findes ikke");
        }
    }

    class Person {

        public int PersonId { get; set; }
        public string Navn { get; set; }
        public DateTime? Fødselsdato { get; set; }
        public bool? ErILive { get; set; }

    }
}
