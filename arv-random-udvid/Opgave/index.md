# Arv (Udvid System.Random)

Du skal skabe en tom konsol app med en klasse UdvidetRandom, 
der udvider System.Random-klassen med en metode NextBool(). 
Metoden returnerer true eller false ud fra et tilfældigt tal mellem 1 
og 1000 (brug next(1,1002) – under/lig med 500 = true og over 500 = false).

Test klassen i main som:

```csharp
UdvidetRandom r = new UdvidetRandom();
Console.WriteLine(r.NextBool()); // true eller false
```