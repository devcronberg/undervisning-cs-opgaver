# Delegates (helt grundlæggende)

Du skal skabe en tom konsol app med følgende metode i Program-klassen:

```csharp
static void MinSkrivTilConsole(string txt)
{
    Console.WriteLine("**** " + txt + " ****");
}
```

Nu skal du:

- definere en delegate kaldet MinDelegate1 der kan holde referencer til void metoder med en enkelt streng som argument. Placer definition på namespace niveau.
- i main:
  - skab en ny instans af MinDeletage1 kaldet f1. Benyt new-syntaksen. Objektet skal indeholde en reference til MinSkrivTilConsole
    - MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
	- kald metoder i f1 med f1.Invoke("test")
	- Virker det - og hvorfor?
  - skab en ny instans af MinDelegate1 kaldet f2. Benyt "sukker-syntaks" hvor metodenavnet reelt skaber et delegate-objekt
    - MinDelegate1 f2 = MinSkrivTilConsole;
	- kald metoder i f2 med f2("test")
	- Virker det - og hvorfor? Bemærk sukker-syntaks
  - skab en ny instans af MinDelegate1 kaldet f3. Benyt "sukker-syntaks" hvor metodenavnet reelt skaber et delegate-objekt
    - MinDelegate1 f3 = MinSkrivTilConsole;
	- Bind en reference til f3 med += så også Console.WriteLine bliver en del af metoderne i delegate-objektet
	- kald metoder i f3 med f3("test")
	- Virker det - og hvordan/hvorfor? 
  - ryd op i alle delegate objekter med -= så der ikke længere eksisterer referencer til metoder
    - test det evt ved at kalde f1, f2 og f3 igen. Får du en null-ref exception? Hvorfor?

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->