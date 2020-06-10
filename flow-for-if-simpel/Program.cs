using System;

namespace flow_for_if_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tæl fra 0 til 9
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Tæl fra 1 - 20 men kun hver anden (1-3-5-7...)
            for (int i = 1; i < 21; i+=2)
            {
                Console.WriteLine(i);
            }

            // Tæl fra 1 - 20. Lige tal skal være gule og ulige tal røde
            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }

        }
    }
}
