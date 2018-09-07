# Delegates (beregner med func)

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
Skab en metode Beregner der tager to heltal til beregning samt 
en Func, der henviser der den funktion der ønskes benyttes. 
Kald kan se således ud:

```csharp
int res = 0;
res = Beregner(1, 1, Plus);
Console.WriteLine(res);
res = Beregner(1, 1, Minus);
Console.WriteLine(res);
```

Prøv også at skabe en metode FindTilfældigFunktion, der returnerer
en Func (delegate) med en af de fire metoder (plus, minus, gange eller divider)
afhængig af det konkrete millisekund (under 250=plus, 250-500=minus osv). kald
til funktionen kan se således ud:

```csharp
var f = FindTilfældigFunktion();
res = f(5, 5);
Console.WriteLine(res);
```

Kan du godt se, at opgaven er præcis den samme som delegates-simpel-beregner? Den 
opgave benytter din egen definition af en delegate - denne benytter blot den indbyggede
Func<int, int, int>.