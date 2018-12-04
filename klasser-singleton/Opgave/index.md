# Klasser (singleton)

Du skal skabe en tom konsol-applikation med en enkelt klasse kaldet AppSettings. Den skal indeholde et enkelt offentlig felt (ved det godt - duer ikke - men ok lige her) kaldet int AppId. Men der må altid kun eksistere et AppSettings-objekt - så du skal:

* have en privat constructor (der kan ikke skabes en instans)
* have en privat statisk instans af AppSettings
  * som kun kan returneres gennem en HentAppSettings-metode. Denne metode opretter en ny statisk instans hvis den ikke findes i forvejen.

Så den skal kunne bruges som:

```csharp
AppSettings appSettings = AppSettings.HentAppSettings();
appSettings.AppId = 10;
Console.WriteLine(appSettings.AppId);   // 10
appSettings = AppSettings.HentAppSettings();
Console.WriteLine(appSettings.AppId);   // 10
```

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/klasser-singleton/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
