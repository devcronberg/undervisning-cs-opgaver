# Data (SQLite/EF)

Du skal skabe en konsol app hvor du kan øve dig lidt på brugen af Entity Framework.

## Setup
Opgaven benytter en SQLite database (simpel filbaseret database) som du kan hente [ved at klikke her](https://github.com/devcronberg/undervisning-db-sqlite/raw/master/db-download/people.db). Databasen skal du placere i mappen c:\temp. Samtidigt skal du 
installere NuGet-pakkerne:

```
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.Extensions.Logging
```

Du kan evt læse mere om brugen af [People-database her](https://github.com/devcronberg/undervisning-db-sqlite/).

Tilføj følgende kode (enten i program.cs eller en fil for sig selv - men sørg for at koden ikke placeres i et namespace):

```csharp
namespace SQLiteEF
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.DependencyInjection;

    [Table("person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsHealthy { get; set; }
        public int Gender { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"I'm {FirstName} {LastName} with id {PersonId} born {DateOfBirth.ToShortDateString()}. I'm {(IsHealthy ? "healthy" : "not healthy")}, a {(Gender == 1 ? "woman" : "man")} and {Height} cm.";
        }
    }

    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\temp\\people.db");
            // Enable logging to console
            // optionsBuilder.UseLoggerFactory(GetLoggerFactory());

        }
        
        // For logging...
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddConsole()
                          .AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }
    }
}
```

Placer denne kode i Main:

```csharp
using (SQLiteEF.PeopleContext c = new SQLiteEF.PeopleContext())
{                
    List<SQLiteEF.Person> lst;
    lst = c.People.Take(5).ToList();
    lst.ForEach(i => Console.WriteLine(i));
}
```
Ved afvikling skulle du gerne se fem personer i konsol.

Prøv nu at fjerne kommentar i OnConfiguring i PeopleContext-klassen så EF logger til konsol:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlite("Data Source=c:\\temp\\people.db");
    // Enable logging to console
    optionsBuilder.UseLoggerFactory(GetLoggerFactory());

}
```
Prøv at afvikle igen - kan du se EF log i konsol (SQL mv)? Du kan udkommentere log igen - men så ved du hvordan 
du kan se de SQL kald som EF skaber.

## Opgave

Du skal nu skrive koden til at 

- Udskrive samtlige personer
- Udskrive de 5 første personer
- Udskrive samtlige personer sorteret efter LastName
- Udskrive samtlige personer sorteret efter Gender og så LastName
- Udskrive samtlige personer hvor gender = 1 (kvinder)
- Udskrive samtlige personer hvor gender = 1 (kvinder) og IsHealthy = true
- Udskrive samtlige personer hvor gender = 1 (kvinder) og IsHealthy = true sorteret efter LastName
- Gruppere samtlige personer efter IsHealthy, og udskrive dem

Se min løsning [her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/data-ef-sqlite/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
