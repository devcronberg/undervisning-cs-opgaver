using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linq2xml_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            // forudsætter personer.xml i /bin
            XDocument doc = XDocument.Load(@"personer.xml");
            VisAllePersoner(doc);
            Console.WriteLine();
            VisAllePersonerSorteret(doc, "navn");
            Console.WriteLine();
            Console.WriteLine(FindNavn(doc, 1));

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            void VisAllePersoner(XDocument d)
            {
                var elementer = d.Descendants("person");
                foreach (var person in elementer)
                    Console.WriteLine(person.Element("navn").Value);
            }

            void VisAllePersonerSorteret(XDocument d, string sorterEfter)
            {
                var elementer = d.Descendants("person").OrderBy(i => i.Element(sorterEfter).Value);
                foreach (var person in elementer)
                    Console.WriteLine(person.Element("navn").Value);
            }

            string FindNavn(XDocument d, int id)
            {
                var elementer = d.Descendants("person").Where(i => (int)i.Attribute("id") == id);
                return elementer.FirstOrDefault()?.Element("navn").Value ?? "?";
            }

        }
    }
}
