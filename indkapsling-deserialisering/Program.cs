﻿using System;
using System.Collections.Generic;
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

            // Bare for sjov - gem som xml
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
            System.IO.TextWriter writer = new System.IO.StreamWriter(@"c:\temp\data.xml");
            x.Serialize(writer, lst);

            // Bare for sjov - brug ServiceStack.Text (NuGet) til at gemme som CSV            
            ServiceStack.Text.CsvConfig.ItemSeperatorString = ";";  // Dansk format
            System.IO.File.WriteAllText(@"c:\temp\data.csv", ServiceStack.Text.CsvSerializer.SerializeToString(lst));
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public bool ErDansk { get; set; }
        public DateTime Dato { get; set; }
    }

}
