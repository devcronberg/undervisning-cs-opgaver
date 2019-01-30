using System;

namespace Fejlhåndtering_egenexception_simpel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(SmartToUpper("mikkel"));
                Console.WriteLine(SmartToUpper("mAtHiAs"));

                // prøv også 
                Console.WriteLine(SmartToUpper(""));
                // eller
                Console.WriteLine(SmartToUpper(null));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl: " + ex.Message);
            }
        }

        private static string SmartToUpper(string tekst)
        {

            if (tekst == null)
            {
                throw new ApplicationException("tekst må ikke være null");
            }

            if (tekst == "")
            {
                throw new ApplicationException("tekst må ikke være tom");
            }

            string tmp = tekst.ToLower();
            string resultat = tmp.Substring(0, 1).ToUpper() + tmp.Substring(1);
            return resultat;
        }
    }
}
