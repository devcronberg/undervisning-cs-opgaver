# Fejlhåndtering (egen exception)

Du skal skabe en applikation som 

* Først checke om filen c:\temp\tal.txt eksisterer (System.IO.File.Exists). Hvis den _ikke_ findes 
skal der smides en ApplikationException med teksten "Filen c:\temp\tal.txt findes ikke!"
* I en try/catch-struktur skal du nu
  * Åbne filen og hent indhold til en streng (System.IO.File.ReadAllText). Hvis det går galt skal fejlen blot smides videre.
  * Konverter indhold til et heltal (int32) ved hjælp af Convert.ToInt32. Hvis det går
galt smider ToInt32 en FormatException. I så fald skal du smide en ApplikationException med teksten "Indhold kan ikke konverteres til et heltal".
  * Læg nu 1 til tallet og gem det igen (System.IO.File.WriteAllText). Hvis det går galt skal fejlen blot smides videre.

Så du er altså ude i en try/catch ala:

```csharp
try
{
}
catch (System.FormatException ex)
{
}
catch (Exception)
{
}
```

Se (eller kør) [evt. løsningen](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Fejlh%C3%A5ndtering-egenexception/Program.cs) inden du starter.
<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
