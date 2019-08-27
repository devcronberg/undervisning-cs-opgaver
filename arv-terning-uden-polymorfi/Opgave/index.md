# Arv (terning)

Du skal skabe en tom konsol app med en klasse Terning med følgende medlemmer:
* En offentlig egenskab (int) Værdi (med private felt kaldet værdi). Der må ikke tildeles et tal mindre end en eller større end seks. Hvis det sker sættes værdi blot til en.
* En privat statisk instans af System.Random (kan initialiseres i en static constructor eller ved erklæring)
  - ```private static System.Random rnd = new System.Random();```
* En offentlig metode Ryst() der giver et tilfældigt tal
  - ```this.Værdi = rnd.Next(1, 7);```
* En Offentlig metode Skriv() der viser terningen (eksempelvis [1] eller [2]) 
* Tilføj en default constructor (hvor Ryst kaldes) og en custom constructor hvor værdi kan angives når der oprettes en instans.

Prøv terningen i Main() på forskellige måder så du er sikker på at den virker!

Skab nu en ny klasse LudoTerning der arver fra Terning. Klassen har to metoder

* ErGlobus() returnerer true hvis værdien er 3 – ellers false
* ErStjerne() returnerer true hvis værdien er 5 – ellers false
* Sørg for at der både er en default og custom constructor der kalder ”mor” uden yderligere funktionalitet
* Sørg for at klassen er ```sealed``` så man ikke kan arve fra den

Prøv at skabe instanser af LudoTerning og test at de nye metoder fungerer, og check at man ikke kan skabe en klasse der arver fra LudoTerning.

Løsning: 

- Kode til [Terning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/arv-terning-uden-polymorfi/Terning.cs)
- Kode til [LudoTerning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/arv-terning-uden-polymorfi/LudoTerning.cs)
- Kode til [program.cs](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/arv-terning-uden-polymorfi/Program.cs)

Ekstra:

* Der skal logges (console.writeline) når der aflæses og tildeles en værdi.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
