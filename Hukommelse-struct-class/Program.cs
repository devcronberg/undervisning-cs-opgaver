using System;

class Program
{
    static void Main(string[] args)
    {

        Person k1 = new Person();
        k1.Id = 1;
        Person k2 = new Person();
        k2.Id = 2;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
        k1 = k2;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
        k1.Id = 3;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);

        // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
        if (System.Diagnostics.Debugger.IsAttached)
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}

struct Person   // ret til class Person jf. opgave
{
    public int Id;
}
