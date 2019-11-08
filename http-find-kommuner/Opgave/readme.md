# HTTP (Hent JSON)

Du skal skabe en .NET Core konsol app hvor du skal benytte HTTPClient (System.Net.Http) til at hente samtlige kommuner 
i Danmark fra DAWA, som har en JSON service på https://dawa.aws.dk/Kommuner. Denne service returnerer følgende:

```
[
  {
    "ændret": "2019-04-30T21:07:19.273Z",
    "geo_version": 7,
    "geo_ændret": "2019-04-30T21:07:19.273Z",
    "bbox": [12.44441133, 55.60647026, 12.73658638, 55.73587822],
    "visueltcenter": [12.49390862, 55.7040906],
    "href": "https://dawa.aws.dk/kommuner/0101",
    "dagi_id": "389103",
    "kode": "0101",
    "navn": "København",
    "udenforkommuneinddeling": false,
    "regionskode": "1084",
    "region": {
      "href": "https://dawa.aws.dk/regioner/1084",
      "kode": "1084",
      "navn": "Region Hovedstaden"
    }
  },
  ...
]
```

men du skal ikke bruge andet end kode og navn. Opgaven kan eksempelvis løses ved at skabe en klasse med egenskaberne Navn og Kode, og så bruge HttpClient 
samt NuGet-pakken Microsoft.AspNet.WebApi.Client til at hente og deserialisere data. Når data er hentet skal kommuner sorteres efter navn, 
og udskrives som følger:

```
0165 Albertslund
0201 Allerød
0420 Assens
0151 Ballerup
0530 Billund
0400 Bornholm
0153 Brøndby
0810 Brønderslev
0411 Christiansø
0155 Dragør
0240 Egedal
0561 Esbjerg
0563 Fanø
0710 Favrskov
0320 Faxe
...
```

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/http-find-kommuner/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->