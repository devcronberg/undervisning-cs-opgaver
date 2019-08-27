using System;
using System.Collections.Generic;

namespace klasser_amort
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto();
            k.transaktioner.Add(new Transaktion(new DateTime(2019, 1, 1), "Indsat", 100));
            k.transaktioner.Add(new Transaktion(new DateTime(2019, 2, 1), "Indsat", 250));
            k.transaktioner.Add(new Transaktion(new DateTime(2019, 3, 1), "Hævet", -75));
            Console.WriteLine($"Saldo: {k.Saldo():N2}");
            Console.WriteLine(k.KontoUdtog());
        }
    }

    class Transaktion
    {
        public DateTime dato;
        public string tekst;
        public decimal beløb;

        public Transaktion(DateTime dato, string tekst, decimal beløb)
        {
            this.dato = dato;
            this.tekst = tekst;
            this.beløb = beløb;
        }
    }

    class Konto
    {
        public List<Transaktion> transaktioner;

        public Konto()
        {
            transaktioner = new List<Transaktion>();
        }

        public decimal Saldo()
        {
            decimal sum = 0;
            foreach (var item in this.transaktioner)
            {
                sum += item.beløb;
            }
            return sum;
        }

        public string KontoUdtog()
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (var item in this.transaktioner)
            {
                s.AppendLine($"{item.dato.ToShortDateString()} {item.tekst,-15} {item.beløb,15:N2}");
            }
            return s.ToString();
        }
    }
}
