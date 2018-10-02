using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_brug_af_fileogdirectory
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine($"Eksisterer c:\\temp: {System.IO.Directory.Exists(@"c:\temp")}");
                foreach (var item in System.IO.Directory.GetFiles(@"c:\temp"))
                    Console.WriteLine(item);

                Console.WriteLine($"Eksisterer c:\\temp\\data.txt: {System.IO.File.Exists(@"c:\temp\data.txt")}");

                // Opret fil
                System.IO.File.WriteAllText(@"c:\temp\data.txt", "xxx");
                // Append
                System.IO.File.AppendAllText(@"c:\temp\data.txt", "yyy");
                // Hent
                string indhold = System.IO.File.ReadAllText(@"c:\temp\data.txt");
                Console.WriteLine(indhold);

                // Slet
                if (System.IO.File.Exists(@"c:\temp\data.txt"))
                    System.IO.File.Delete(@"c:\temp\data.txt");

            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
