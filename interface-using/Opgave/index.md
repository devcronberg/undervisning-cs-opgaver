# Interface (using)

Du skal skabe en tom konsol app der har til formål at hente alle navne fra dyrenavne.txt (opret fil og kopier indhold fra løsning), og udskrive disse til consol. I C# kan det gøres som følger:

```csharp
StreamReader stream = System.IO.File.OpenText(@"c:\temp\dyrenavne.txt");
while (stream.Peek() != -1)
{
    string navn = stream.ReadLine();
    Console.WriteLine(navn);
}
stream.Close();
stream = null;
```

Se om du kan få det til at virke først.

Sørg herefter for at bruge en using i stedet så man overlader oprydning til objektet selv.

Filen dyrenavne.txt består blot navne som følger:

Fido
Bulder
Max
Osv.

Find et udkast til filen [her](https://raw.githubusercontent.com/devcronberg/undervisning-cs-opgaver/master/interface-using/dyrenavne.txt) (højreklik og "Gem som"), og løsningen [her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/interface-using/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
