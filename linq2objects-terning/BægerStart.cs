using linq2objects_terning;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq2objects_terning_start
{
    class Bæger
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
            s.AppendLine("Lav       : " + Lav());
            s.AppendLine("Høj       : " + Høj());
            s.AppendLine("Fuldt hus : " + FuldtHus());
            s.AppendLine("Yatzy     : " + Yatzy());
            return s.ToString();
        }

        public bool EtPar()
        {
            return true; // mangler
        }

        public bool ToPar()
        {
            return true; // mangler
        }

        public bool TreEns()
        {
            return true; // mangler
        }

        public bool FireEns()
        {
            return true; // mangler
        }

        public bool FuldtHus()
        {
            return true; // mangler
        }

        public bool Lav()
        {
            return true; // mangler            
        }

        public bool Høj()
        {
            return true; // mangler        
        }

        public bool Yatzy()
        {
            return true; // mangler        
        }
    }
}
