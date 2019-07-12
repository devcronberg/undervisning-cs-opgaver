# Simpel debugging

Denne opgave har til formål at sikre, at du ved hvordan du kan debugge en konsol-applikation:

- Skab en tom .NET Core "Console Application" 
- Erstat al kode i program.cs med [denne kode](https://raw.githubusercontent.com/devcronberg/undervisning-cs-opgaver/master/start-debugging/Program.cs)

Prøv nu at 

- Kør applikationen uden debugger (ctrl+F5) så du kan se hvad den gør
- Kør applikationen med debugger ved at starte applikationen ved at trykke F10 
	- Step dig igennem hele koden ved at trykke F10 ved hver instruktion. Bliv ved til applikationen er færdig
- Sæt et breakpoint (F9) på linje 15 og tryk på F5
	- Bemærk at applikationen stopper lige før den skal til at afvikle linje 15
	- Brug F10 til at steppe dig gennem koden til linje 20
		- Bemærk Locals vinduet hvor x ændrer værdi
	- Stop afvikling ved at trykke shift+F5
	- Fjern breakpoint fra linje 15
- Sæt et breakpoint på linje 23 og kør (F5)
	- Når applikationen er i debug-mode så step dig gennem for-løkken
		- Bemærk hvordan programpointeren bevæger sig i for-løkken og i betingelsen
	- Stop afvikling ved at trykke shift+F5
	- Tryk ctrl+shift+F9 for at slette alle breakpoints
- Sæt et breakpoint på linje 35 og kør (F5)
	- Tryk på F11 (step into) og bemærk, at du følger programpointeren ned i metoden og kommer retur
	- Hold musen over res når du er retur - det er også en måde at se værdien af en variabel
- Fjern alle breakpoints og sæt et nyt på linje 39 og kør (F5)
	- Tryk på F11 (step into) og bemærk, at du følger programpointeren ned i alle metoder og kommer hele vejen retur
		- Check Call stack vinduet når du når program pointeren når til linje 63
			- Her kan du se hvordan du er endt i metoden

Der er meget mere i C# debugging med Visual Studio - men det vil give dig en grundlæggende viden.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
