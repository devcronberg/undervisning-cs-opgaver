using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2objects_person
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = MCronberg.PersonRepositoryStatic.JustGetPeople();
            foreach (var person in people)
                Console.WriteLine(person.Name);

            Console.WriteLine();
            var res1 = people.OrderBy(i => i.Name);
            var res1l = from person in people orderby person.Name select person;
            foreach (var person in res1)
                Console.WriteLine(person.Name);

            Console.WriteLine();
            var res2 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            var res2l = from person in people orderby person.Gender, person.Name select person;
            foreach (var person in res2)
                Console.WriteLine(person.Name + " " + person.Gender);

            Console.WriteLine();
            var res3 = people.Where(i => i.Height < 170);
            var res3l = from person in people where person.Height < 170 select person;
            foreach (var person in res3)
                Console.WriteLine(person.Name + " " + person.Height);

            Console.WriteLine();
            var res4 = people.Where(i => i.Height < 170 && i.IsHealthy);
            foreach (var person in res4)
                Console.WriteLine(person.Name + " " + person.Height + " " + person.IsHealthy);

            Console.WriteLine();
            var res5 = people.GroupBy(i => i.Gender);
            foreach (var group in res5)
            {
                Console.WriteLine(group.Key);
                foreach (var person in group)
                    Console.WriteLine("  => " + person.Name + " " + person.Gender);
            }

            Console.WriteLine();
            var res6 = people.OrderBy(i => i.Name).Select(i => new { Name = i.Name, Height = i.Height });
            foreach (var person in res6)
            {
                Console.WriteLine(person.Name + " " + person.Height);
            }

            Console.WriteLine();
            var res7 = people.OrderBy(i => i.Height).GroupBy(i => i.Height / 10);
            foreach (var group in res7)
            {
                Console.WriteLine(group.Key * 10);
                foreach (var person in group)
                {
                    Console.WriteLine("  => " + person.Name + " " + person.Height);
                }
            }

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
