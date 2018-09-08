# Events (FileWatcher)

Du skal skabe en konsol app der skal lytte efter rettelser i tekstfiler i c:\temp. Hvis der sker en rettelse skal der udskrives på konsol – ”Filen xxx er rettet”.

Brug FileSystemWatcher (System.IO), og bind en metode til Changed-hændelsen. Brug evt. følgende skabelon kode

```csharp
System.IO.FileSystemWatcher w =
    new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
w.EnableRaisingEvents = true;
// bind en metode til w.Changed
```

Brug et uendeligt loop så applikationen holdes ”åben” og ”lytter”.

Prøv at skabe både en metode og en lambda.

PS - hvis du oplever at Windows smider flere hændelser i træk så er [du ikke den eneste](https://stackoverflow.com/questions/1764809/filesystemwatcher-changed-event-is-raised-twice). Bare ignorer det lige nu ;)