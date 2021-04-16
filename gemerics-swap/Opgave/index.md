# Generic (Swap)

Du skal skabe en tom konsol app med følgende metode:

```csharp
public static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}
```
Prøv nu at kalde metoden hvor du bytter rundt på to heltal samt to strenge. Prøv at kalde metoden både med og uden angivelsen af typen.

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/gemerics-swap/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
