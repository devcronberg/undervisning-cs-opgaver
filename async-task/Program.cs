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
            // Brug denne til at skabe en fil
            // DanFil(@"c:\temp\a1.txt");

            try
            {
                string t1 = await HentTekst(@"c:\temp\a1.txt");
                string t2 = await HentTekst1(@"c:\temp\a1.txt");
                
                Console.WriteLine(t1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        public static async Task<string> HentTekst(string fil)
        {
            using (var stream = System.IO.File.OpenText(fil))
            {
                return await stream.ReadToEndAsync();
            }
        }



        public static Task<string> HentTekst1(string fil)
        {
            Task<string> res;
            using (var stream = System.IO.File.OpenText(fil))
            {
                res =  stream.ReadToEndAsync();
            }
            return res;
        }


        public static void DanFil(string fil)
        {
            if (System.IO.File.Exists(fil))
                System.IO.File.Delete(fil);

            using (var s = System.IO.File.AppendText(fil))
                for (int i = 0; i < 10000; i++)
                    s.WriteLine(Guid.NewGuid().ToString());
        }
    }
}
