using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNuGetPackage
{
    public class PersonRepositoryRandom : IPersonRepository
    {
        private static Random r = new Random();
        private static List<Country> CountriesAll = PersonHelperMethods.GetAllCountries();

        public Person GetPerson()
        {
            return GetPerson(1);
        }

        public Person GetPerson(int PersonId)
        {
            Person p = new Person();
            {
                p.PersonId = PersonId;
                p.Name = PersonHelperMethods.GetRandomName();
                p.DateOfBirth = DateTime.Now.Date.AddDays(-r.Next(1, 36000));
                p.Height = r.Next(150, 200);
                p.IsHealthy = r.Next(0, 10) >= 5 ? true : false;
                p.Gender = r.Next(0, 10) >= 5 ? Gender.Female : Gender.Male;
                p.CountryId = CountriesAll[r.Next(0, CountriesAll.Count)].Clone().CountryId;
                return p;
            };
        }

        public List<Person> GetPeople(int count)
        {
            List<Person> lst = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                lst.Add(GetPerson(i + 1));
            }
            return lst;
        }

        public List<Person> Get5People()
        {
            return GetPeople(5);
        }

        public List<Person> Get10People()
        {
            return GetPeople(10);
        }

    }
}
