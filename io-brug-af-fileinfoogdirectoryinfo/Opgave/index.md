# IO (FileInfo/DirectoryInfo)

Du skal skabe en konsol app hvor du skal benytte System.IO.FileInfo og System.IO.DirectoryInfo til at:

- Udskrive en boolsk værdi svarende til om mappen c:\temp eksisterer (hvis den ikke findes så opret den og placer et par filer i)
- Udskrive navnet på samtlige filer i mappen
- Udskrive en boolsk værdi svarende til om mappen c:\temp\data.txt eksisterer 
- Oprette filen c:\temp\data.txt med indholdet "xxx" (brug CreateText/StreamWriter)
- Tilføje "yyy" til filen (brug AppendText/StreamWriter)
- Hent indhold til en string variabel og skriv den ud (brug OpenText/StreamWriter)
- Slet filen

Husk fejlhåndtering - og gerne således at fejl fra IO fanges og behandles separat (System.IO.IOException).

Se [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/io-brug-af-fileinfoogdirectoryinfo/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
