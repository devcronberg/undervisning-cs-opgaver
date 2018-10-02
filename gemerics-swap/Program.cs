using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gemerics_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 1;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Swap<int>(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            string z = "a";
            string w = "b";
            Console.WriteLine(z);
            Console.WriteLine(w);
            Swap(ref z, ref w);
            Console.WriteLine(z);
            Console.WriteLine(w);

        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
