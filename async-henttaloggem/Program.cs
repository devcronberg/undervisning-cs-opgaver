using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace async_henttaloggem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new";
            // Bør bruge using men glem det lige nu
            HttpClient w = new HttpClient();
            Console.WriteLine("Henter tal");
            string tal = await w.GetStringAsync(url);
            Console.WriteLine("Tal hentet");
            await System.IO.File.AppendAllTextAsync(@"c:\temp\tal.txt", tal);
            Console.WriteLine("Tal gemt");
        }
    }
}
