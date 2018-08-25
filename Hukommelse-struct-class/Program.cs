using System;

class Program
{
    static void Main(string[] args)
    {

        Person k1 = new Person();
        k1.navn = "a";
        Person k2 = new Person();
        k2.navn = "b";
        Console.WriteLine(k1.navn);
        Console.WriteLine(k2.navn);
        k1 = k2;
        Console.WriteLine(k1.navn);
        Console.WriteLine(k2.navn);
        k1.navn = "c";
        Console.WriteLine(k1.navn);
        Console.WriteLine(k2.navn);

        // Hold console åben ved debug
        if (System.Diagnostics.Debugger.IsAttached)
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}

struct Person   // ret til class Person jf. opgave
{
    public string navn;
}
