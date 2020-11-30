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
