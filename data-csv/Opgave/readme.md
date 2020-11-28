# Opgave i CSV

I denne opgave skal du bruge en tekstfil kaldet data.csv som indeholder tilfældige person-data. Du kan eventuelt benytte disse data:

```
Id;Navn;ErDansk;Dato
1;Anders;true;29-07-1972
2;Mikkel;false;08-01-1996
3;Anette;true;13-09-1963
4;Lene;false;24-01-1990
5;Mette;true;17-05-1980
6;Sanne;true;28-11-1973
7;Mathias;false;22-01-1992
8;Jesper;false;17-09-1987
9;Lars;true;31-12-1967
10;Trine;false;29-06-1969
```

Bemærk, at det er en dansk csv-fil (benytter ; og ikke , som seperator).

Din opgave er at serialisere data til en klasse der repræsenterer en person med egenskaberne

- Id (int)
- Navn (string)
- ErDansk (bool)
- Dato (DateTime)

og du skal gøre det på to måder ved hjælp af to forskellige metoder.

I den ene metode ```kaldet List<Person> HentPersonerManuelt([sti til csv])``` skal du foretage serialisering helt manuelt ved at 
hente data med metoder fra System.IO.File og splitte linjer og felter for på den måde at skabe en liste.

I den anden metode ```kaldet List<Person> HentPersonerCsvHelper([sti til csv])``` skal du benytte NuGet-pakken CsvHelper til at skabe listen. Du kan læse 
om CsvHelper og se eksempler på deres [side](https://joshclose.github.io/CsvHelper/). Bemærk, at klassen CsvHelper tager som argument i 
konstruktør en instans af en StreamReader og en instans af CultureInfo. Sidstnævnte kan sættes til dansk med ```new CultureInfo("da-DK")```.

Benyt begge metoder til at hente og udskrive personer sorteret efter dato:

```csharp
string sti = "c:\\temp\\data.csv";            
foreach (var item in HentPersonerManuelt(sti).OrderBy(i=>i.Fødselsdato))
    Console.WriteLine(item.Navn);
Console.WriteLine();
foreach (var item in HentPersonerCsvHelper(sti).OrderBy(i => i.Fødselsdato))
    Console.WriteLine(item.Navn);
```

Se min løsning [her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/data-csv/Program.cs)