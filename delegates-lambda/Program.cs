using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine();
            Console.WriteLine(a.FindIndex(FindVærdi));
            Console.WriteLine(a.FindIndex((i) => { return i == 51; }));
            Console.WriteLine(a.FindIndex(i => i == 51));

            Console.WriteLine();
            a.ForEach(ListVærdi);
            Console.WriteLine();
            a.ForEach(i => { Console.WriteLine(i); });

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }


        static bool FindVærdi(int i)
        {
            return i == 51;
        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }

    }
}
