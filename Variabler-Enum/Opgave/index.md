# Enum

Du skal skabe en del af en applikation der kan bruges til forskellige typer af kortspil, og her skal du blandt kunne håndtere spillekort. Et spillekort har som bekendt en kulør (spar, ruder, hjerter og klør), og i stedet for at have kode som dette:

```csharp
// Til alle der læser koden...
// Kulør 0 = Spar
// Kulør 1 = Hjerter
// Kulør 2 = Ruder
// Kulør 3 = Klør

int kort1Værdi = 2;
int kort1Kulør = 1;

int kort2Værdi = 2;
int kort2Kulør = 2;
```

vil det være oplagt at skabe en enumeration. Så din opgave er at skabe en enum kaldet KortKulør med de fire mulige værdier. Herefter skal du "rydde op" i ovennævnte kode så den bliver nemmere både at skrive og læse.

- Prøv eventuelt at tildele egne værdier (spar = 10, hjerter = 20, ...).
- Prøv eventuelt at skrive værdien af kort1Kulør ud - både som tekst og som nummer (se løsning)

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Variabler-regnemaskine/Program.cs) for inspiration.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
