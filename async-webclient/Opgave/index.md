# Hent tilfældige tal fra random.org

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

- Skriv "App Start" til konsol 
- Skriv "Henter tal synkront til konsol
- Skabe en liste af string (lst1) og fylde den med ti tilfældige returværdier fra TilFældigTalSync
- Udskrive listen af tal til konsolen
- Skriv "Henter tal asynkront" til konsol
- Skabe en liste af Task\<string\> og fylde den med ti tifældige returværdier fra TilFældigTalASync
- Afvent at alle Task's er afsluttet ved hjælp af den statiske metode AwaitAll (konverter listen til array med ToArray) på Task-typen
- Udskrive listen af tal til konsolen ved at løbe listen af Task-igennem og udskrive Result
- Skriv "App Slut" til konsol
- Console.ReadLine() som sidste instruktion i Main
	
*Hvordan fungerer det?*

- Kan du se nogen forskel i hastigheden mellem de to metoder?
- Hvad med rækkefølgen at tekster til konsol - giver det mening? 
	- Kan du se at WaitAll blokerer? 
	- At "App slut" faktisk kommer til slut?

Prøv nu at 

- Udmarkere WaitAll og udskriften af tal
- Bruge WhenAll metoden i stedet. Den returnerer en ny Task som tager en delegate med en
Task som argument. Denne Task har et Result som er en liste strenge (tal)
- Udskrive listen af tal

*Hvordan fungerer det?*

- Kan du se nogen forskel i hastigheden mellem de to metoder?
- Hvad med rækkefølgen at tekster til konsol - giver det mening? 
	- Kan du se at WhenAll faktisk ikke blokkerer? 
	- At "App slut" ikke kommer til slut men det gør listen aF tal?


Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/async-webclient/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
