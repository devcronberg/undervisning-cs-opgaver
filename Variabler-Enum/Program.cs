using System;

namespace Variabler_Enum
{

    class Program
    {
        static void Main(string[] args)
        {

            // Hjerter 2
            int kort1Værdi = 2;                         // værdi
            KortKulør kort1Kulør = KortKulør.Hjerter;   // kulør

            // Skriver "Hjerter 2"
            Console.WriteLine(kort1Kulør.ToString() + " " + kort1Værdi);

            // Ruder 2
            int kort2Værdi = 2;
            KortKulør kort2Kulør = KortKulør.Ruder;

            // Skriver "Ruder 2"
            Console.WriteLine(kort2Kulør.ToString() + " " + kort2Værdi);

            
            // udskriv tallet der svarer til ruder 
            Console.WriteLine(Convert.ToInt32(kort2Kulør));     // 2
            
        }
    }
}
