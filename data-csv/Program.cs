using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using CsvHelper;

namespace data_csv
{
    class Program
    {
        static void Main(string[] args)
        {
            string sti = "c:\\temp\\data.csv";
            foreach (var item in HentPersonerManuelt(sti).OrderBy(i => i.Dato))
                Console.WriteLine(item.Navn);
            Console.WriteLine();
            foreach (var item in HentPersonerCsvHelper(sti).OrderBy(i => i.Dato))
                Console.WriteLine(item.Navn);
        }

        static List<Person> HentPersonerManuelt(string sti)
        {

            try
            {
                string indhold = System.IO.File.ReadAllText(sti, System.Text.Encoding.UTF8);
                string[] rækker = indhold.Split("\r\n");
                List<Person> res = new List<Person>();
                for (int i = 1; i < rækker.Length; i++)
                {
                    string[] felter = rækker[i].Split(";");
                    res.Add(new Person
                    {
                        Id = Convert.ToInt32(felter[0]),
                        Navn = felter[1].Trim(),
                        ErDansk = felter[2].ToLower() == "true" ? true : false,
                        Dato = Convert.ToDateTime(felter[3])
                    }); ;

                }
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Kan ikke deserialisere " + sti, ex);
            }

        }

        static List<Person> HentPersonerCsvHelper(string sti)
        {
            try
            {
                using (var csv = new CsvReader(new StreamReader(sti, System.Text.Encoding.UTF8), new CultureInfo("da-DK")))
                    return csv.GetRecords<Person>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Kan ikke deserialisere " + sti, ex);
            }
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public DateTime Dato { get; set; }
        public bool ErDansk { get; set; }
    }
}
