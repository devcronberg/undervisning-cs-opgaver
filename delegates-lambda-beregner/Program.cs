using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_lambda_beregner
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = 0;
            res = Beregner(1, 1, (a, b) => a + b);
            Console.WriteLine(res);
            res = Beregner(1, 1, (a, b) => a - b);
            Console.WriteLine(res);

            var f = FindTilfældigFunktion();
            res = f(5, 5);
            Console.WriteLine(res);

        }

        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static Func<int, int, int> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return (a, b) => a + b;
            if (System.DateTime.Now.Millisecond <= 500)
                return (a, b) => a - b;
            if (System.DateTime.Now.Millisecond <= 750)
                return (a, b) => a * b;

            return (a, b) => a / b;

        }
    }
}
