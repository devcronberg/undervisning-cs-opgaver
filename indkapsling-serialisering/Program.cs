using System;
using System.Collections.Generic;

namespace indkapsling_serialisering
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lst = HentPersonerSomObjekter(@"c:\temp\data.csv");
            foreach (var item in lst)
                Console.WriteLine(item.Navn);
            GemPersonSomJson(lst, @"c:\temp\data.json");

        }

        private static void GemPersonSomJson(List<Person> lst, string sti)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(lst, new System.Text.Json.JsonSerializerOptions() { WriteIndented = true });
            System.IO.File.WriteAllText(sti, json);
        }

        public static List<Person> HentPersonerSomObjekter(string sti) {
            var linjer = System.IO.File.ReadAllLines(sti);
            List<Person> lst = new List<Person>();
            foreach (var linje in linjer)
            {
                var poster = linje.Split(';');
                lst.Add(new Person { Navn = poster[0], Alder = Convert.ToInt32(poster[1]), ErDansk = Convert.ToBoolean(poster[2]) });
            }
            return lst;
        }
    }

    class Person {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public bool ErDansk { get; set; }
    }
}
