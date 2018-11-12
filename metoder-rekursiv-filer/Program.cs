using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_rekursiv_filer
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFiler(@"c:\git");
        }

        static void PrintFiler(string sti) {
var filer = System.IO.Directory.GetFiles(sti);
foreach (string fil in filer)
    Console.WriteLine(fil);
var mapper = System.IO.Directory.GetDirectories(sti);
foreach (string mappe in mapper)
    PrintFiler(mappe);
        }
    }
}
