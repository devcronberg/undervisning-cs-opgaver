using System;

namespace events_filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w =
                new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += W_Changed;
            w.Created += (s, e) => { Console.WriteLine("Oprettet " + e.FullPath); };
            do { } while (true);
        }
        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }
    }
}
