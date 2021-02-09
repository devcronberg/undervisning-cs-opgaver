# Arv (Polymorfi)

Du skal skabe en konsol applikation med en klasse faktura. Den skal bestå af egenskaberne

* Nr (int)
* Dato (DateTime)
* Kunde (string)

Prøv at skabe en instans af klassen og brug ToString() til at 
skrive ud på konsolen. Den burde udskrive navnet på typen.

Tilføj nu en overskrevet version af ToString der returnerer "Faktura til {Kunde} nr {Nr} fra {Dato}". Prøv eventuel en JSON serialisering med følgene:

```csharp
string jsonString;
jsonString = System.Text.Json.JsonSerializer.Serialize(this);
```

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/arv-polymorfi-object/Program.cs)

Prøv at køre programmet igen - giver ToString mere mening nu?
<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
