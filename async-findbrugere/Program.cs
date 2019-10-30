using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace async_findbrugere
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");
            string url = $"http://www.filltext.com" +
                "?rows=10&Id={index}&Brugernavn={username}&Password={randomString|5}";
            using HttpClient c = new HttpClient();
            string json = await c.GetStringAsync(url);
            var brugere = System.Text.Json.JsonSerializer.Deserialize<List<Bruger>>(json);
            foreach (var bruger in brugere)
                Console.WriteLine($"{bruger.Id} {bruger.Brugernavn} {bruger.Password}");
            Console.WriteLine("Slut");
        }

    }

    public class Bruger
    {
        public int Id { get; set; }
        public string Brugernavn { get; set; }
        public string Password { get; set; }

    }
}
