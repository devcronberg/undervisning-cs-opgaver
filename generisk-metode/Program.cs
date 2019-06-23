using System;
using System.Collections.Generic;

namespace generisk_metode
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lst1 = new List<int>() { 5, 1, 41, 5, 21, 2, 61, 5 };
            List<char> lst2 = new List<char>() { 'b', 'c', 'h', 'r' };
            List<string> lst3 = new List<string>() { "a", "", "c" };
            List<Hund> lst4 = new List<Hund>() { new Hund { AntalBen = 4, Navn = "F" }, new Hund { AntalBen = 3, Navn = "A" } };

            // Ikke generisk
            Console.WriteLine(AntalMaxInt(lst1, 20));

            // Generisk
            Console.WriteLine(AntalMax(lst1, 20));
            Console.WriteLine(AntalMax(lst2, 'h'));
            Console.WriteLine(AntalMax(lst3, "b"));
            Console.WriteLine(AntalMax(lst4, new Hund { Navn = "A" }));

        }

        static int AntalMax<T>(IEnumerable<T> liste, T maxVærdi) where T : IComparable<T>
        {
            int antal = 0;
            foreach (T t in liste)
            {
                if (t.CompareTo(maxVærdi) > 0)
                    antal++;
            }
            return antal;
        }

        static int AntalMaxInt(IEnumerable<int> liste, int maxVærdi)
        {
            int antal = 0;
            foreach (int t in liste)
            {
                if (t.CompareTo(maxVærdi) > 0)
                    antal++;
            }
            return antal;
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
