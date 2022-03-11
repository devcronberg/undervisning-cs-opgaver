using System;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action Test1 = () =>
            {
                Console.WriteLine("I Test 1 - a");
                Console.WriteLine("I Test 1 - b");
                Console.WriteLine("I Test 1 - c");
            };
            Test1();

            //Action<string> Test2 = (string txt) => {
            //    Console.WriteLine($"I Test 2 med {txt} - a");
            //    Console.WriteLine($"I Test 2 med {txt} - b");
            //    Console.WriteLine($"I Test 2 med {txt} - c");
            //};

            Action<string> Test2 = txt =>
            {
                Console.WriteLine($"I Test 2 med {txt} - a");
                Console.WriteLine($"I Test 2 med {txt} - b");
                Console.WriteLine($"I Test 2 med {txt} - c");
            };

            //Action<string, int> Test3 = (string txt, int n) => {
            //    Console.WriteLine($"I Test 3 med {txt} og {n} - a");
            //    Console.WriteLine($"I Test 3 med {txt} og {n} - b");
            //    Console.WriteLine($"I Test 3 med {txt} og {n} - c");
            //};

            Action<string, int> Test3 = (txt, n) =>
            {
                Console.WriteLine($"I Test 3 med {txt} og {n} - a");
                Console.WriteLine($"I Test 3 med {txt} og {n} - b");
                Console.WriteLine($"I Test 3 med {txt} og {n} - c");
            };

            //Action Test4 = () => {
            //    Console.WriteLine($"I Test 4");
            //};

            Action Test4 = () => Console.WriteLine($"I Test 4");

            //Action<string> Test5 = (string txt) => { 
            //    Console.WriteLine($"I Test 2 med {txt}"); 
            //};

            Action<string> Test5 = txt => Console.WriteLine($"I Test 5 med {txt}");

            Func<int> Test6 = () =>
            {
                Console.WriteLine($"I Test 6");
                return 1;
            };

            //Func<int> Test7 = () => { return 1; };
            Func<int> Test7 = () => 1;

            //Func<int, int> Test8 = (int a ) => { return a; };
            Func<int, int> Test8 = a => a;

            //Func<int, int, int> Test9 = (int a, int b) => { return a + b; };
            Func<int, int, int> Test9 = (a, b) => a + b;

            //Predicate<int> Test10 = (int a) => { return a < 10; };
            Predicate<int> Test10 = a => a < 10;
            //Func<int, bool> Test10 = a => a < 10;

            Test2("a");
            Test3("a", 1);
            Test4();
            Test5("a");

            Console.WriteLine(Test6());
            Console.WriteLine(Test7());
            Console.WriteLine(Test8(1));
            Console.WriteLine(Test9(1, 1));
            Console.WriteLine(Test10(1));

        }

        static void Test1()
        {
            Console.WriteLine("I Test 1 - a");
            Console.WriteLine("I Test 1 - b");
            Console.WriteLine("I Test 1 - c");
        }

        static void Test2(string txt)
        {
            Console.WriteLine($"I Test 2 med {txt} - a");
            Console.WriteLine($"I Test 2 med {txt} - b");
            Console.WriteLine($"I Test 2 med {txt} - c");
        }

        static void Test3(string txt, int n)
        {
            Console.WriteLine($"I Test 3 med {txt} og {n} - a");
            Console.WriteLine($"I Test 3 med {txt} og {n} - b");
            Console.WriteLine($"I Test 3 med {txt} og {n} - c");
        }

        static void Test4()
        {
            Console.WriteLine($"I Test 4");
        }

        static void Test5(string txt)
        {
            Console.WriteLine($"I Test 5 med {txt}");
        }

        static int Test6()
        {
            Console.WriteLine($"I Test 6");
            return 1;
        }

        static int Test7()
        {
            return 1;
        }

        static int Test8(int a)
        {
            return a;
        }

        static int Test9(int a, int b)
        {
            return a + b;
        }

        static bool Test10(int a)
        {
            return a < 10;
        }
    }
}
