using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNuGetPackage
{
    public class PersonRepositoryDummy : IPersonRepository
    {
        public Person GetPerson()
        {
            return GetPerson(1);
        }

        public Person GetPerson(int PersonId)
        {
            return new Person() { Name = "Test", DateOfBirth = DateTime.Now, Height = 100, IsHealthy = true, PersonId = PersonId };
        }

        public List<Person> GetPeople(int count)
        {
            List<Person> p = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                p.Add(GetPerson(i + 1));
            }
            return p;
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
