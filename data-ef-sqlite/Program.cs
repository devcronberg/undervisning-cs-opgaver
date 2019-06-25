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
            using (PeopleContext c = new PeopleContext())
            {


                List<Person> lst;
                //lst = c.People.ToList();
                //lst.ForEach(i => Console.WriteLine(i));

                Console.WriteLine();
                lst = c.People.Take(5).ToList();
                lst.ForEach(i => Console.WriteLine(i));

                return;

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


            }


        }
    }

    [Table("person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsHealthy { get; set; }
        public int Gender { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }

    public class PeopleContext : DbContext
    {

        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\temp\\people.db");
            // Enable logging
            // optionsBuilder.UseLoggerFactory(GetLoggerFactory());
        }

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
