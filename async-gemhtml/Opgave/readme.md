# Hent og gem HTML (async)

I denne opgave skal du hente HTML fra forsiden på https://www.teknologisk.dk, og gemme dette i tre forskellige filer - alt sammen asynkront.

- Start med at skabe en tom .net core konsol applikation, og tilret "void Main" til "async Task Main"
- Skriv "Start" på konsol
- Hent ved hjælp af HttpClient's GetStringAsync metode HTML fra https://www.teknologisk.dk
- Skriv hvor mange tegn der er hentet
- Gem nu HTML i tre forskellige filer ved hjælp af System.IO.File.AppendAllTextAsync.
	- Da de tre task ikke er afhængige af hinanden bør benytte Task.WhenAll til at vente på at alle operationer er gennemført
	- Skriv på konsol når en fil er gemt
- Skriv "Slut" på konsol
- Det skal se nogenlunde således ud:

```
Start
Henter HTML
Henter hentet - 16847 tegn
Gemmer fil1
Gemmer fil2
Gemmer fil3
Slut
```

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/async-gemhtml/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->

