# Samlinger (IEnumerable)

Du skal skabe en tom konsol app med følgende klasser:

## Bil

Klassen skal have egenskaberne Model (string), Mærke (string), Årgang (int) og Nummerplade (string). Samlinger af 
klassen skal kunne sorteres efter årgang, så du skal implementere IComparable<Bil>. Sørg for at overskrive ToString så det er nemt at 
skrive instanser ud på konsollen. Brug evt JSON.NET fra NuGet, og metoden Newtonsoft.Json.JsonConvert.SerializeObject() - så er det nemt
at se alle egenskaber.

## Garage

Klassen skal have en privat List<Bil>, samt metoderne BilInd(Bil) og Bil BilUd(string) som hhv skal tilføje og fjerne (efter nummerplade) en bil. Du skal kunne ForEach'e 
over biler i garagen så du skal implementere IEnumerable<Bil>.


Prøv det eventuelt med følgende kode i Main:

```csharp
Garage g = new Garage();
g.BilInd(new Bil() { Model = "a", Mærke = "x", NummerPlade = "xx", Årgang = 2000 });
g.BilInd(new Bil() { Model = "b", Mærke = "y", NummerPlade = "yy", Årgang = 2019 });
g.BilInd(new Bil() { Model = "c", Mærke = "z", NummerPlade = "ww", Årgang = 1978 });
foreach (var item in g)
    Console.WriteLine(item);
g.Sorter();
foreach (var item in g)
    Console.WriteLine(item);
Console.WriteLine();
var b = g.BilUd("ww");
Console.WriteLine(b);
Console.WriteLine();
foreach (var item in g)
    Console.WriteLine(item);

// Test af BilUd ved fejl
```

Resultat:

```
{"Mærke":"x","Model":"a","Årgang":2000,"NummerPlade":"xx"}
{"Mærke":"y","Model":"b","Årgang":2019,"NummerPlade":"yy"}
{"Mærke":"z","Model":"c","Årgang":1978,"NummerPlade":"ww"}
{"Mærke":"z","Model":"c","Årgang":1978,"NummerPlade":"ww"}
{"Mærke":"x","Model":"a","Årgang":2000,"NummerPlade":"xx"}
{"Mærke":"y","Model":"b","Årgang":2019,"NummerPlade":"yy"}

{"Mærke":"z","Model":"c","Årgang":1978,"NummerPlade":"ww"}

{"Mærke":"x","Model":"a","Årgang":2000,"NummerPlade":"xx"}
{"Mærke":"y","Model":"b","Årgang":2019,"NummerPlade":"yy"}
```

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/samlinger-ienumable/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
