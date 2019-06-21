# Fibonacci (yield)

Skab en tom console-app med to statiske metoder som begge returnerer Fibonacci-numre:

- IEnumerable<<int>> Fibinacci1(int count)
- IEnumerable<<int>> Fibonacci2(int count)

Fibonacci-numre beregnes ved at lægge to to forrige numre sammen i en talrække, og er en af de mest facinerende 
talrækker i matematikken (se [WikiPedia](https://en.wikipedia.org/wiki/Fibonacci_number)). Hvis man antager at det første nummer er 0 og de næste en ser talrækken således ud:

(0) 1 1 2 3 5 8 13 21 34 55

0+1=1, 1+1=2, 1+2=3, 2+3=5 osv

Du skal altså skabe to metoder. Den første metode Fibinacci1 skal blot skabe en liste af Fibonacci-tal og returnere denne som en IEnumerable<int>. Så kan den 
løbes igennem som følger:

```csharp
foreach (var item in Fibonacci1(10))
    Console.WriteLine(item);
```

Den anden metode Fibinacci2 beregner også numrerne men metoden skal ikke første danne listen og returnere denne, men i 
stedet returnere et output løbende (yield return) som kan for-each'es. Men kaldet mod metoden er det samme:

```csharp
foreach (var item in Fibonacci2(10))
    Console.WriteLine(item);
```

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/samlinger-fibonacci/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
