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
