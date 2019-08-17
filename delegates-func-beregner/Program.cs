using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_func_beregner
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = 0;
            res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            res = Beregner(1, 1, Minus);
            Console.WriteLine(res);

            var f = FindTilfældigFunktion();
            res = f(5, 5);
            Console.WriteLine(res);

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static Func<int, int, int> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;

            return Divider;

        }
    }
}
