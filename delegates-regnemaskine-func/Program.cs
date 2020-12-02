using System;

namespace delegates_regnemaskine_func
{
    class Program
    {
        static void Main(string[] args)
        {
            RegnemaskineApp.RegnemaskineConsoleUI r =
                new RegnemaskineApp.RegnemaskineConsoleUI();
            r.TilføjBeregning("minus", Minus);
            r.TilføjBeregning("gange", Gange);
            // Nyt delegate objekt gemmes i variabel
            Func<int, int, int> f = Divider;
            r.TilføjBeregning("divider", f);
            // Metode fra System.Math
            r.TilføjBeregning("max", Math.Max);

            r.Start();
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
    }
}
