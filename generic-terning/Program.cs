using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            YatzyTerning y = new YatzyTerning();
            Console.WriteLine(y);
            LudoTerning l = new LudoTerning();
            Console.WriteLine(l);

            //Bæger b = new Bæger();
            //// Man kan tilføje begge typer...
            //b.Tilføj(new YatzyTerning());
            //b.Tilføj(new LudoTerning());
            //// Få fat i en terning kræver typekonvertering
            //LudoTerning e = b.Terninger()[1] as LudoTerning;
            //Console.WriteLine(e.ErGlobus());

            Bæger<LudoTerning> b = new Bæger<LudoTerning>();
            // Man tvinges til at arbejde med Ludo-terninger
            b.Tilføj(new LudoTerning());
            b.Tilføj(new LudoTerning());
            // Ingen typekonverting
            LudoTerning e = b.Terninger()[1];
            Console.WriteLine(e.ErGlobus());



        }
    }

    public abstract class Terning
    {
        private static System.Random rnd = new Random();
        public int Værdi { get; private set; }
        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }
        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }
    }

    public class YatzyTerning : Terning
    {
        public YatzyTerning()
        {
            this.Ryst();
        }
    }
    public class LudoTerning : Terning
    {
        public override string ToString()
        {
            if (this.ErStjerne())
                return "[S]";
            if (this.ErGlobus())
                return "[G]";
            return base.ToString();
        }

        public LudoTerning()
        {
            this.Ryst();
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }
    }

    //public class Bæger
    //{
    //    private List<Terning> lst = new List<Terning>();
    //    public void Tilføj(Terning d)
    //    {
    //        lst.Add(d);
    //    }
    //    public List<Terning> Terninger()
    //    {
    //        return lst;
    //    }
    //}

    public class Bæger<T> where T : Terning
    {
        private List<T> lst = new List<T>();
        public void Tilføj(T d)
        {
            lst.Add(d);
        }
        public List<T> Terninger()
        {
            return lst;
        }
    }


}
