using System;
using System.Collections.Generic;

namespace indkapsling_immutable_klasse
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p1 = new Person(1, "Mikkel");
            Console.WriteLine(p1.Navn);
            // p1.Navn = "Mathias";     // Fejl
            Console.WriteLine(p1);      // Person { PersonId: 1, Navn: Mikkel }

            // Hvis du ønsker en kopi med ændrede data må du
            Person p2 = new Person(2, p1.Navn);
            Console.WriteLine(p2);      // Person { PersonId: 2, Navn: Mikkel }


            Person p3 = new Person(1, "Mathias");
            Person p4 = new Person(1, "Mathias");
            Console.WriteLine(p3 == p4);// false
            Console.WriteLine(ReferenceEquals(p3, p4)); // false
        }
    }

    class Person : IEquatable<Person>
    {
        public int PersonId { get; private set; }
        public string Navn { get; private set; }

        public Person(int personId, string navn)
        {
            this.PersonId = personId;
            this.Navn = navn;
        }

        public override string ToString()
        {
            return $"Person {{ PersonId: { this.PersonId }, Navn: { this.Navn } }}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   PersonId == other.PersonId &&
                   Navn == other.Navn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PersonId, Navn);
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }

    // record Person(int PersonId, string Navn);

}
