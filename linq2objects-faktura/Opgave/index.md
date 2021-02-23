# LINQ to Objects

Start med at skabe en tom konsol applikation og tilføj følgende klasse:

```csharp
class Faktura
{

    public DateTime Dato { get; set; }
    public int Nummer { get; set; }
    public string Kunde { get; set; }
    public string Region { get; set; }
    public double Salg { get; set; }

    public static List<Faktura> HentFakturaer()
    {

        List<Faktura> lst = new List<Faktura> {
            new Faktura{ Dato = new DateTime(2020,7,1), Nummer = 1, Kunde ="Jens", Region = "Fyn", Salg = 100 },
            new Faktura{ Dato = new DateTime(2020,5,1), Nummer = 2, Kunde ="Anders", Region = "Fyn", Salg = 300 },
            new Faktura{ Dato = new DateTime(2021,1,1), Nummer = 3, Kunde ="Mette", Region = "Sjælland", Salg = 150 },
            new Faktura{ Dato = new DateTime(2020,12,1), Nummer = 4, Kunde ="Hans", Region = "Jylland", Salg = 900 },
        };
        return lst;
    }

    public override string ToString()
    {
        return $"{Dato.ToShortDateString()} {Nummer} {Kunde} ({Region})";
    }
}
```

Brug den statiske metode HentFakturaer til at hente test data:

```csharp
var fakturaer = Faktura.HentFakturaer();
```

Brug nu LINQ til følgende:

- Udskriv alle (bemærk at ToString er overskrevet i klassen - den kan du bruge til udskrift. Se løsning)
- Udskriv alle sorteret efter kunde
- Udskriv alle sorteret efter dato
- Udskriv alle på Fyn sorteret efter dato
- Udskriv antal på Fyn
- Udskriv samlet salg
- Udskriv samlet salg på Fyn

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/linq2objects-faktura/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
