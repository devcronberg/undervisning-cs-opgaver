# Events (Log)

Du skal skabe en tom konsol app med en klasse maskine med følgende medlemmer:

- En egenskab som wrapper en delegate, der kan bruges på void metoder der har en string som argument (void [name](string)). Prøv både med din egen delegate og med en Action<string>
- En start metode der kalder Log med Tid + ” Starter” (eksempelvis ”16:13:25 Starter”)
- En stop metode der kalder Log med Tid + ” Stopper” (eksempelvis ”16:13:25 Stopper”)

I Program-klassen skal du skabe en statisk metode der appender tekst til en tekstfil som følger:

´´´csharp
static void AppendLog(string txt) {
    System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
}
´´´

Dan nu I Main() et objekt af Maskine, bind både Console.WriteLine og AppendLog til delegate’n Log, og kald Start() og Stop().

Der burde nu skrives både til console og til tekstfilen.

Ekstra:

Prøv at slette AppendLog-metoden og tilføj den til Log som en anonym metode i stedet.
