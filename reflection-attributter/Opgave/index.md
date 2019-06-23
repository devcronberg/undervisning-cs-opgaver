# Brug af attributter

Du kan benytte denne opgave til at lege lidt med et par simple attributter. Opret en tom konsolapplikation og sørg for i Program-klassen  at

- skabe en statisk  metode Log der tager en string som argument
	- metoden skal bruge bruge Console.WriteLine til at skrive strengen ud på konsollen (men pointen er at den kan gøre hvad som helst)
	- dekorer metoden med Conditional-attributten med argumentet DEBUG
		- Så vil metoden udelukkende blive afviklet hvis der komplieres med debug-flag
- skabe en statisk metode Test, som ikke har nogen argumenter
	- dekorer denne med attributten Obsolete 
		- afhængig af Obsolete-attributtens argumenter vil kompileren enten smide en warning eller fejl ved kompilering

```csharp
Console.WriteLine("Start");
Log("Logges dette?");
Console.WriteLine("Slut");
            
Test();  // giver warning eller fejl kompileringsfejl på designtime
```

Prøv Log-metoden ved at ændre konfiguration fra debug til release
	- Kaldes metoden ved afvikling i de forskellige konfigurationer?
Check Test-metoden direkte i VS
	- Kommer der enten en warning eller error ved kald til metoden under design?

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/reflection-attributter/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->