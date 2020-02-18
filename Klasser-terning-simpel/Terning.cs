using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser_terning_simpel
{
    class Terning
    {
        public int Værdi;

        public Terning()
        {
            this.Værdi = 1;
        }

        public Terning(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                throw new ApplicationException("Forkert værdi");
            this.Værdi = værdi;
        }

        public void Ryst() {
            System.Random rnd = new Random();
            this.Værdi = rnd.Next(1, 7);
        }
    }
}
