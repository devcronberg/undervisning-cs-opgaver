# Generic (Terning)

Du skal skabe en konsol applikation med følgende klasser:

```csharp
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
```

En abstrakt klasse Terning benyttes af YatzyTerning og LudoTerning til at skabe konkrete terninger til de forskellige spil. Prøv begge terninger så du er sikker på hvordan de virker:

```csharp
YatzyTerning y = new YatzyTerning();
Console.WriteLine(y);
LudoTerning l = new LudoTerning();
Console.WriteLine(l);
```

Tilføj nu et simpelt bæger men man løber hurtigt ind i fnidder omkring typekonvertering og sammenblanding med mindre man skaber både et bæger LudoTerninger og et til YatzyTerning:

```csharp
public class Bæger
{
    private List<Terning> lst = new List<Terning>();
    public void Tilføj(Terning d)
    {
        lst.Add(d);
    }
    public List<Terning> Terninger()
    {
        return lst;
    }
}
```

Prøv følgende:

```csharp
Bæger b = new Bæger();
// Man kan tilføje begge typer...
b.Tilføj(new YatzyTerning());
b.Tilføj(new LudoTerning());
// Få fat i en terning kræver typekonvertering
LudoTerning e = b.Terninger()[1] as LudoTerning;
Console.WriteLine(e.ErGlobus());
```

Din opgave er at skabe en ny generisk klasse Bæger så der kun kan arbejdes med enten Yatzy- eller Ludo-terninger – og dermed undgå typekonvertering. Test den med følgende:

```csharp
Bæger<LudoTerning> b = new Bæger<LudoTerning>();
// Man tvinges til at arbejde med Ludo-terninger
b.Tilføj(new LudoTerning());
b.Tilføj(new LudoTerning());
// Ingen typekonverting
LudoTerning e = b.Terninger()[1];
Console.WriteLine(e.ErGlobus());
```


<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->