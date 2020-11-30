using System;

namespace delegates_regnemaskine_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            RegnemaskineApp.RegnemaskineConsoleUI r =
                new RegnemaskineApp.RegnemaskineConsoleUI();
            // Nyt delegate objekt med lang syntaks
            r.TilføjBeregning("minus", new RegnemaskineApp.BeregnDelegate(Minus));
            // Nyt delegate objekt med kort syntaks
            r.TilføjBeregning("gange", Gange);
            // Nyt delegate objekt gemmes i variabel
            RegnemaskineApp.BeregnDelegate f = new RegnemaskineApp.BeregnDelegate(Divider);
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

