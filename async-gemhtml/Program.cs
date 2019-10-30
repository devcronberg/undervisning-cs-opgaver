using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace async_gemhtml
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");
            using HttpClient c = new HttpClient();
            Console.WriteLine("Henter HTML");
            string html = await c.GetStringAsync("https://www.teknologisk.dk");
            Console.WriteLine($"Henter hentet - {html.Length} tegn");

            Console.WriteLine("Gemmer fil1");
            Task t1 = System.IO.File.AppendAllTextAsync("c:\\temp\\fil1.html", html);
            Console.WriteLine("Gemmer fil2");
            Task t2 = System.IO.File.AppendAllTextAsync("c:\\temp\\fil2.html", html);
            Console.WriteLine("Gemmer fil3");
            Task t3 = System.IO.File.AppendAllTextAsync("c:\\temp\\fil3.html", html);
            await Task.WhenAll(t1, t2, t3);
            Console.WriteLine("Slut");
        }
    }
}
