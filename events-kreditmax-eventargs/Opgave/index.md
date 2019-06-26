# Events med egen eventargs (KreditMax)

Du skal skabe en konsol app med en klasse Kunde som følger:

```csharp
public class Kunde
{
    // event mangler
    public string Navn { get; set; }
    public int Saldo { get; set; }
    public int KreditMax { get; set; }
    public void Køb(int værdi) {
        Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
        this.Saldo -= værdi;
        if (Saldo < KreditMax) {
	// kald til event mangler
        }
    }
}
```

I klassen skal der være en hændelse (event) kaldet KreditOverskredet. 
Den skal kaldes såfremt kreditmax overskrides. 
Hændelsen skal være af typen EventHandler\<KreditOverskredetEventArgs\>, der som argument tager en sender (object) og KreditOverskredetEventArgs (din egen type som består af en Saldo). 
Så du skal altså skabe en klasse KreditOverskredetEventArgs med en egenskab kaldet Saldo (int), der arver fra EventArgs.

Følgende kode kan benyttes som test:

```csharp
Kunde k = new Kunde() { KreditMax = -500 };
k.KreditOverskredet += (s, e) => {
    Console.WriteLine($"Kredit overskredet - saldo = {e.Saldo:N2}");
};
k.Køb(100);
k.Køb(600);	// Her skal metoden bundet til KreditOverskredet blive kaldt automatisk
```

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/events-kreditmax-eventargs/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
