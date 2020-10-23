# Simpel brug af async/await

I denne opgave skal du hente et tilfældigt tal fra random.org, og gemme dette i en fil - men begge ting skal ske asynkront!

- Start med at skabe en tom .net core konsol applikation, og tilret "void Main" til "async Task Main"
- Hent ved hjælp af HttpClient's (HttpClient w = new HttpClient();) GetStringAsync fra metode en streng med et tal fra https://www.random.org/integers/?num=1&min=10&max=100&col=1&base=10&format=plain&rnd=new
- Gem tallet i en fil på disken ved hjælp af AppendAllTextAsync fra System.IO.File

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/async-henttaloggem/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->

