# Arv (Exception)

Du skal skabe en tom konsol app med en klasse StockItem. 
Klassen har en ID (int) egenskab, som tildeles en værdi i en
custom constructor. Hvis Id er < 0 skal der smides en Exception 
af en type du selv skal oprette kaldet StockItemException ved at 
arve fra Exception. Det skal være muligt at bruge en custom 
constroctor der tager en string (skal blot sendes videre til 'mor').

Meddelelsen skal være ”Wrong id”.

Prøv herefter koden som følger:

```csharp
try
{
    StockItem s = new StockItem(-1);

}
catch (StockItemException ex)
{
    Console.WriteLine("StockItem Error : " + ex.Message);
}
catch (Exception)
{
    Console.WriteLine("General Error");                    
}
```

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->