# ASync (Fil)

Du skal skabe en (7.3 - ret version i projektets properties/build/advanced) konsol app med følgende main:

```csharp
static async Task Main(string[] args) {}
```

og dan en tekstfil i c:\temp\ med noget tekst i. Brug evt denne metode:

```csharp
public static void DanFil(string fil)
{
    if (System.IO.File.Exists(fil))
        System.IO.File.Delete(fil);

    using (var s = System.IO.File.AppendText(fil))
        for (int i = 0; i < 1000; i++)
            s.WriteLine(Guid.NewGuid().ToString());
}
```

Du skal nu skabe en asynkron metode HentTekst(string filnavn) der ved hjælp af en StreamReader (System.IO.File.OpenText) læser filen med og returnerer resultatet som en Task<string> svarende til indholdet af filen.



<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->