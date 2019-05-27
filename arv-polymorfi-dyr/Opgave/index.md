# Arv (Polymorfi)

Du skal skabe en konsol applikation med følgende klasser

* Dyr – med egenskaben Navn og metoden SigNoget() (skriver til konsol: Jeg er et dyr og hedder …). Man må ikke kunne skabe en instans af Dyr (måske en abstrakt klasse? måske en abstrakt metode SigNoget()?).
* Hund – der arver fra Dyr og overskriver SigNoget() (skriver til konsol: Jeg er en hund og hedder …)
* Kat - der arver fra Dyr og overskriver SigNoget() (skriver til konsol: Jeg er en kat og hedder …)

Test både Hund og Kat ved at skabe instanser og kalde SigNoget().

Prøv også at skabe en List<Dyr>, put 5-6 forskellige dyr på listen, og løb listen igennem og kald SigNoget(). Giver resultatet mening?

-------------------

Du kan evt. udvide opgaven ved at skabe en statisk metode TilfældigtDyr() på Dyr-klassen, som enten returnerer en Hund eller en Kat med et tilfældigt navn fra filen dyrenavne.txt (se repository). Brug System.Random til at finde et tilfældigt tal, og brug dette til at finde og returnere et tilfældigt Dyr (hund/kat) med et tilfældigt navn. 
Du kan bruge dette array af navne til at navngive dyret:

```csharp
string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
string[] navne = data.Split(';');
```

Skab 20 dyr og placer dem i et array af Dyr. Løb herefter arrayet igennem og kald SigNoget() (som runtime jo ved findes på både Hund og Kat fordi den kommer fra Dyr).

PS - TilfældigtDyr() kan evt. kodes som

```csharp

private static System.Random rnd = new Random();

public static Dyr TilfældigtDyr()
{

	string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
	data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
	data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
	data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
	string[] navne = data.Split(';');    
	int index = rnd.Next(0, navne.Length);
    if (index % 2 == 0)
    {
        return new Hund() { Navn = navne[index] };
    }
    else
    {
        return new Kat() { Navn = navne[index] };
    }
}
```

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/arv-polymorfi-dyr/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
