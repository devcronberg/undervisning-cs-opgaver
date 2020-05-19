using System;


namespace Metoder_statisk
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = System.IO.File.Exists(@"c:\temp\test.txt");
            Console.WriteLine($"Findes fil: {t}");
            string indhold = System.IO.File.ReadAllText(@"c:\temp\test.txt");
            Console.WriteLine(indhold);

            var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
            DateTime d = fil.LastAccessTime;
            Console.WriteLine($"Tid: {d}");
            string ex = fil.Extension;
            Console.WriteLine($"Extension: {ex}");

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
}
