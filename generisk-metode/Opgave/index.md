# Generisk metode

I denne opgave skal du skabe en metode til at finde ud af hvor mange elementer på en liste der er større end en konkret værdi. Hvis der er
tale om heltal kunne det eksempelvis kodes som:

```csharp
static int AntalMaxInt(IEnumerable<int> liste, int maxVærdi) 
{
    int antal = 0;
    foreach (int t in liste)
    {
        if (t.CompareTo(maxVærdi) > 0)
            antal++;
    }
    return antal;
}
```

men du skal kode den generisk så alle typer der implementerer IComparable (og dermed har en CompareTo) kan benyttes - eksempelvis:

```csharp
List<int> lst1 = new List<int>() { 5, 1, 41, 5, 21, 2, 61, 5 };
List<char> lst2 = new List<char>() { 'b','c','h','r' };
List<string> lst3 = new List<string>() { "a", "", "c" };
List<Hund> lst4 = new List<Hund>() { new Hund { AntalBen = 4, Navn = "F" }, new Hund { AntalBen = 3, Navn = "A" } };
            
// Generisk
Console.WriteLine(AntalMax(lst1, 20));
Console.WriteLine(AntalMax(lst2, 'h'));
Console.WriteLine(AntalMax(lst3, "b"));
Console.WriteLine(AntalMax(lst4, new Hund { Navn = "A" }));
```

hvor koden forudsætter en klasse Hund med et Navn, og at klassen også implementere IComparable.

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/generisk-metode/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
