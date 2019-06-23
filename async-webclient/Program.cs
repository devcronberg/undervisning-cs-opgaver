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

            Console.WriteLine("Henter tilfældige tal synkront");
            List<string> lst1 = new List<string>();
            for (int i = 0; i < 10; i++)
                lst1.Add(TilFældigTalSync(10, 100));
            Console.WriteLine("Tilfældige tal hentet synkront");
            foreach (var item in lst1)
                Console.Write(Convert.ToInt32(item) + " ");

            Console.WriteLine();
            Console.WriteLine("Henter tilfældige tal asynkront");
            List<Task<string>> lst2 = new List<Task<string>>();
            for (int i = 0; i < 10; i++)
                lst2.Add(TilFældigTalASync(10, 100));
            Task.WaitAll(lst2.ToArray());
            Console.WriteLine("Tilfældige tal hentet asynkront");
            foreach (var item in lst2)
                Console.Write(Convert.ToInt32(item.Result) + " ");
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
