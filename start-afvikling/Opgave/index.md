# Afvikling af en konsol applikation

Denne opgave har blot til formål at sikre, at du ved hvordan du kan afvikle en konsol-applikation:

- Skab en tom .NET Core "Console Application" 
- Erstat al kode i program.cs med [denne kode](https://raw.githubusercontent.com/devcronberg/undervisning-cs-opgaver/master/start-afvikling/Program.cs)

Prøv nu at 

- fjern semikolon på linje 9
- kompilere koden (F6 eller ctrl+shift+b)
	- er der nogle fejl? 
		- se nederst til venstre i VS - står der "Build succeeded"?
		- Find Error list-vinduet - er der nogle fejl?
	- ret fejlen (tilføj et semikolen på linje 9)
		- kompiler igen (nogen fejl nu?)
- afvikle koden i Visual Studio
	- tryk F5 (med debugger) - se Debug-menuen
	- tryk ctrl+F5 (uden debugger) - se Debug-menuen
		- Du kan umiddelbart ikke se forskel på afvikling med og uden debugger 
- start en kommandoprompt og naviger til mappen hvor projektfilen (.csproj) befinder sig
	- skriv dotnet run
		- det burde kompilere og afvikle applikationen
- naviger til mappen bin\debug\netcoreapp2.2
	- skriv dotnet [navn på dll] (eksempelvis "dotnet demo.dll")
		- det burde afvikle den tidligere kompilere kode (IL)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
