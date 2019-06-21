using System;
using System.Collections.Generic;

namespace samlinger_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Fibonacci1(10))
            {
                Console.WriteLine(item);
            }

            foreach (var item in Fibonacci2(10))
            {
                Console.WriteLine(item);
            }

        }

        static IEnumerable<int> Fibonacci1(int count)
        {
            int prevFib1 = 1;
            int currFib1 = 1;
            List<int> lst = new List<int>();
            for (int i = 0; i < count; i++)
            {
                lst.Add(prevFib1);
                int newFib1 = prevFib1 + currFib1;
                prevFib1 = currFib1;
                currFib1 = newFib1;
            }
            return lst;
        }

        static IEnumerable<int> Fibonacci2(int count)
        {
            int prevFib2 = 1;
            int currFib2 = 1;
            for (int i = 0; i < count; i++)
            {
                yield return prevFib2;
                int newFib2 = prevFib2 + currFib2;
                prevFib2 = currFib2;
                currFib2 = newFib2;
            }
        }
    }
}
