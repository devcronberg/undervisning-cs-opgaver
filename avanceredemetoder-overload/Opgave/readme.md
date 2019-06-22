# Expression (repository)

I denne opgave skal du skabe din egen datatype - en [Nibble](https://da.wikipedia.org/wiki/Nibble) (gammel 4 bit struktur).

- Skab en ny tom konsol applikation
- Tilføj klassen Nibble med et enkelt private felt kaldet value af typen byte 
- Tilføj en readonly egenskab Value der returnerer value
- Tilføj tre custom constructors der tager en byte og en string (binært - eksempelvis "1001" = 9)
	- Hvis værdien ikke er mellem 0-15 skal der smides en fejl
- overload <,>, ==, != og overskriv Equals og GetHashCode (lad VS foretage overrides)
- overload = (implicit) således at man direkte kan tildele/aflæse en byte, int og string
	- n = 8 (byte)
	- n = 8 (int)
	- n = "1000" (string)
	- byte a = n
	- int b = n;
	- string c = n;
	
Du kan bruge dette til at teste:

```csharp
byte a = 8;
Nibble n1 = new Nibble(a);
Console.WriteLine(n1.Value);

int b = 8;
Nibble n2 = new Nibble(b);
Console.WriteLine(n2.Value);

string c = "1000";
Nibble n3 = new Nibble(c);
Console.WriteLine(n3.Value);

Nibble n4 = new Nibble("0000");
n4 = a;
n4 = b;
n4 = c;
Console.WriteLine(n4.Value);

byte d = n4;
Console.WriteLine(d);
int e = n4;
Console.WriteLine(e);
string f = n4;
Console.WriteLine(f);

Nibble n5 = new Nibble(8);
Nibble n6 = new Nibble(9);
Console.WriteLine(n5 > n6);
Console.WriteLine(n5 < n6);
Console.WriteLine(n5 == n6);
Console.WriteLine(n5 != n6);
```
Resultat:
```
8
8
8
8
8
8
1000
False
True
False
True
```


Se eventuelt [min løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/avanceredemetoder-overload/Program.cs).


<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
