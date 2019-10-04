# LINQ to XML

Du skal skabe en konsol app og i denne tilføje en xml-fil kaldet personer.xml med følgende indhold:

```
<?xml version="1.0" encoding="utf-8" ?>
<personer>
  <person id="1">
    <navn>Mikkel</navn>
    <alder>15</alder>
  </person>
  <person id="2">
    <navn>Mathias</navn>
    <alder>12</alder>
  </person>
  <person id="3">
    <navn>Lene</navn>
    <alder>53</alder>
  </person>
  <person id="4">
    <navn>Michell</navn>
    <alder>51</alder>
  </person>
  <person id="5">
    <navn>Lis</navn>
    <alder>73</alder>
  </person>
  <person id="6">
    <navn>Bjarne</navn>
    <alder>75</alder>
  </person>
  <person id="7">
    <navn>Lise</navn>
    <alder>41</alder>
  </person>
  <person id="8">
    <navn>Peter</navn>
  </person>
</personer>
```

Sørg for, at filen er market som "Copy always" i "Copy to output directory" i egenskaberne til filen (Properties-vinduet).

Du skal nu loade filen i et XDocument-objekt og skabe følgende metoder:

- void VisAllePersoner(XDocument d)
  - Viser alle navne på personer på konsolen
- void VisAllePersonerSorteret(XDocument d, string sorterEfter)
  - Viser alle navne på personer sorteret efter navn eller alder angivet som argument (se bort fra fejlhåndtering)
- string FindNavn(XDocument d, int id)
  - Finder et givet navn efter et id. Hvis intet findes skal der returneres "?"

Se evt. [løsning](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/linq2xml-simpel/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
