using System;

namespace events_kreditmax_eventargs
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) =>
            {                
                Console.WriteLine($"Kredit overskredet - saldo = {e.Saldo:N2}");
            };
            k.Køb(100);
            k.Køb(600);

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    public class Kunde
    {
        public event EventHandler<KreditOverskredetEventArgs> KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine($"Kunde {this.Navn} køber for {værdi}");
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                if (KreditOverskredet != null)
                    KreditOverskredet(this, new KreditOverskredetEventArgs(this.Saldo));
            }
        }
    }

    public class KreditOverskredetEventArgs : EventArgs
    {

        public int Saldo { get; set; }

        public KreditOverskredetEventArgs(int saldo)
        {
            this.Saldo = saldo;
        }

    }
}
