using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace data_ef_sqlite
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SQLiteEF.PeopleContext c = new SQLiteEF.PeopleContext())
            {
                List<SQLiteEF.Person> lst;
                lst = c.People.ToList();
                lst.ForEach(i => Console.WriteLine(i));
                Console.WriteLine();

                lst = c.People.Take(5).ToList();
                lst.ForEach(i => Console.WriteLine(i));

                Console.WriteLine();
                lst = c.People.OrderBy(i => i.LastName).ToList();
                lst.ForEach(i => Console.WriteLine(i));


                Console.WriteLine();
                lst = c.People.OrderBy(i => i.Gender).ThenBy(i => i.LastName).ToList();
                lst.ForEach(i => Console.WriteLine(i));

                Console.WriteLine();
                lst = c.People.Where(i => i.Gender == 1).ToList();
                lst.ForEach(i => Console.WriteLine(i));

                Console.WriteLine();
                lst = c.People.Where(i => i.Gender == 1 && i.IsHealthy).ToList();
                lst.ForEach(i => Console.WriteLine(i));

                Console.WriteLine();
                lst = c.People.Where(i => i.Gender == 1 && i.IsHealthy).OrderBy(i => i.LastName).ToList();
                lst.ForEach(i => Console.WriteLine(i));

                Console.WriteLine();

                var p = c.People.Where(i => i.PersonId == 1).FirstOrDefault();
                p.Height = 150;
                c.SaveChanges();

                Console.WriteLine();
                p = new SQLiteEF.Person();
                p.FirstName = "a";
                p.LastName = "b";
                p.DateOfBirth = DateTime.Now;
                p.Gender = 1;
                p.Height = 180;
                p.IsHealthy = true;
                c.People.Add(p);
                c.SaveChanges();
                int id = p.PersonId;
                Console.WriteLine($"Person oprettet med {id}");

                p = c.People.Where(i => i.PersonId == id).FirstOrDefault();
                c.People.Remove(p);
                c.SaveChanges();
            }
        }
    }



}


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
