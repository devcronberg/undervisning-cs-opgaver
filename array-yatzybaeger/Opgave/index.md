# Bæger med terninger

Opret en ny tom konsol-applikation og definer en terning som følger:

```csharp
public class Terning
{
    // Ved .NET Core behøver den ikke være statisk!!
    private static Random rnd = new Random();
    public int værdi;

    public Terning()
    {
        this.værdi = 1;
    }

    public void Skriv()
    {
        Console.Write("[" + this.værdi + "]");
    }

    public void Ryst()
    {
        this.værdi = rnd.Next(1, 7);
    }
}
```

Din opgave er nu at skabe en klasse Bæger som kan indeholde fem terninger i et private 
array af Terning. Klassen skal indeholde følgende medlemmer:

- en constructor der tilføje fem nye terninger til det interne arrays når der skabes en instans af Bæger
- en Ryst-metode der ryster alle terninger i bæger
- en Skriv der udskriver alle terninger som [x] [x] [x] [x] [x] 

![](baeger.png)

Klassen skal kunne bruges som:

```csharp
Bæger b = new Bæger();
b.Skriv();
b.Ryst();
b.Skriv();
```

hvilket kunne udskrive:

```
[4][5][5][2][1]
[4][3][6][5][5]
```

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/array-yatzybaeger/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
