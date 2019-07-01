using System;
using System.Threading.Tasks;

namespace delegates_lambda_beregner
{
    class Program
    {
        static async Task Main(string[] args)
        {

            int res = 0;
            res = Beregner(1, 1, (a, b) => a + b);
            Console.WriteLine(res);
            res = Beregner(1, 1, (a, b) => a - b);
            Console.WriteLine(res);

            var f = FindTilfældigFunktion();
            res = f(5, 5);
            Console.WriteLine(res);

            // Avanceret brug af expressions (det skal du ikke kunne - det er blot til orientering)
            // await Tilføjelse.Ekstra();
            
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
