# Klasser (Terning)

Du skal skabe en tom konsol app med en klasse Terning (i en fil for sig selv) med følgende medlemmer:

- En offentlig (public) int værdi
- En privat (private) bool snyd 
- En metode Skriv() som udskriver værdien (evt som [2] eller [4])
- En metode Ryst() som sætter værdi til en tilfældig værdi mellem 1-6. Dette skal dog kun ske hvis snyd = false. Hvis snyd = true så skal værdi sættes til 6.
	- Se senere hvordan du kan skrive koden i Ryst
- En default constructor der sætte værdi til 1 og snyd til false
- En custom constructor med en bool argument, der sætter værdi på terningen til en 1 og snyd til den givne værdi fra argumentet

For at skabe et tilfældigt tal mellem 1-6 i Ryst-metoden kan du benytte System.Random:

```csharp
System.Random rnd = new System.Random();
int tal = rnd.Next(1,7);
```

Klassen skal altså se således ud:

![](terning.png)

Test klassen af i Main ved at skabe instanser og kalde Ryst og Skriv. Ret snyd til true/false så du er sikker på at det virker som forventet – eksempelvis:

```csharp
Terning t1 = new Terning();
t1.Skriv();
t1.Ryst();
t1.Skriv();

Terning t2 = new Terning(true);
t2.Skriv();
t2.Ryst();
t2.Skriv();
```

Prøv at oprette et par andre objekter af klassen.

## Ekstra

Prøv også at tilføje et klassediagram (class diagram) og se klassen visuelt.

Se evt. løsning - [Terning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Klasser-terning/Terning.cs) og [Program](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Klasser-terning/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
