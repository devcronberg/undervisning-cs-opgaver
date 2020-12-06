# Brug af CommandLineParser

I denne opgave skal du skabe en console app der har til formål at kopiere en fil til en mappe og eventuelt
slette filen bagefter. Du bør checke om fil og mappe eksisterer inden kopiering, og i øvrigt foretage 
almindelig fejlhåndtering.

Brugeren skal kunne starte applikationen eksempelvis således:

```
app.exe -f c:\tmp\data.txt -d c:\temp

eller

app.exe -f c:\tmp\data.txt -d c:\temp -r
```

Argumenterne f (fil) og d (mappe) er nødvendige (required) og hvis r er angivet skal filen slettes når den er kopieret.

Brug pakken CommandLineParser til at styre angivne argumenter. Du kan se eksempler i [dokumentationen](https://github.com/commandlineparser/commandline) eller benytte denne
simple skabelon:

```csharp
using System;
using System.Collections.Generic;
using CommandLine;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Run)
                .WithNotParsed(HandleParseError);
        }

        private static void Run(Options opts)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(opts);
            Console.WriteLine("Start with: " + json);
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            if (errs.IsVersion())
            {
                Console.WriteLine("More info about version");
                return;
            }

            if (errs.IsHelp())
            {
                Console.WriteLine("More info about help");
                return;
            }
            
            // More code related to error handling
        }
    }

    class Options
    {

        [Option('a', "text for a", Required = false, HelpText = "Help text for a")]
        public bool A { get; set; }

        [Option('b', "text for b", Required = true, HelpText = "Help text for b")]
        public string B { get; set; }

        [Option('c', "text for c", Required = false, HelpText = "Help text for c")]
        public int C { get; set; }


    }
}
```

Du kan bruge følgende metoder til kontrol/kopiering:

```csharp
System.IO.File.Exists()
System.IO.Directory.Exists()
System.IO.File.Delete()
System.IO.File.Copy()
System.IO.Path.Combine()
System.IO.Path.GetFileName()
```

Se i øvrigt også [denne lidt udvidede opgave](https://github.com/devcronberg/undervisning-cs-opgaver/tree/master/ConsoleOpgave-Configuration/Opgave).


Se min løsning [her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/ConsoleOpgave-Parser/Program.cs)
