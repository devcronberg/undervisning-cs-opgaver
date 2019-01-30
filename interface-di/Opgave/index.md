# Interface (Dependency Injection)

Du skal skabe en tom konsol app med et interface kaldet ITilfældighedsGenerator. Interface’et beskriver en enkelt metode kaldet FindTalTilTerning, som skal returnere en int.

Skab nu to klasser der implementere interface’et:
* TilfældighedsGeneratorFramework
* TilfældighedsGeneratorMock

Førstnævnte benytter en privat statisk instans af System.Random til at skabe et tilfældigt tal mellem 1 og 6. Sidstnævnte indeholder en custom constructor hvor et tal kan angives, og dette tal returneres blot af FindTalTilTerning-metoden.

Test begge klasser:

```csharp
ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
Console.WriteLine(m.FindTalTilTerning());
ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
Console.WriteLine(f.FindTalTilTerning());
```

Skab nu en klasse Terning med egenskaben Værdi og en Ryst-metode. Ryst-metoden skal bruge et objekt der implementerer ITilfældighedsGenerator til at finde det tilfældige tal, og objektet skal tildeles Terning i en custom constructor.

Test klassen:

```csharp
TilfældighedsGeneratorMock m = new TilfældighedsGeneratorMock(1);
Terning t1 = new Terning(m);
Console.WriteLine(t1.Værdi);

TilfældighedsGeneratorFramework f = new TilfældighedsGeneratorFramework();
Terning t2 = new Terning(f);
Console.WriteLine(t2.Værdi);
```

Du har nu skabt en (fattigmands)implementation af (konstruktor baseret) dependency injection.

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/interface-di/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
