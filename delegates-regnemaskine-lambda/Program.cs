using System;

namespace delegates_regnemaskine_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            RegnemaskineApp.RegnemaskineConsoleUI r =
                new RegnemaskineApp.RegnemaskineConsoleUI();
            r.TilføjBeregning("minus", (a, b) => a - b);
            r.TilføjBeregning("gange", (a, b) => a * b);
            // Nyt delegate objekt gemmes i variabel
            Func<int, int, int> f = (a, b) => a / b;
            r.TilføjBeregning("divider", f);
            // Metode fra System.Math
            r.TilføjBeregning("max", Math.Max);

            r.Start();
        }
    }
}

namespace RegnemaskineApp
{
    using System;
    using System.Collections.Generic;

    public class RegnemaskineConsoleUI
    {
        private Dictionary<string, Func<int, int, int>> beregninger { get; set; }

        public RegnemaskineConsoleUI()
        {
            beregninger = new Dictionary<string, Func<int, int, int>>();
            TilføjBeregning("plus", (a, b) => a + b);
        }

        public void TilføjBeregning(string navn, Func<int, int, int> funktion)
        {
            beregninger.Add(navn.ToLower(), funktion);
        }

        public void Start()
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("REGNEMASKINE");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("------------");
                    Console.WriteLine();
                    Console.WriteLine("Skriv navnet på en af følgende beregninger:");
                    foreach (var item in beregninger)
                    {
                        Console.WriteLine(" - " + item.Key);
                    }
                    Console.WriteLine();
                    string b = Console.ReadLine().ToLower();
                    if (!beregninger.ContainsKey(b))
                    {
                        Console.WriteLine("Beregning findes ikke");
                        return;
                    }
                    var beregning = beregninger[b];
                    Console.WriteLine("Indtast tal1:");
                    string tal1s = Console.ReadLine();
                    Console.WriteLine("Indtast tal2:");
                    string tal2s = Console.ReadLine();
                    int tal1 = Convert.ToInt32(tal1s);
                    int tal2 = Convert.ToInt32(tal2s);
                    int res = beregning(tal1, tal2);
                    Console.WriteLine("Resultatet er:");
                    Console.WriteLine(res);
                    Console.WriteLine("Tryk Esc for at afbryde eller en anden tast for at foretage ny beregning");
                    var tast = Console.ReadKey();
                    if (tast.Key == ConsoleKey.Escape)
                        break;

                } while (true);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hov - der er sket en fejl (" + ex.Message + ")");
                return;
            }
        }
    }
}
