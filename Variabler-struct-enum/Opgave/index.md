# struct/enum

Du skal påbegynde en kortspil-app, og til det skal du danne en struct, der repræsentere et spillekort. Kortet skal have en værdi (int) og en kulør (enum = hjerter, spar, ruder og klør).

Når du er færdig skal du kunne køre følgende kode:

```csharp
SpilleKort s1 = new SpilleKort();
s1.Værdi = 2;
s1.Kulør = Kulør.Spar;
Console.WriteLine($"{s1.Kulør} {s1.Værdi}");

SpilleKort s2 = new SpilleKort();
s2.Værdi = 10;
s2.Kulør = Kulør.Hjerter;
Console.WriteLine($"{s2.Kulør} {s2.Værdi}");
```

hvilket vil resultere i 

```
Spar 2
Hjerter 10
```

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Variabler-struct-enum/Program.cs) for inspiration.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->

