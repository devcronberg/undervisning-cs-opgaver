using System;

namespace Variabler_Enum
{

    class Program
    {
        static void Main(string[] args)
        {

            int kort1Værdi = 2;
            KortKulør kort1Kulør = KortKulør.Hjerter;

            // Skriver værdi og nummer ud
            Console.WriteLine(kort1Kulør.ToString());
            Console.WriteLine((int)kort1Kulør);

            int kort2Værdi = 2;
            KortKulør kort2Kulør = KortKulør.Ruder;

            
        }
    }
}
