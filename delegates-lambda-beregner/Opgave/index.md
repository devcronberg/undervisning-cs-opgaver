# Delegates (beregner med lambda)

Du skal skabe en tom konsol med en Beregner-metode der tager to heltal til beregning samt 
en Func (retunerer en int og modtager to int's), der henviser der den funktion der ønskes benyttes. 

Kald kan se således ud:

```csharp
int res = 0;
res = Beregner(1, 1, (a, b)=> a + b);
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

Slutteligt kan du eventuelt overveje at skabe en FindTilfældigFunktion2, der som argument
tager en liste/array (måske params?) af Func-delegates, og returnerer en tilfældig af dem ud fra 
et tilfældigt tal skabt af System.Random. 

```csharp
var f = FindTilfældigFunktion2((a, b) => a + b, (a, b) => a - b, (a, b) => a * b, (a, b) => a / b);
res = f(5, 5);
Console.WriteLine(res);
```

> Bemærk - der er en del gentagelser af lamdba'er og det bør naturligvis undgås. Du kan eventuelt
> overveje at skabe metoderne og gemme referencerne i statiske delegate-variabler. 

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-lambda-beregner/Program.cs)

## Ekstra tilføjelse - avanceret brug af lambda-expressions (bare for sjov!!)

Blot til orientering har jeg medtaget en klasse Tilføjelse som indeholder metoden Ekstra. Metoden danner kompilerede lambda udtryk fra en 
(emuleret) tekstfil. Det betyder, at brugeren selv kan tilføje (eller ændre - puha!!) de funktioner der ønskes i regnemaskinen.

Du kan finde [koden her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-lambda-beregner/Tilf%C3%B8jelse.cs), og hvis du selv har lyst til at prøve skal du tilføje NuGet-pakken 

```
Microsoft.CodeAnalysis.CSharp.Scripting
```

som i den grad gør det hårde arbejde ;)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
