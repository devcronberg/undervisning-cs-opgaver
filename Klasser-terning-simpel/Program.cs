using System;

namespace Klasser_terning_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
Terning t1 = new Terning();
Console.WriteLine(t1.Værdi);    // 1
t1.Ryst();
Console.WriteLine(t1.Værdi);    // tilfældig værdi

Terning t2 = new Terning(2);
Console.WriteLine(t2.Værdi);    // 2
t2.Ryst();
Console.WriteLine(t2.Værdi);    // tilfældig værdi

Terning t3 = new Terning(8);    // Fejl: Forkert værdi

        }
    }
}
