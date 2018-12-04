# Arv (Abstrakt klasse)

Du skal skabe en tom konsol app med 

* en abstrakt klasse Person der har
  * egenskaberne id og navn (int og string)
  * metoden Skriv1() som blot skriver "Person med id {Id} og navn {Navn}"
  * metoden Skriv2() som er abstrakt

* en klasse Kursist som arver fra Person der har
  * sin implementation af metoden Skriv2() som blot skriver "Kursist med id {Id} og navn {Navn}"

Prøv det af i Main og check at følgende kode giver det ønskede resultat:

```csharp
Kursist k = new Kursist() { Id = 1, Navn = "a" };
k.Skriv1();
k.Skriv2();

// Person med id 1 og navn a
// Kursist med id 1 og navn a
```

Spørgsmål: 

* Kan man skabe en instans af Person?
* Kan Skriv2 i Person indeholde kode?

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/arv-abstrakt-klasse/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
