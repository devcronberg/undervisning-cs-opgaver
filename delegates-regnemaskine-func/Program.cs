using System;

namespace delegates_regnemaskine_func
{
    class Program
    {
        static void Main(string[] args)
        {
            RegnemaskineApp.RegnemaskineConsoleUI r =
                new RegnemaskineApp.RegnemaskineConsoleUI();
            
            Func<int, int, int> f1 = Minus;            
            r.TilføjBeregning("minus", f1);
            // Eller blot
            // r.TilføjBeregning("minus", Minus);
            
            r.TilføjBeregning("gange", Gange);           
            r.TilføjBeregning("divider", Divider);
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
