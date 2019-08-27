# Egenskaber (klassisk fejl)

Du skal skabe en tom .NET Core konsol app, og erstat koden med følgende:

```csharp
namespace indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "x";
			System.Console.WriteLine(p.Navn);
        }
    }

    class Person
    {
        private string navn;

        public string Navn
        {
            get { return navn; }
            set { Navn = value; }
        }
    }
}
```

Prøv at bygge projektet - der burde ikke være nogle fejl. Prøv at afvikle - der burde så til gengæld komme en (overflow) exception. Din opgave er at finde ud af hvorfor og rette koden så den virker.

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/indkapsling-rekursivfejl/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
