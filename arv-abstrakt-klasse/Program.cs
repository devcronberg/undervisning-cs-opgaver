using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv_abstrakt_klasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Kursist k = new Kursist() { Id = 1, Navn = "a" };
            k.Skriv1();
            k.Skriv2();

        }
    }

    abstract class Person
    {

        public int Id { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine($"Person med id {Id} og navn {Navn}");
        }

        public abstract void Skriv2();
    }

    class Kursist : Person
    {
        public override void Skriv2()
        {
            Console.WriteLine($"Kursist med id {Id} og navn {Navn}");
        }
    }
}
