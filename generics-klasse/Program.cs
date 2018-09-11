using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Personer1 p1 = new Personer1();
            p1.Tilføj(new Instruktør());

            Personer2<Instruktør> p2 = new Personer2<Instruktør>();
            p2.Tilføj(new Instruktør());

            Personer3<Instruktør> p3 = new Personer3<Instruktør>();
            p3.Tilføj(new Instruktør());

        }
    }

    class Person { }
    class Instruktør : Person { }
    class Elev : Person { }

    class Personer1
    {
        private List<Person> personer = new List<Person>();

        public void Tilføj(Person person)
        {
            personer.Add(person);
        }
    }

    class Personer2<T>
    {
        private List<T> personer = new List<T>();

        public void Tilføj(T person)
        {
            personer.Add(person);
        }
    }


    class Personer3<T> where T : Person
    {
        private List<T> personer = new List<T>();

        public void Tilføj(T person)
        {
            personer.Add(person);
        }
    }

}
