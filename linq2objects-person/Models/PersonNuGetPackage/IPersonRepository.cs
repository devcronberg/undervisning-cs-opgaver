using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNuGetPackage
{
    public interface IPersonRepository
    {
        Person GetPerson();
        Person GetPerson(int PersonId);
        List<Person> GetPeople(int count);
        List<Person> Get5People();
        List<Person> Get10People();
    }


}
