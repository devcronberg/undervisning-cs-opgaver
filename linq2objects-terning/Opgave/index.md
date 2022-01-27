# LINQ to Objects (Yatzy)

Dette er en større opgave hvis du skal kode den funktionalitet der skal til at finde ud af 
om et bæger med terninger indeholder et par, to par, tre ens og så videre. Se [her](https://da.wikipedia.org/wiki/Yatzy) hvis du
ikke kan huske hvordan man spiller Yazty.

Start med at skabe en tom konsol applikation og tilføj følgende klasser:

```csharp
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
```

Prøv nu at skabe to objekter af Bæger:

```csharp
class Program
{
    static void Main(string[] args)
    {
        Bæger b1 = new Bæger(3, 3, 3, 4, 4);    // Terninger med konkret værdi til test
        Console.WriteLine(b1);
        Console.WriteLine();
        Bæger b2 = new Bæger();                 // Tilfældige terninger
        Console.WriteLine(b2);

    }
}
```

Det vil udskrive følgende: 

```
Bæger med terninger
-------------------
[ 2 ] [ 3 ] [ 3 ] [ 3 ] [ 4 ]

Et par    : True
To par    : True
Tre ens   : True
Lav       : True
Høj       : True
Fuldt hus : True
Yatzy     : True


Bæger med terninger
-------------------
[ 1 ] [ 2 ] [ 2 ] [ 2 ] [ 5 ]

Et par    : True
To par    : True
Tre ens   : True
Lav       : True
Høj       : True
Fuldt hus : True
Yatzy     : True
```

Bemærk at alle metoder (EtPar, ToPar mv) returnerer true. 

Dit job er at tilrette metoderne så de passer, og du kan kode det som du vil. I min løsning bruger jeg meget Linq men det er helt op til dig. Her er et eksempel på brug af "de rigtige" metoder:

```
Bæger med terninger
-------------------
[ 2 ] [ 3 ] [ 3 ] [ 3 ] [ 4 ]

Et par    : True
To par    : False
Tre ens   : True
Lav       : False
Høj       : False
Fuldt hus : False
Yatzy     : False


Bæger med terninger
-------------------
[ 1 ] [ 1 ] [ 3 ] [ 3 ] [ 4 ]

Et par    : True
To par    : True
Tre ens   : False
Lav       : False
Høj       : False
Fuldt hus : False
Yatzy     : False
```

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/linq2objects-terning/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
