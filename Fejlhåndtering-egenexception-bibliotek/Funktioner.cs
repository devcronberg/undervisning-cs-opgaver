using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlhåndtering_egenexception_bibliotek
{
    public static class Funktioner
    {
        public static void OpdaterTal(string sti) {

            
            if (!System.IO.File.Exists(sti))
                throw new ApplicationException("Filen " + sti + " kan ikke findes");

            string indhold = "";
            try
            {
                indhold = System.IO.File.ReadAllText(sti);
                int tal = Convert.ToInt32(indhold);
                tal++;
                System.IO.File.WriteAllText(sti, tal.ToString());
                Console.WriteLine($"Tal i fil er nu {tal}");
            }
            catch (System.FormatException)
            {
                throw new ApplicationException($"'{indhold}' kan ikke konverteres til et heltal");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
