# Delegates (beregner med lambda)

Du skal skabe en tom konsol med en Beregner-metode der tager to heltal til beregning samt 
en Func (retunerer en int og modtager to int's), der henviser der den funktion der ønskes benyttes. 

Kald kan se således ud:

```csharp
int res = 0;
res = Beregner(1, 1, (a,b)=> a + b);
Console.WriteLine(res);
```

Prøv at kalde Beregner-funktionen så den både trækker fra, ganger og dividerer.

Prøv også at skabe en metode FindTilfældigFunktion, der returnerer
en Func (delegate) med en af de fire metoder (plus, minus, gange eller divider)
afhængig af det konkrete millisekund (under 250=plus, 250-500=minus osv). kald
til funktionen kan se således ud:

```csharp
var f = FindTilfældigFunktion();
res = f(5, 5);
Console.WriteLine(res);
```

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-lambda-beregner/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
