# Hukommelse (struct / class)

Opret en ny konsol app og tilføj følgende kode:

```csharp
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
    }
}

struct Person   
{
    public int Id;
}
```

1) Hvad skriver programmet ud – og hvorfor??
2) Ret struct Person til class Person 
3) Hvad skriver programmet ud – og hvorfor??

-------------

Du skulle gerne komme frem til, at når der er tale om en værdibaseret variabel (struct) kopieres der værdier, og når der er tale om en referencebaseret variabel (class) kopieres der referencer.

Se eventuelt følgende videoer:

- [struct](https://mcronberg.screencasthost.com/watch/cqnhDT35p8)
- [class](https://mcronberg.screencasthost.com/watch/cqnhDg355T)

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Hukommelse-struct-class/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
