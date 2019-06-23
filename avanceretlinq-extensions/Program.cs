using System;
using System.Collections.Generic;
using System.Linq;

namespace avanceretlinq_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>() { 5, 4, 2, 3, 7, 10, 2 };
            foreach (var item in lst1.HverAnden())
                Console.WriteLine(item);
            Console.WriteLine();
            foreach (var item in lst1.Where(i => i < 5, 2))
                Console.WriteLine(item);

        }
    }

    public static class MineExtensions
    {
        public static IEnumerable<T> HverAnden<T>(this IEnumerable<T> source)
        {
            List<T> list = new List<T>();

            int i = 0;

            foreach (var element in source)
            {
                if (i % 2 == 0)
                {
                    list.Add(element);
                }

                i++;
            }

            return list;
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> where, int take)
        {
            return source.Where(where).Take(take);
        }
    }
}
