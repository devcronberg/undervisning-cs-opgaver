# Arv (Polymorfi)

Du skal skabe en konsol applikation med følgende klasser
* Dyr – med egenskaben Navn og metoden SigNoget() (skriver til konsol: Jeg er et dyr og heder …). Man må ikke kunne skabe en instans af Dyr.
* Hund – der arver fra Dyr og overskriver SigNoget() (skriver til konsol: Jeg er en hund og hedder …)
* Kat - der arver fra Dyr og overskriver SigNoget() (skriver til konsol: Jeg er en kat og hedder …)

Test både Hund og Kat ved at skabe instanser og kalde SigNoget().

På Dyr skal du nu skabe en statisk metode TilfældigtDyr() som enten returnerer en Hund eller en Kat med et tilfældigt navn fra filen dyrenavne.txt (se fællesdrev). Brug System.Random til at finde et tilfældigt tal, og brug dette til at finde og returnere et tilfældigt Dyr. 
Følgende skaber et array af navne fra en fil som du kan bruge til at navngive dyret:

```csharp
string sti = @"x:\dyrenavne.txt";
string[] navne = System.IO.File.ReadAllLines(sti);
```

Skab 20 dyr og placer dem i et array af Dyr. Løb herefter arrayet igennem og kald SigNoget() (som runtime jo ved findes på både Hund og Kat fordi den kommer fra Dyr).
