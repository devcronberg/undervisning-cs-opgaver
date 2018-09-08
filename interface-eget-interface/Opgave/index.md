# Interface (eget interface)

Du skal skabe en tom konsol app med følgende klasser:

```csharp
class Hund  {

    public string Navn { get; set; }

}

class Ubåd  {

    public int Nummer { get; set; }
    public double Tubine { get; set; }
}
```

For at kunne gemme objekter af klasserne på samme konsistente måde, og give mulighed for at 
benytte polymorfi, skal du skabe et interface kaldet IDbFunktioner, der udelukkende består 
af metoden void Gem(). Sørg for at begge klasser implementerer interfacet, og at metoderne 
implementeres ved at der skrives på consol ”Gemmer hund…” og ”Gemmer ubåd…”.

Skab nu i Main() et array af IDbFunktioner (som jo dermed kan pege på både 
en hund og en ubåd), og tilføj et par objekter af både Hund og Ubåd. Løb nu 
arrayet igennem og kald Gem(). Der skulle gerne skrives hhv. ”Gemmer hund…” og 
”Gemmer ubåd…”. Du har altså skabt en samhørighed mellem en hund og ubåd 
ved at begge klasser består af en konkret metode.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->