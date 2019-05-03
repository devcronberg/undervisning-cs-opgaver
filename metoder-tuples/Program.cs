using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            (double sum, double gns) resultat = FindSumOgGns(5.4, 10.5);
            Console.WriteLine($"Sum: {resultat.sum:n2}");
            Console.WriteLine($"Gns: {resultat.gns:n2}");

            // eller

            var resultat2 = FindSumOgGns(5.4, 10.5);
            Console.WriteLine($"Sum: {resultat2.sum:n2}");
            Console.WriteLine($"Gns: {resultat2.gns:n2}");

        }

        static (double sum, double gns) FindSumOgGns(double a, double b)
        {
            double s = a + b;
            double g = s / 2;
            return (s, g);
        }


    }
}
