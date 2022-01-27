# Regnemaskine (func)

I denne opgave skal du tilføje funktioner til en regnemaskine som
jeg har lavet på forhånd. Start med at skabe en tom konsol applikation
og kopier følgende kode 

https://raw.githubusercontent.com/devcronberg/undervisning-cs-opgaver/master/delegates-regnemaskine-func/RegnemaskineConsoleUI.cs

ind i projektet - enten i bunden af Program.cs eller som en fil for 
sig selv. Du behøver ikke forstå koden - du skal bare bruge den.

Prøv i Main at skrive:

```csharp
RegnemaskineApp.RegnemaskineConsoleUI r =
    new RegnemaskineApp.RegnemaskineConsoleUI();
r.Start();
```

ved afvikling skulle programmet gerne vise en simpel brugerflade
relateret til en regnemaskine hvor der kun er en Plus-funktion 
tilgængelig. Prøv at se om du kan lægge to tal sammen og se 
resultatet.

Din opgave er nu at tilføje fire funktioner til min regnemaskine:

- Minus
- Gange
- Divider
- Max

De tre første skal du kode selv og den sidste kommer fra System.Math.

For at tilføje funktioner til regnemaskinen kan du benytte metoden TilføjBeregning, 
der som argument tager en string der beskriver navnet (feks "minus") og en reference
til en delegate af typen ```Func<int, int, int>``` med den konkrete beregning. 

> Bemærk: Det eneste der er rettet i min Regnemaskine i forhold til forrige opgave er at den nu benytter Func<int, int, int> i stedet for en defineret delegate.

![](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-regnemaskine-delegate/Opgave/regnemaskine.png)

Tilføj eventuelt nogle flere funktioner - de skal bare returnere en int og tage to int's
som argument.

Kan du se, at du som bruger af min regnemaskine kan udvide funktionaliteten som du ønsker?

Se eventuelt min [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/delegates-regnemaskine-func/Program.cs).
