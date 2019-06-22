# Brug af [CallerMemberName]

Start en ny tom konsol applikation

- Tilføj en klasse Person med egenskaberne Alder og Navn
- Implementer INotifyPropertyChanged således, at der implementeres en PropertyChangedEventHandler
- Sørg for, at delegate(s) bundet til PropertyChangedEventHandler afvikles når en egenskab rettes
	- Brug [CallerMemberName] for at få navnet på egenskaben
- Overvej om man burde lukke for brugen af objekt initializer ved at fjerne default constructor, og have custom constrctors der modtager en delegate i stedet

Du kan teste med 

```csharp
PropertyChangedEventHandler c = (s,e) => Console.WriteLine($"{e.PropertyName} ændret");

// Bemærk... ingen hændelser ved init
Person p1 = new Person() { Alder = 12, Navn = "z" };
p1.PropertyChanged += c;

// måske bedre at fjerne default constructor?
Person p2 = new Person("a", 10, c);
p2.Navn = "a";
```

Resultat:

```
Navn ændret
Alder ændret
Navn ændret
```

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/metoder-inotifypropertychanged/Program.cs).

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
