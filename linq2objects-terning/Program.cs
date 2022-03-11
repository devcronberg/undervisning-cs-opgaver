using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq2objects_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Bæger b1 = new Bæger(3, 3, 3, 4, 2);
            Console.WriteLine(b1);
            Console.WriteLine();
            Bæger b2 = new Bæger();
            Console.WriteLine(b2);

        }
    }

    class Terning
    {

        public int Værdi { get; private set; }
        private static Random rnd = new Random();

        public Terning()
        {
            Ryst();

        }

        public Terning(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                throw new Exception("Forkert værdi");
            this.Værdi = værdi;
        }

        private void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public override string ToString()
        {
            return $"[ {Værdi} ]";
        }
    }

    public class Bæger
    {

        private Terning[] terninger;

        public Bæger()
        {
            terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
                terninger[i] = new Terning();
        }

        public Bæger(int v1, int v2, int v3, int v4, int v5)
        {
            terninger = new Terning[5];
            terninger[0] = new Terning(v1);
            terninger[1] = new Terning(v2);
            terninger[2] = new Terning(v3);
            terninger[3] = new Terning(v4);
            terninger[4] = new Terning(v5);

        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Bæger med terninger");
            s.AppendLine("-------------------");
            s.AppendLine(string.Join(' ', terninger.OrderBy(i => i.Værdi).ToList()));
            s.AppendLine();
            s.AppendLine("Et par    : " + EtPar());
            s.AppendLine("To par    : " + ToPar());
            s.AppendLine("Tre ens   : " + TreEns());
            s.AppendLine("Fire ens  : " + FireEns());
            s.AppendLine("Lav       : " + Lav());
            s.AppendLine("Høj       : " + Høj());
            s.AppendLine("Fuldt hus : " + FuldtHus());
            s.AppendLine("Yatzy     : " + Yatzy());
            return s.ToString();
        }

        // Finder en liste af grupper 

        // Hvis bægeret indeholder 1, 1, 2, 3, 4 er grupper = 
        // [{ Værdi: 1, Antal: 2 },
        // { Værdi: 2, Antal: 1 },
        // { Værdi: 3, Antal: 1 },
        // { Værdi: 4, Antal: 1 },
        // { Værdi: 5, Antal: 0 },
        // { Værdi: 6, Antal: 0 }]

        // Grupper kan efterfølgende bruges i mange af metoderne
        private List<TerningGruppe> FindGrupper()
        {
            List<TerningGruppe> grupper = new List<TerningGruppe>();
            for (int i = 1; i < 7; i++)
                grupper.Add(new TerningGruppe { Værdi = i, Antal = terninger.Count(t => t.Værdi == i) });
            return grupper;
        }

        public bool EtPar()
        {
            return FindGrupper().Any(i => i.Antal >= 2);
        }

        public bool ToPar()
        {
            return FindGrupper().Where(i => i.Antal >= 2).Count() == 2;
        }

        public bool TreEns()
        {
            return FindGrupper().Any(i => i.Antal >= 3);
        }

        public bool FireEns()
        {
            return FindGrupper().Any(i => i.Antal >= 4);
        }

        public bool FuldtHus()
        {
            return FindGrupper().Count(i => i.Antal > 1) == 2;
        }

        public bool Lav()
        {
            var t = terninger.OrderBy(i => i.Værdi).ToList();
            return t[0].Værdi == 1 && t[1].Værdi == 2 && t[2].Værdi == 3 && t[3].Værdi == 4 && t[4].Værdi == 5;
        }

        public bool Høj()
        {
            var t = terninger.OrderBy(i => i.Værdi).ToList();
            return t[0].Værdi == 2 && t[1].Værdi == 3 && t[2].Værdi == 4 && t[3].Værdi == 5 && t[4].Værdi == 6;
        }


        public bool Yatzy()
        {
            return FindGrupper().Any(i => i.Antal == 5);
        }

        private class TerningGruppe
        {
            public int Værdi { get; set; }
            public int Antal { get; set; }
        }
    }
}
