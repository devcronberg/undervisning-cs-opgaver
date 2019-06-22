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

namespace expressiontrees_repository
{
    public class Person
    {
        public int Alder { get; set; }
        public string Navn { get; set; }
        public override string ToString()
        {
            return $"Navn: {Navn}, Alder: {Alder}";
        }
    }

    public interface IPersonRepository
    {
        List<Person> HentPersoner();
        List<Person> HentPersoner(int count);
        List<Person> HentPersoner<orderByType>(Expression<Func<Person, bool>> filter, Expression<Func<Person, orderByType>> sorterEfter);
        List<Person> HentPersoner<orderByType>(Expression<Func<Person, orderByType>> sorterEfter);
    }

    public class PersonRepository : IPersonRepository
    {
        // "Emulering af LINQ collection"
        private IQueryable<Person> _p;

        public PersonRepository(IEnumerable<Person> lst)
        {
            this._p = lst.AsQueryable<Person>();
        }

        public List<Person> HentPersoner()
        {
            return _p.OrderBy(i => i.Navn).ToList();
        }

        public List<Person> HentPersoner(int count)
        {
            return HentPersoner().Take(count).ToList();
        }

        public List<Person> HentPersoner<T>(Expression<Func<Person, T>> sorterEfter)
        {
            return _p.OrderBy(sorterEfter).ToList();
        }

        public List<Person> HentPersoner<T>(Expression<Func<Person, bool>> filter, Expression<Func<Person, T>> sorterEfter)
        {
            return _p.Where(filter).OrderBy(sorterEfter).ToList();
        }
    }

}
