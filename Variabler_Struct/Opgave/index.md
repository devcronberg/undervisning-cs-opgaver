# Struct

Du skal skabe en del af en applikation der kan bruges i et ERP (Enterprise Resource Planning) system, og her skal du arbejde meget med varer. Derfor vil det være oplagt at have din egen datatype til at kunne gemme data relateret til en vare. 

Du skal derfor oprette en ny tom konsol applikation og tilføje en struct kaldet Vare. Den skal indeholde:

Id (int)
Navn (string)
Beskrivelse (string)
Pris (double)
... (find evt på flere)

Når du har oprettet strukturen skal du prøve den af i main som følger:

```csharp
Vare v1 = new Vare();
v1.Id = 1;
v1.Navn = "Vare #1";
v1.Beskrivelse = "Min beskrivelse til #1";
v1.Pris = 100;
Console.WriteLine($"{v1.Navn} koster {v1.Pris:N2}");

Vare v2 = new Vare();
v2.Id = 2;
v2.Navn = "Vare #2";
v2.Beskrivelse = "Min beskrivelse til #2";
v2.Pris = 200;
Console.WriteLine($"{v2.Navn} koster {v2.Pris:N2}");

Vare v2Kopi = v2;
Console.WriteLine($"{v2Kopi.Navn} koster {v2Kopi.Pris:N2}");
```

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/tree/master/Variabler_Struct) for inspiration.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
