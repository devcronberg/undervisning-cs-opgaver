using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace async_webclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App start");

            Console.WriteLine("Henter tilfældige tal synkront");
            List<string> lst1 = new List<string>();
            for (int i = 0; i < 10; i++)
                lst1.Add(TilFældigTalSync(10, 100));
            foreach (var item in lst1)
                Console.Write(Convert.ToInt32(item) + " ");

            Console.WriteLine("\r\nHenter tilfældige tal asynkront");
            List<Task<string>> lst2 = new List<Task<string>>();
            for (int i = 0; i < 10; i++)
                lst2.Add(TilFældigTalASync(10, 100));

            // WaitAll
            Task.WaitAll(lst2.ToArray());
            foreach (var item in lst2)
                Console.Write(Convert.ToInt32(item.Result) + " ");

            // WhenAll
            //Task.WhenAll(lst2.ToArray()).ContinueWith(t =>
            //{
            //    foreach (var item in t.Result)
            //        Console.Write(Convert.ToInt32(item) + " ");
            //});


            Console.WriteLine("\r\nApp slut");
            Console.ReadLine();
        }

        static string TilFældigTalSync(int min, int max)
        {
            WebClient w = new WebClient();
            string res = w.DownloadString(new Uri("https://www.random.org/integers/?num=1&min=" + min.ToString() + "&max=" + max + "&col=1&base=10&format=plain&rnd=new"));
            return res;
        }

        static Task<string> TilFældigTalASync(int min, int max)
        {
            HttpClient c = new HttpClient();
            var res = c.GetStringAsync("https://www.random.org/integers/?num=1&min=" + min.ToString() + "&max=" + max + "&col=1&base=10&format=plain&rnd=new");
            return res;
        }

    }
}
