# Operator overload 

Du skal skabe en konsol app hvor klassen hund er defineret med en egenskab Navn (string) og en egenskab LydNiveau (int). Klassen skal overloade < og > operatoren der sammenligner lydniveau. Følgende skal være muligt:

```csharp
Hund h1 = new Hund() { Navn = "A", LydNiveau = 30 };
Hund h2 = new Hund() { Navn = "B", LydNiveau = 20 };
Console.WriteLine(h1 > h2);  // true
```

Ekstra: 
Prøv evt. også at overloade == og !=

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->