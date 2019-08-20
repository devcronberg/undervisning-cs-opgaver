using System;
using System.Collections.Generic;

namespace Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lst1 = new List<int>();
            lst1.Add(3);
            lst1.Add(1);
            lst1.Add(8);
            foreach (var item in lst1)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> lst2 = new Dictionary<int, string>();
            lst2.Add(1, "M");
            lst2.Add(2, "T");
            lst2.Add(3, "P");
            var p = lst2[3];
            Console.WriteLine(p);

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
     
}
