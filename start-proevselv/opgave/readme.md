# Prøv selv Visual Studio 2019

Det er vigtig at du lige får prøvet at oprette en konsol applikation, og leget 
lidt med de forskellige muligheder. Prøv at gøre det samme 
som på [video](http://cdn.cronberg.dk/kurser/cs/0819_VS2019_Console.mp4) 
(sæt den eventuelt løbende på pause medens du selv afprøver de forskellige ting):

- Opret en ny tom C# .NET Core konsol applikation
- Find Solution Explorer-vinduet
  - Højreklik på løsningen og vælg "Open folder in File Explorer"
    - Find .sln-filen (løsning)
    - Find .csproj-filen (projekt)
    - Find program.cs (kodefil)
- Find Error List-vinduet
  - Er der nogen fejl?
  - Fjern semikolon fra `Console.WriteLine("Hello World!");`
  - Er der nogen fejl?
- Slet linjen `Console.WriteLine("Hello World!");`
- Tilføj en kodelinje
  - Skriv "Consol" og bemærk Console på listen
  - Tryk . og skrive Write - bemærk Writeline på listen
  - Vælge WriteLine og tryk Enter
  - Sæt ( - og bemærk at VS vise hvordan metoden kan kaldes
    - brug pilene til at se alle muligheder
  - Sørg for at der står `Console.WriteLine("Tæller til 5");`
- Brug en snippet for at skabe en løkke
  - Skriv `for` (bemærk listen) og tryk to gange tabulering
  - Tryk tabulering frem til `lenght` og skriv 5
  - Tryk enter for at afslutte snippet
  - I tuborgklammerne skriv `cw` og tryk tabulering to gange
    - Sørg for at der står `Console.WriteLine(i);`
- Byg (kompiler) løsning ved at trykke F6 eller Ctrl+Shift+B
  - Er der nogen fejl?
  - Står der "Build succeeded" i venstre nederste hjørne?
  - Højreklik på løsningen og vælg "Open folder en File Explorer"
    - Navigér ned til bin-folderen
    - Navigér ned til netcoreapp2.2-folderen (kan være afhængig af version)
    - Kan du se en dll-fil og andre filer?
      - Det er de filer kompileren har skabt
- Prøv at afvikle applikationen fra VS fra at trykke F5 (med debugger)
  - Dukker der et konsol vindue frem, og bliver der talt til 5?
- Prøv at afvikle applikationen fra VS fra at trykke Ctrl+F5 (uden debugger)
  - Dukker der et konsol vindue frem, og bliver der talt til 5?

### Ekstra (ikke med i video)

Man kan vælge at afvikle en dll-fil direkte fra kommandoprompt.

- Start en kommandoprompt og naviger til mappen hvor projektfilen (.csproj) befinder sig
  - skriv dotnet run
    - det burde kompilere og afvikle applikationen
  - naviger til mappen bin\debug\netcoreapp2.2
    - skriv dotnet [navn på dll](eksempelvis "dotnet demo.dll")
      - det burde afvikle den tidligere kompilere kode (IL)


Husk at se video hvis du er i tvivl!

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
