# Metoder (rekursiv)

Du skal skabe en tom konsol app der indeholder metoden PrintFiler(string sti) - hvor sti er
en reference til en mappe på disken (c:\temp eller c:\git eller...).

Metoden skal printe (Console.WriteLine) alle filer i mappen OG alle undermapper. Det nemmeste
er at skabe en metode, som printer alle filer i en given metode, finde alle undermapper
i den konkrete metode - og kalder sig selv med hver undermappe som argument. Altså en rekursiv
metode.

Alle filer i en mappe kan findes og gennemløbes med

```csharp
var filer = System.IO.Directory.GetFiles(sti);
foreach (string fil in filer)
    Console.WriteLine(fil);
```

og alle undermapper kan findes og gennemløbes med
```csharp
var mapper = System.IO.Directory.GetDirectories(sti);
foreach (string mappe in mapper)
    // kald til metoden
```

Få koden til at virke så et kald til ```PrintFiler(@"c:\git");``` viser alle filer, men 
den virkelige opgave er at forstå hvad der egentlig sker. Brug debuggeren og se værdien af (og skønheden ved)
rekursion ;)

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/metoder-rekursiv-filer/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
