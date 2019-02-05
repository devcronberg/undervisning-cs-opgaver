# Hukommelse (struct / class)

Opret en ny konsol app og tilføj en struct kaldet Person med et offentligt string felt kaldet navn:

```csharp
struct Person
{
    public int Id;
}
```

Tilføj kode til main:

1) 
- Opret en ny person med Person k1 = new Person(); (så felter sættes til default værdi – best pratice)
- Opret en ny person med Person k2 = new Person();
- Sæt k1.Id = 1
- Sæt k2.Id = 2
- Udskriv k1.Id og k2.Id

2) 
- Sæt k1 = k2;
- Udskriv k1.Id og k2.Id

3)
- Sæt k1.Id = 3
- Udskriv k1.Id og k2.Id

Hvad skriver den ud – og hvorfor??

Prøv nu at 

- Rette struct Person til class Person

Hvad skriver den ud – og hvorfor??

-------------

Du skulle gerne komme frem til, at når der er tale om en værdibaseret variabel (struct) kopieres der værdier, og når der er tale om en referencebaseret variabel kopieres der referencer.

Se eventuelt følgende videoer:

- ![struct](https://mcronberg.screencasthost.com/watch/cqnhDT35p8)
- ![class](https://mcronberg.screencasthost.com/watch/cqnhDg355T)

Se evt [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Hukommelse-struct-class/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
