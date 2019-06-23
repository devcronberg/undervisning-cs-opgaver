# ASync (Fil)

Du skal skabe en (.NET 7.3 - ret version i projektets properties/build/advanced - eller .NET Core) konsol app med følgende main:

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
        for (int i = 0; i < 10000; i++)
            s.WriteLine(Guid.NewGuid().ToString());
}
```

Du skal nu skabe en asynkron metode HentTekst(string filnavn), der ved hjælp af en StreamReader (System.IO.File.OpenText) læser filen (brug metoden ReadToEndAsync), og returnerer resultatet som en Task<string> svarende til indholdet af filen. 

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/async-task/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
