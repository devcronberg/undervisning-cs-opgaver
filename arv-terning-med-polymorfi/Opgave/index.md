# Arv (terning)

Du skal skabe en tom konsol app med en klasse Terning med følgende medlemmer:
* En offentlig egenskab (int) Værdi (med private felt kaldet værdi). Der må ikke tildeles et tal mindre end en eller større end seks. Hvis det sker sættes værdi blot til en.
* En privat statisk instans af System.Random (initialiseres i en statisk constructor)
* En offentlig metode Ryst() der giver et tilfældigt tal
* En Offentlig metode Skriv() der viser terningen (eksempelvis [1] eller [2]) 
* Tilføj en default constructor (hvor Ryst kaldes) og en custom constructor hvor værdi kan angives når der oprettes en instans.

Skab nu en ny klasse LudoTerning der arver fra Terning. Klassen har to metoder

* ErGlobus() returnerer true hvis værdien er 3 – ellers false
* ErStjerne() returnerer true hvis værdien er 5 – ellers false
* Sørg for at der både er en default og custom constructor der kalder ”mor” uden yderligere funktionalitet
* Sørg for at Skriv kan overskrives så den returnerer eksempelvis [1] [2] [G] [4] [S] [6]

Prøv at skabe instanser af både Terning og LudoTerning og test at metoder fungerer.	

Ekstra:

* Der skal logges (console.writeline) når der aflæses og tildeles en værdi.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->