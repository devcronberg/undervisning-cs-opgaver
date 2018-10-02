using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_anonym
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic o1 = new { navn = "a", alder = 10 };
            Console.WriteLine($"Person hedder {o1.navn} og er {o1.alder}");
            SkrivPerson(o1);

            dynamic o2 = new ExpandoObject();
            o2.navn = "b";
            o2.alder = 20;
            Console.WriteLine($"Person hedder {o2.navn} og er {o2.alder}");
            SkrivPerson(o2);

        }

        static void SkrivPerson(dynamic obj)
        {
            Console.WriteLine($"Person hedder {obj.navn} og er {obj.alder}");

        }


    }
}
