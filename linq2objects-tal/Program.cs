using System;
using System.Linq;

namespace linq2objects_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 7, 2, 6, 7, 3, 5, 7, 8, 2, 5, 4, 1 };

            Console.WriteLine(a.Count());
            Console.WriteLine(a.Count(i => i == 7));
            Console.WriteLine(a.Sum());
            Console.WriteLine(a.Average());
            Console.WriteLine(string.Join(' ', a.OrderBy(i=>i)));
            Console.WriteLine(string.Join(' ', a.Where(i => i > 5)));
            Console.WriteLine(string.Join(' ', a.Take(5).ToList()));
            Console.WriteLine(string.Join(' ', a.Skip(5).Take(5).ToList()));
            


        }
    }
}
