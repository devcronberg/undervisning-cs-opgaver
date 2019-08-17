using System;
namespace MinApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine($"Heltal = {heltal}");

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine($"Kommatal = {kommatal}");


            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

}
