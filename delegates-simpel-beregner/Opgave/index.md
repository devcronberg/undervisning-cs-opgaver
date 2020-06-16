# Delegates (beregner)

Du skal skabe en tom konsol app med følgende metoder:

```csharp
public static int Plus(int a, int b)
{
    return a + b;
}
public static int Minus(int a, int b)
{
    return a - b;
}

public static int Divider(int a, int b)
{
    return a / b;
}

public static int Gange(int a, int b)
{
    return a * b;
}
```

Dan en delegate kaldet Beregn, som kan bruges til at kalde en af ovennævnte 
funktioner, og skab en metode Beregner der tager to heltal 
til beregning, samt en instans af en delegate, der henviser 
der den funktion der ønskes benyttes. Kald kan se således ud:

```csharp
int res = Beregner(1, 1, Plus);	// lægger sammen

// eller (forudsat at BeregnDelegate er defineret)
BeregnDelegate d = new BeregnDelegate(Plus);
int res2 = Beregner(1, 1, d);

// eller (forudsat at BeregnDelegate er defineret)
BeregnDelegate d = Plus;
int res3 = Beregner(1, 1, d);
```

Prøv også at skabe en metode FindTilfældigFunktion, der returnerer
en Beregn-delegate med en af de fire metoder (plus, minus, gange eller divider)
afhængig af det konkrete millisekund (under 250=plus, 250-500=minus osv). kald
til funktionen kan se således ud:

```csharp
var f = FindTilfældigFunktion();
int res4 = f(5, 5);
```

Se evt. [min løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-simpel-beregner/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
