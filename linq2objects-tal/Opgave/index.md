# LINQ to Objects (tal)

Start med at skabe en tom konsol applikation og tilføj følgende simple int-array til Main:

```csharp
int[] a = { 1, 5, 7, 2, 6, 7, 3, 5, 7, 8, 2, 5, 4, 1 };
```

Brug nu LINQ til følgende:

- Brug Count() til at finde og udskrive antal
- Brug Count(...) til at finde og udskrive hvor mange 7'ere der er
- Brug Sum() til at finde og udskrive summen
- Brug Average() til at finde og udskrive gennemsnit
- Brug OrderBy til at sortere og udskrive array (brug string.join metoden til at udskrive array)
- Brug Where til at finde og udskrive tal > 5 (brug string.join metoden til at udskrive array)
- Brug Take til at finde og udskrive de første 5 tal (brug string.join metoden til at udskrive array)
- Brug Skip og Take til at finde og udskrive tal nr 6-10 (brug string.join metoden til at udskrive array)

```csharp
// Eksempel på brug af join til at udskrive array
Console.WriteLine(string.Join(' ', a));
```

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/linq2objects-tal/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
