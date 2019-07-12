using System;

namespace start_afvikling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start")
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 1; i < 6; i++)
                Console.WriteLine(i);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Slut");
        }
    }
}
