using System;

namespace delegates_log
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;
            m.Start();
            m.Stop();

        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
    }

    public class Maskine
    {

        public Action<string> Log { get; set; }

        public void Start()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }
}
