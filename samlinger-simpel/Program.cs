using System;
using System.Collections.Generic;

namespace Samlinger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> lst1 = new List<int>();
            lst1.Add(3);
            lst1.Add(1);
            lst1.Add(8);
            foreach (var item in lst1)
            {
                Console.WriteLine(item);
            }

            Stack<DateTime> lst2 = new Stack<DateTime>();
            lst2.Push(new DateTime(2018, 1, 1));
            lst2.Push(new DateTime(2019, 1, 1));
            lst2.Push(new DateTime(2020, 1, 1));
            foreach (var item in lst2)
            {
                Console.WriteLine(item);
            }
            DateTime d = lst2.Pop();
            Console.WriteLine(d);

            Dictionary<int, string> lst3 = new Dictionary<int, string>();
            lst3.Add(1, "M");
            lst3.Add(2, "T");
            lst3.Add(3, "P");
            var p = lst3[3];
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