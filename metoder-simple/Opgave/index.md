# Metoder (simple)


Du skal skabe en tom konsol app med følgende små metoder:

* Int LægSammen(int a, int b)
  * Lægger a og b sammen og returnere resultatet
* double BeregnAreal(int radius)
  * Beregner og returnere arealet af en cirkel (radius * radius * pi (se System.Math.PI) )
* double BeregnBeløbEfterMoms(double beløb, double momsPct)
  * Beregner og returnere et beløb efter moms
* Udskriv(string txt)
  * Udskriver txt på konsol (med Console.WriteLine)

Følgende er fra løsningen – du skal implementere metoderne (se evt løsning for hints):

```csharp
int res = LægSammen(5, 2);
Console.WriteLine(res); // 7
double res2 = BeregnAreal(5);
Console.WriteLine(res2); // 78.53
double res3 = BeregnBeløbEfterMoms(100, .25);
Console.WriteLine(res3); // 125
Udskriv("Dette er en test"); // Dette er en test
```

Det er nemmest hvis en metode i Program-klassen er static. 

```csharp
static void Test(){

}
```

Så skal du ikke skabe en klasse/struktur, og efterfølgende skabe en instans for at kalde en metode. Se statiske metoder som nemme hjælpemetoder.

Du kan eventuelt benytte denne skabelon. Her kan du se både metoder og kald til dem. 

```csharp
using System;

namespace OpgaveMetoderSimpel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kald til metoder
            Metode1();
            Metode2(1);
            int res1 = Metode3();
            int res2 = Metode4(1);
        }

        // Såkan kan metoder oprettes
        // --------------------------

        // void metode uden argument
        static void Metode1() { }

        // void metode med 1 argument
        static void Metode2(int a) { }

        // int metode uden argument
        static int Metode3() {
            return 0;
        }

        // int metode med argument
        static int Metode4(int a) {
            return 0;
        }

    }
}

```


Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/metoder-simple/Program.cs) for eksempel.


<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
