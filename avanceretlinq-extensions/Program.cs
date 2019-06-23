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


            Console.WriteLine();
            List<Hund> lst2 = new List<Hund>() {
                new Hund { AntalBen = 4, Navn = "F" },
                new Hund { AntalBen = 3, Navn = "A" },
                new Hund { AntalBen = 4, Navn = "C"} };

            foreach (var item in lst2.HverAnden())
                Console.WriteLine(item.Navn);
            Console.WriteLine();
            foreach (var item in lst2.Where(i => i.AntalBen > 2, 1))
                Console.WriteLine(item.Navn);

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

    class Hund : IComparable<Hund>
    {
        public int AntalBen { get; set; }
        public string Navn { get; set; }

        public int CompareTo(Hund other)
        {
            return this.Navn.CompareTo(other.Navn);
        }
    }
}
