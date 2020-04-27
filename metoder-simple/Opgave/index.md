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

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/metoder-simple/Program.cs) for eksempel.


<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
