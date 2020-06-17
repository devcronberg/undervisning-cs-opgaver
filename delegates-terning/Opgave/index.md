# Delegates/Lambda Terning med afkoblet ryst-metode

Du skal skabe en tom konsol app med klassen Terning. Klassen skal indeholde

- En offentlig egenskab Værdi (int)
- En private delegate kaldet rystDelegate som ikke tager nogle argumenter men returnerer en int
- En konstruktør der som argument tager en reference til en delegate. Denne reference gemmes i rystDelegate. Hvis
der ikke medsendes et argument skal der antages at værdien af null (valgfrit argument - =null). Hvis det medsendte argument er null skal der tilføjes en standard metode (brug System.Random til at finde et tal mellem 1-6). 
- En Ryst-metode som blot afvikler metoden i rystDelegate, og gemmer værdien i Værdi.

Du kan bruge følgende kode til at teste klassen

```csharp
Terning t1 = new Terning();
Console.WriteLine(t1.Værdi);
t1.Ryst();
Console.WriteLine(t1.Værdi);
            
Console.WriteLine();

Terning t2 = new Terning(() => 6);
Console.WriteLine(t2.Værdi);
t2.Ryst();
Console.WriteLine(t2.Værdi);

Console.WriteLine();

Terning t3 = new Terning(() => {
    using (System.Net.WebClient w = new System.Net.WebClient())
    {
        string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
        return Convert.ToInt32(s);
    }
});
Console.WriteLine(t3.Værdi);
t3.Ryst();
Console.WriteLine(t3.Værdi);
```

Se evt. [min løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-terning/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
