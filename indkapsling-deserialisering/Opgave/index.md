# Egenskaber (deserialisering)

Skab en fil på disken (feks c:\temp\data.json) med følgende indhold:

```json
[
  {
    "Id": 1,
    "Navn": "A",
    "ErDansk": true,
    "Dato": "1966-01-01T00:00:00"
  },
  {
    "Id": 2,
    "Navn": "B",
    "ErDansk": true,
    "Dato": "2003-01-01T00:00:00"
  },
  {
    "Id": 3,
    "Navn": "C",
    "ErDansk": true,
    "Dato": "1988-01-01T00:00:00"
  }
]
```

Det er en liste af personer med fire egenskaber.

Din opgave er at skabe en klasse Person med de fire egenskaber (skal hedde det samme som filen), 
og herefter skabe en liste af personer ved hjælp af JSON deserialisering. Du 
kan benytte den indbyggede System.Text.Json.Deserialize<> som følger:

```csharp
// hent json
string json = System.IO.File.ReadAllText(@"c:\temp\data.json");
// deserialiser
List<Person> lst = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(json);
```

Herefter skal du løbe listen igennem og udskrive Navn eller lign.

Ekstra: Prøv evt at udvide JSON filen med en ny egenskab på hver person, og tilrette klassen
så den tager hensyn til det nye skema.

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/indkapsling-deserialisering/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
