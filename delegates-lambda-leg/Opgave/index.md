# Delegates (leg med lambda)

Du skal skabe en tom konsol og kopiere følgende kode ind i program.cs

```csharp
using System;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Test1();
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
```

Prøv at afvikle koden og bemærk hvordan alle metoder bliver kaldt.

Din opgave er nu at udmarkere alle Testxx-metoder og skrive dem som lambda-metoder i stedet direkte i Main. prøv at skrive
lambda både i uforkortet og forkortet version (se evt løsning for inspiration). Her er et eksempel på løsning af Test1()-metoden:

```csharp
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

        //static void Test1()
        //{
        //    Console.WriteLine("I Test 1 - a");
        //    Console.WriteLine("I Test 1 - b");
        //    Console.WriteLine("I Test 1 - c");
        //}

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
```

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-lambda-leg/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
