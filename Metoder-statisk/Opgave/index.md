# Metoder (statisk)

For at lege lidt med instans- og statiske metoder så prøv at kigge på System.IO.File og System.IO.FileInfo.

* Opret en fil på c:\temp kaldet test.txt og put lidt tekst i
* Dan en ny consol app
* Skriv kode der benytter (hjælpe)metoder fra System.File
  - Prøv Exists (findes filen)
  - Prøv ReadAllText (henter tekst fra filen)
* Skriv kode der opretter et objekt der repræsenterer filen (System.FileInfo) 
  * var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
  * Udskriv LastAccessTime 
  * Udskriv Extension

Bemærk, at de statiske (hjælpe)metoder kan findes på System.IO.File og instans metoderne kræver at du opretter et objekt og kalder metoderne på selve objektet.

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Metoder-statisk/Program.cs).
<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
