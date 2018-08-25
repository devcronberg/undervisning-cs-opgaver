# Metoder (simple)


Du skal skabe en tom konsol app med følgende små metoder:

* Int LægSammen(int a, int b)
  * Lægger a og b sammen og returnere resultatet
* double BeregnAreal(int radius)
  * Beregner og returnere arealet af en cirkel (radius * radius * pi (se System.Math.PI) )
* Udskriv(string txt)
  * Udskriver txt på konsol (med Console.WriteLine)

Følgende er fra løsningen – du skal implementere metoderne (se evt løsning for hints):

```csharp
int res = LægSammen(5, 2);
Console.WriteLine(res); // 7
double res2 = BeregnAreal(5);
Console.WriteLine(res2); // 78.53…
Udskriv("Dette er en test"); // Dette er en test
```

Det er nemmest hvis en metode i Program-klassen er static. 

```csharp
static void Test(){

}
```

Se evt. løsning for eksempel.

