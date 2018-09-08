# Events (KreditMax)

Du skal skabe en konsol app med en klasse Kunde som følger:

´´´csharp
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
´´´

I klassen skal der være en hændelse (event) kaldet KreditOverskredet. Den skal kaldes såfremt kreditmax overskrides. Hændelsen skal blot være af typen EventHandler, der som argument tager en sender (object) og eventargs (System.EventArgs). Se evt. løsning.

Følgende kode kan benyttes som test:

´´´csharp
Kunde k = new Kunde() { KreditMax = -500 };
k.KreditOverskredet += (s, e) => {
    Console.WriteLine("Kredit overskredet");
};
k.Køb(100);
k.Køb(600);	// Her skal metoden bundet til KreditOverskredet blive kaldt automatisk
´´´