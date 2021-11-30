using System;
using System.Collections.Generic;
using System.IO;

namespace indkapsling_deserialisering
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string json = System.IO.File.ReadAllText(@"c:\temp\data.json");
            List<Person> lst = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(json);
            foreach (var item in lst)
                Console.WriteLine(item.Navn);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public bool ErDansk { get; set; }
        public DateTime Dato { get; set; }
    }

}
