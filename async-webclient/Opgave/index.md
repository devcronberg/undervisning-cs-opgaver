# Hent tilfældige tal fra ramdom.org

Du skal skabe en konsol applikation der skal hente tilfældige tal fra random.org - både synkront og asynkront.

Prøv først denne url:

https://www.random.org/integers/?num=1&min=10&max=100&col=1&base=10&format=plain&rnd=new

og læg mærke til, at den retunerer et tal tilfældigt tal mellem 10 og 100.

Du skal skabe to statiske metoder i Program:

- static string TilFældigTalSync(int min, int max)
	- henter og returnerer et tilfældigt tal ved hjælp af System.Net.WebClient og metoden DownloadString.

- static Task<string> TilFældigTalASync(int min, int max)
	- henter og returnerer en Task\<string\> ved hjælp af System.Net.Http.HttpClient og metoden GetStringAsync

I Main skal du nu 
	- Skabe en liste af string (lst1) og fylde den med ti tilfældige returværdier fra TilFældigTalSync
		- Skriv start/stop på konsol
	- Skabe en liste af Task\<string\> og fylde den med ti tifældige returværdier fra TilFældigTalASync
		- Afvent at alle Task's er afsluttet ved hjælp af en statisk metode på Task-typen
		- Skriv start/stop på konsol
	
Kan du se nogen forskel i hastigheden?

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/async-webclient/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->