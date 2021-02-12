using System;
using System.Collections.Generic;

namespace delegates_array_predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            
            Console.WriteLine(a.FindIndex(FindVærdi));

            Console.WriteLine();
            a.ForEach(ListVærdi);

        }


        static bool FindVærdi(int i)
        {
            return i == 51;
        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }

    }
}
