# Liste af brugere (async)

I denne opgave skal du hente tilfældig json fra http://www.filltext.com, og deserialisere det til en liste af brugere.

- Start med at skabe en tom .net core konsol applikation, og tilret "void Main" til "async Task Main""
- Tilføj nu en simpel klasse med egenskaberne Id (int), Brugernavn (string) og Password (string)
- Skriv "Start" på konsol
- Hent ved hjælp af HttpClient's GetStringAsync metode tilfældig json ved følgende url
	- http://www.filltext.com/?rows=10&id={index}&brugernavn={username}&password={randomString|5}
	- Prøv eventuelt i en browser
- Brug System.Text.Json.JsonSerializer.Deserialize<\T\> json til en liste af brugere
	- Det kræver NuGet-pakken "System.Text.Json"
- Udskriv alle egenskaberne til konsol
- Skriv "Slut" på konsol
- Det skal se nogenlunde således ud:

```
Start
27528 GCulin xum4L
27529 DPervaiz hBMHb
27530 SGupta GEhKI
27531 JJohnston LkmOY
27532 LRomero wAZNK
27533 SCullen asrKF
27534 CHydle mjGLm
27535 FNixon nZBED
27536 HMarton 9FCWU
27537 BConn S8mOq
Slut
```

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/async-findbrugere/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
