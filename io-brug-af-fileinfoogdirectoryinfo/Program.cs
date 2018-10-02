using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_brug_af_fileinfoogdirectoryinfo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@"c:\temp");
            Console.WriteLine($"Eksisterer c:\\temp: {d.Exists}");
            foreach (var item in d.GetFiles())
                Console.WriteLine(item.FullName);

            System.IO.FileInfo f = new System.IO.FileInfo("c:\\temp\\data.txt");
            Console.WriteLine($"Eksisterer c:\\temp\\data.txt: {f.Exists}");


            using (System.IO.StreamWriter s = f.CreateText())
            {                
                s.Write("xxx");                
            }

            using (System.IO.StreamWriter s = f.AppendText())
            {
                byte[] i = System.Text.Encoding.UTF8.GetBytes("yyy");
                s.Write("yyy");                
            }

            // Hent
            string indhold = "";
            using (System.IO.StreamReader r = f.OpenText()) {
                indhold = r.ReadToEnd();
            }
            Console.WriteLine(indhold);
            
            // Slet
            if (f.Exists)
                f.Delete();
        }
    }
}
