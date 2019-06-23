# Data (SQLite)

Du skal skabe en konsol app hvor du kan øve dig lidt på brug af DbConnection, DbReader, DbCommand mv.
Applikationen benytter SQLite som database (simpel filbaseret database) så det kræver NuGet-pakken "System.Data.SQLite.Core". Denne pakke
indeholder implementationer af DbConnection, DbReader, DbCommand mv i følgende klasser:

- SQLiteConnection
- SQLiteCommand
- SQLiteDataReader
- SQLiteDataAdapter

De fungerer på samme måde som SqlClient-versionens SqlConnection, SqlCommand mv.

Du kan hente en demo sqlite database [ved at klikke her](https://github.com/devcronberg/undervisning-db-sqlite/raw/master/db-download/people.db), og gemme filen i c:\temp. Kig [direkte på repository](https://github.com/mcronberg/undervisning-db-sqlite#sqlite-demo-database) for at få en forklaring på tabeller i databasen, samt connectionstring.

Din opgave er nu at 

- Skabe en metode der henter og udskriver data sorteret efter alder ved hjælp af SQLiteConnection, SQLiteCommand (select * from person order by alder) og SQLiteDataReader og ExecuteReader.
- Skabe en metode der finder antal personer under 20 år ved hjælp af SQLiteConnection, SQLiteCommand (select count(*) from person where alder<20) og ExecuteScalar.
- Skabe en metode der opdaterer alder til 16 på personen med personid=1 ved hjælp af SQLiteConnection, SQLiteCommand (update person set alder = 16 where personid = 1) og ExecuteNonQuery.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
