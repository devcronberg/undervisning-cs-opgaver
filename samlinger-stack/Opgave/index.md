# Samlinger (stack)

Du skal skabe en tom konsol app med følgende klasse:

```csharp
public class Kort {
    public string Kulør { get; set; }
    public int Værdi { get; set; }
    public override string ToString()
    {
        return this.Kulør + " " + this.Værdi;
    }
}
```

Din opgave er at skabe en klasse Bunke som kan bruges til at gemme kort. Klassen bør opbevare kort i en privat Stack<Kort>. Den skal have metoderne TilføjKort(Kort), FjernKort der returnerer et kort, og en Vis der viser alle kort i bunken. 

Følgende kode kan bruges som test:

```csharp
Bunke b = new Bunke();
b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
b.Vis();

var k = b.FjernKort();
Console.WriteLine();
Console.WriteLine(k);
Console.WriteLine();

b.Vis();
// ---- resultat
Ruder 3
Hjerter 14
Spar 2
Ruder 3
Hjerter 14
Spar 2
```

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/samlinger-stack/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
