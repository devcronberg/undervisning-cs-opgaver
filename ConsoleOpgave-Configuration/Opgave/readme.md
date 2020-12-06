# Brug af konfigurationsfiler

I denne opgave skal du arbejde videre på denne opgave

https://github.com/devcronberg/undervisning-cs-opgaver/tree/master/ConsoleOpgave-Parser/Opgave#brug-af-commandlineparser

hvor du skal skabe en applikation som kopierer en fil til en mappe. I den opgave skal både fil og mappe
angives som parametre, men i denne opgave skal brugeren angive den mappe der skal kopieres til i
en konfigurationsfil kaldet appsettings.json:

```json
{
    "Directory": "c:\\temp"
}
```

Du kan starte med at kopiere min (eller din egen) løsning fra ovennævnte opgave ind som skabelon (husk pakken 
CommandLineParser), og så tilrette applikationen således, at ovennævnte appsetting-fil benyttes i stedet til "directory". Denne
parameter skal således fjernes så app kan startes med

```
app.exe -f c:\temp\data.txt
app.exe -f c:\temp\data.txt -r
```

For at arbejde med appsettings skal du tilføje følgende pakker

```
Microsoft.Extensions.Configuration.Json
Microsoft.Extensions.Configuration.Binder
```

og du kan blive lidt inspireret af brug af appsettings i følgende kode:

```csharp
using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConsoleOpgave_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = GetConfiguration();
            Console.WriteLine(configuration.A);
            Console.WriteLine(configuration.B);
            Console.WriteLine(configuration.C);
        }

        static Configuration GetConfiguration() {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var c = new Configuration();            
            configuration.Bind(c);
            return c;
        }
    }

    class Configuration {
        public string A { get; set; }
        public int B { get; set; }
        public bool C { get; set; }
    }
}
```

Idet settings gemmes i appsettings.json (husk at angive "Copy always" i egenskaber til filen):

```json
{
    "A": "abc",
    "B": 1,
    "C": true
}
```

Se min løsning [her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/ConsoleOpgave-Configuration/Program.cs)