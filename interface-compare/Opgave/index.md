# Interface (compare)

Du skal skabe en tom konsol app med følgende indhold:

```csharp
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }         
        }
    }

    class Hund {
        public string Navn { get; set; }
        public int Alder { get; set; }
    }
}
```

Når du afvikler applikationen vil du få en fejl fordi frameworket ikke ved hvordan objekterne skal sammenlignes. Sørg nu for at implementere IComparable< Hund > (eller bare IComparable men det kræver typekonvertering), og sammenlign to objekter på Alder. Metoden bør returnere -1, 1 eller 0. Nu burde frameworket kunne sortere.
    
    
<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
