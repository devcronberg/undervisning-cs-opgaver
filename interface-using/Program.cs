using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_using
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader stream = System.IO.File.OpenText(@"c:\temp\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    var l = stream.ReadLine();
                    Console.WriteLine(l.ToUpper());
                }

                // Hold console åben ved debug
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    Console.Write("Press any key to continue . . . ");
                    Console.ReadKey();
                }
            }

        }
    }
}
