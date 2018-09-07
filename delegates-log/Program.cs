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

    public delegate void LogDelegate(string txt);  
    public class Maskine
    {

        public LogDelegate Log { get; set; }    

        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }

    public class Maskine2
    {

        public Action<string> Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }
}
