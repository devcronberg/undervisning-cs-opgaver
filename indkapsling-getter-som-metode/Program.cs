using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indkapsling_getter_som_metode
{
    class Program
    {
        static void Main(string[] args)
        {

            TreKant t = new TreKant(10, 10);
            Console.WriteLine($"Areal {t.Areal}");


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class TreKant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public TreKant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        public double Areal
        {
            get
            {
                return this.Grundlinje * this.Højde * 0.5;
            }
        }
    }

}
