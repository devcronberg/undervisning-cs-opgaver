# Brug af metoder (nullable)

Start en ny tom konsol applikation:

* Tilføj en metode HentVærdiFraDb der tager en int som argument og returnerer en nullable bool. Metoden simulerer kald til en database efter et felt med en mulig null-værdi
  * Hvis int = 1 returneres true
  * Hvis int = 2 returneres false
  * Ellers returneres null
* Test metoden i main ved at skrive ud til consol (null = '' i WriteLine)

* Tilføj en klasse Person med egenskaberne
	* PersonId (int)
	* Navn (string)
	* Fødselsdato (nullable DateTime)
	* ErILive (nullable bool)
* Tilføj metoden HentPersonFraDb der tager et personId som argument og returnerer en Person
	* Hvis der angives 1 som personId returneres en Person med (PersonId:1, Navn: "a", Fødselsdato: null, ErILive: null)
	* Ellers smides en Exception (Person findes ikke!)
* Test metoden

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/variabler-nullable/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
