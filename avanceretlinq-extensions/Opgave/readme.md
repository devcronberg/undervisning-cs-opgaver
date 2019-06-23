# LINQ med egne extensions

Du skal oprette en tom konsol applikation og skabe to udvidelser til LINQ to objects

- Tilføj en offentlig statisk klasse
- Tilføj en extension metode kaldet HverAnden\<T\>, som returnerer hvert andet element i en liste
- Overload metoden Where\<T\> med en version, der udover en predicate og modtager en int der angiver hvor mange elementer der skal returneres

De skal virke som:

```csharp
List<int> lst1 = new List<int>() { 5, 4, 2, 3, 7, 10, 2 };
foreach (var item in lst1.HverAnden())
    Console.WriteLine(item);
Console.WriteLine();
foreach (var item in lst1.Where(i => i < 5, 2))
    Console.WriteLine(item);
```
som burde resultere i:
```
5
2
7
2

4
2
```

Prøv dem også med andet en int - hver med hunde eller terninger?

```csharp
Console.WriteLine();
List<Hund> lst2 = new List<Hund>() {
    new Hund { AntalBen = 4, Navn = "F" },
    new Hund { AntalBen = 3, Navn = "A" },
    new Hund { AntalBen = 4, Navn = "C"} };

foreach (var item in lst2.HverAnden())
    Console.WriteLine(item.Navn);
Console.WriteLine();
foreach (var item in lst2.Where(i => i.AntalBen > 2, 1))
    Console.WriteLine(item.Navn);
```

Se eventuelt [min løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/avanceretlinq-extensions/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
