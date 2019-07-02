using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace delegates_lambda_beregner
{
    class Program
    {
        // Se bemærkning i opgaven:
        //static Func<int, int, int> plus = (a, b) => a + b;
        //static Func<int, int, int> minus = (a, b) => a - b;
        //static Func<int, int, int> gange = (a, b) => a * b;
        //static Func<int, int, int> divider = (a, b) => a / b;

        static async Task Main(string[] args)
        {

            int res = 0;
            res = Beregner(1, 1, (a, b) => a + b);
            Console.WriteLine(res);
            res = Beregner(2, 1, (a, b) => a - b);
            Console.WriteLine(res);
            res = Beregner(2, 2, (a, b) => a * b);
            Console.WriteLine(res);
            res = Beregner(4, 2, (a, b) => a / b);
            Console.WriteLine(res);

            var f = FindTilfældigFunktion();
            res = f(10, 5);
            Console.WriteLine(res);

            f = FindTilfældigFunktion2((a, b) => a + b, (a, b) => a - b, (a, b) => a * b, (a, b) => a / b);
            res = f(10, 5);
            Console.WriteLine(res);


            // Avanceret brug af expressions (det skal du ikke kunne - det er blot til orientering)
            await Tilføjelse.Ekstra();

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

        public static Func<int, int, int> FindTilfældigFunktion2(params Func<int, int, int>[] funktioner)
        {
            System.Random rnd = new Random();
            int nr = rnd.Next(0, funktioner.Length);
            return funktioner[nr];
        }


    }
}
