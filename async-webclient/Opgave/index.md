# Hent tilfældige tal fra random.org

Du skal skabe en konsol applikation der skal hente tilfældige tal fra random.org - både synkront og asynkront.

Prøv først denne url:

https://www.random.org/integers/?num=1&min=10&max=100&col=1&base=10&format=plain&rnd=new

og læg mærke til, at den retunerer et tal tilfældigt tal mellem 10 og 100.

Du skal skabe to statiske metoder i Main (som i øvrigt skal være async):

- static string TilFældigTalSync(int min, int max)
	- skriver "henter tal sync" til konsol
	- henter og returnerer et tilfældigt tal ved hjælp af System.Net.WebClient og metoden DownloadString.

- static Task<string> TilFældigTalASync(int min, int max)
	- skriver "henter tal async" til konsol	
	- henter og returnerer en Task\<string\> ved hjælp af System.Net.Http.HttpClient og metoden GetStringAsync

I Main skal du nu 

- Skriv "App Start" til konsol 
- Skriv "Henter tal synkront til konsol
- Skabe en liste af string (lst1) og fylde den med ti tilfældige returværdier fra TilFældigTalSync
- Udskrive listen af tal til konsolen
- Skriv "Henter tal asynkront" til konsol
- Skabe en liste af Task\<string\> og fylde den med ti tifældige returværdier fra TilFældigTalASync
- Skab et array af strenge ved at await'e alle Task's er afsluttet ved hjælp af den statiske metode WhenAll (konverter listen til array med ToArray) på Task-typen
- Udskrive listen af tal til konsolen ved at løbe array af strenge igennem
- Skriv "App Slut" til konsol
	
Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/async-webclient/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
