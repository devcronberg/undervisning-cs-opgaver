# Fejlhåndtering (egen exception)

Du skal i Program-klassen i en ny konsol-applikation skabe en statisk SmartToUpper-metode, 
som modtager en streng som argument, og returnerer strengen med små
bogstaver bortset fra det første bogstav som skal være stort. Altså "mikkel" bliver til "Mikkel" og
"MAtHiAs" bliver til "Mathias".

```csharp
static string SmartToUpper(string tekst) {
// mangler kode        
}
```

Hvis argumentet tekst er null skal du smide en ny ApplicationException med fejlen "tekst må ikke være null" og 
hvis argmentet tekst er "" skal du smide en ny ApplicationException med fejlen "tekst må ikke være tom".

Prøv metoden af i en try/catch så du fanger fejlen:

```csharp
try
{
    Console.WriteLine(SmartToUpper("mikkel"));
    Console.WriteLine(SmartToUpper("mAtHiAs"));
                
    // prøv også 
    Console.WriteLine(SmartToUpper(""));
    // eller
    Console.WriteLine(SmartToUpper(null));

}
catch (Exception ex)
{
    Console.WriteLine("Der er sket en fejl: " + ex.Message);                
}
```

PS Man kan godt argumentere at man i stedet for at smide en ApplicationException kunne smide en ArgumentException. Prøv evt det.

Se (eller kør) [evt. løsningen](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Fejlh%C3%A5ndtering-egenexception-simpel/Program.cs) inden du starter.
<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
