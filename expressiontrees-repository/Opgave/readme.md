# Expression (repository)

I denne applikation skal du skabe et simpelt repository til at hente personer på forskellig måde - LINQ/EF style. Start med at
skabe en tom console-applikation og tilføje 

- en klasse Person med egenskaberne
	- Navn (string)
	- Alder (int)
	- override ToString()
		bare returner Navn og Alder så det er nemt at udskrive

- en klasse PersonRepository med
	- En constructor som tager en liste (IEnumerable\<Person\>) af tilfældige personer, og gemmer disse i et private felt. Denne samling skal simulere
	en "database"
		- Felter skal være af typen IQueryable\<Person\> for at simulere LINQ to EF
		- For at gemme som IQueryable kan du kalde AsQueryable\<Person\>()
	- En metode List\<Person\> HentPersoner(), som returnerer alle personerne sorteret efter Navn
	- En metode List\<Person\> HentPersoner(), som modtager en int og returnerer et antal personer sorteret efter Navn
	- En metode List\<Person\> HentPersoner()\<T\>, som modtager en Expression svarende til den der skal benyttes af LINQs OrderBy, og returnerer personer sorteret efter den angivne expression
	- En metode List\<Person\> HentPersoner()\<T\>, som modtager en Expression svarende til den der skal benyttes af LINQs Where, og en Expression svarende til den der skal benyttes af LINQs OrderBy, og returnerer personer filtreret og sorteret efter de angivne expression's'

Kig på signaturen til LINQs expressions brugt i Where og OrderBy før du skaber de sidste to metoder.

Når klassen er færdig så udtræk alle metoder til et interface kaldet IPersonRepository, og prøv følgende kode:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Console;

namespace expressiontrees_repository
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst = new List<Person>() {
                new Person() { Navn = "b", Alder = 20 },
                new Person() { Navn = "a", Alder = 10 },
                new Person() { Navn = "d", Alder = 15 },
                new Person() { Navn = "c", Alder = 5 }
            };
            IPersonRepository r = new PersonRepository(lst);
            r.HentPersoner().ForEach(p => WriteLine(p));
            WriteLine();
            r.HentPersoner(2).ForEach(p => WriteLine(p));
            WriteLine();
            r.HentPersoner(p => p.Alder).ForEach(p => WriteLine(p));
            WriteLine();
            r.HentPersoner(p => p.Alder >= 15, p => p.Navn).ForEach(p => WriteLine(p));
            WriteLine();

        }
    }
}
```

Det skulle gerne give følgende resultat:

```
Navn: a, Alder: 10
Navn: b, Alder: 20
Navn: c, Alder: 5
Navn: d, Alder: 15

Navn: a, Alder: 10
Navn: b, Alder: 20

Navn: c, Alder: 5
Navn: a, Alder: 10
Navn: d, Alder: 15
Navn: b, Alder: 20

Navn: b, Alder: 20
Navn: d, Alder: 15
```

Se eventuelt [min løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/expressiontrees-repository/Program.cs).


<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
