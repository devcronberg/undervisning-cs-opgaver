using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace async_task
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DanFil(@"c:\temp\a1.txt");

            //string t = HentTekst(@"c:\temp\a1.txt").Result;
            string t = await HentTekst(@"c:\temp\a1.txt");
            Console.WriteLine(t);
        }

        public static async Task<string> HentTekst(string fil)
        {
            using (var stream = System.IO.File.OpenText(fil))
            {
                return await stream.ReadToEndAsync();
            }
        }


        public static void DanFil(string fil)
        {
            if (System.IO.File.Exists(fil))
                System.IO.File.Delete(fil);

            using (var s = System.IO.File.AppendText(fil))
                for (int i = 0; i < 1000; i++)
                    s.WriteLine(Guid.NewGuid().ToString());
        }
    }
}