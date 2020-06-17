using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;

namespace delegates_terning
{
    public delegate void MinD();
    class Program
    {
        static void Main(string[] args)
        {
Terning t1 = new Terning();
Console.WriteLine(t1.Værdi);
t1.Ryst();
Console.WriteLine(t1.Værdi);
            
Console.WriteLine();

Terning t2 = new Terning(() => 6);
Console.WriteLine(t2.Værdi);
t2.Ryst();
Console.WriteLine(t2.Værdi);

Console.WriteLine();

Terning t3 = new Terning(() => {
    using (System.Net.WebClient w = new System.Net.WebClient())
    {
        string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
        return Convert.ToInt32(s);
    }
});
Console.WriteLine(t3.Værdi);
t3.Ryst();
Console.WriteLine(t3.Værdi);








        }
    }

    class Terning {
        
        private Func<int> rystDelegate;
        public int Værdi { get; private set; }
        public Terning(Func<int> ryst=null)
        {
            if (ryst == null)
                ryst = () => new Random().Next(1, 7);
            this.rystDelegate = ryst;
            
            Ryst();
        }

        public void Ryst() {
            this.Værdi = this.rystDelegate();
        }

    }
}
