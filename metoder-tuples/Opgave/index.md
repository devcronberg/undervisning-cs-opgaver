# Tuple

Du skal skabe en ny konsol applikation med en enkelt ny statisk metode kaldet FindSumOgGns. Den tager to argumenter - begge double - og 
skal returnere en tuple med sum (double) og gennemsnit (double):

Du skal ende med at kunne kalde den således:

```csharp
(double sum, double gns) resultat = FindSumOgGns(5.4, 10.5);
Console.WriteLine($"Sum: {resultat.sum:n2}");
Console.WriteLine($"Gns: {resultat.gns:n2}");

// eller

var resultat2 = FindSumOgGns(5.4, 10.5);            
Console.WriteLine($"Sum: {resultat2.sum:n2}");
Console.WriteLine($"Gns: {resultat2.gns:n2}");
```
Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/metoder-tuples/Program.cs).
<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
