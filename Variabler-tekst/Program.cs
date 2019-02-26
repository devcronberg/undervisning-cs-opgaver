using System;

namespace Navn
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);
            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            string samletNavn2 = $"{fornavn} {efternavn}";

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
