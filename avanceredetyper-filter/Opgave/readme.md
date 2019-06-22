# Tilføj filter (delegates)

I denne opgave skal du skabe en hundekennel, som har en metode til at filtrere ved hjælp af en Predicate.

- Start med en tom konsolapplikation
- Tilføj en klasse Hund med egenskaberne 
	- Id (int)
	- Navn (string)
	- Alder (int)
- Overskriv ToString() så objekter nemt kan udskrives
	- Brug evt JSON.NET så ToString returnere en JSON string (se løsning)
- Tilføj en klasse Kennel og tilføj
	- en privat List\<Hund\> 
	- en HundInd-metode der som argument tager navn og alder, og selv finder id (max af id + 1)
	- en HundUd-metode der returnerer en Hund ud fra id, og fjerner denne fra samlingen
	- en metode FindHunde, der tager en Predicate\<Hund\> som argument, og returnerer en ny samling i filtreret form
	- klassen skal implementere IEnumerable\<Hund\> så den kan ForEach'es

Prøv med denne test kode:

```csharp
Kennel k = new Kennel();
k.HundInd("a", 10);
k.HundInd("b", 15);
k.HundInd("c", 20);
foreach (var item in k)
    Console.WriteLine(item);
Console.WriteLine();
foreach (var item in k.FindHunde(i => i.Alder >= 15))
    Console.WriteLine(item);
```

hvilket gerne skulle ende med

```
{"Id":0,"Navn":"a","Alder":10}
{"Id":0,"Navn":"b","Alder":15}
{"Id":0,"Navn":"c","Alder":20}

{"Id":0,"Navn":"b","Alder":15}
{"Id":0,"Navn":"c","Alder":20}
```

Se eventuelt [min løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/avanceredetyper-filter/Program.cs).


<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
