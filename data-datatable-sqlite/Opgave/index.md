# Data (SQLite/DataTable)

Du skal skabe en konsol app hvor du kan øve dig lidt på brug af DataTable og DataColumn.

Applikationen benytter SQLite som database (simpel filbaseret database) så det kræver NuGet-pakken "System.Data.SQLite.Core". Denne pakke
indeholder implementationer af DbConnection, DbReader, DbCommand mv i følgende klasser:

- SQLiteConnection
- SQLiteCommand
- SQLiteDataReader
- SQLiteDataAdapter

De fungerer på samme måde som SqlClient-versionens SqlConnection, SqlCommand mv.

Du kan hente en demo sqlite database [ved at klikke her](https://github.com/devcronberg/undervisning-db-sqlite/raw/master/db-download/people.db), og gemme filen i c:\temp. Kig [direkte på repository](https://github.com/devcronberg/undervisning-db-sqlite#sqlite-demo-database) for at få en forklaring på tabeller i databasen, samt connectionstring.

Din opgave er nu at 

- Skabe en metode der returnerer en DataTable med personer under en vis højde
- Løbe resultatet igennem og udskrive FirstName og LastName
- Løbe samtlige datacolumns igennem og udskrive navn på feltet samt datatypen

Se min løsning [her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/data-datatable-sqlite/Program.cs)

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
