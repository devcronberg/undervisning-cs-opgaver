# Data (SQLite)

Du skal skabe en konsol app hvor du kan øve dig lidt på brug af DbConnection, DbReader, DbCommand mv.
Applikationen benytter SQLite som database (simpel filbaseret database) så det kræver NuGet-pakken "System.Data.SQLite.Core". Denne pakke
indeholder implementationer af DbConnection, DbReader, DbCommand mv i følgende klasser:

- SQLiteConnection
- SQLiteCommand
- SQLiteDataReader
- SQLiteDataAdapter

De fungerer på samme måde som SqlClient-versionens SqlConnection, SqlCommand mv.

Tilføj denne metode til Program for at skabe en database, og sørg for at kalde 
metoden når app starter. Metoden opretter en simpel database med en tabel kaldet Person med skemaet 
PersonId (int/auto/key), Navn (varchar), Alder (int) og nogle få rækker med data (se metode):

```csharp

private static string databaseFil = "personer.db";
private static string connectionString = "Data Source=" + databaseFil + ";Version=3;";

private static void Setup()
{
    SQLiteConnection.CreateFile(databaseFil);
    using (SQLiteConnection cn = new SQLiteConnection(connectionString))
    {
        cn.Open();
        using (SQLiteCommand cm = new SQLiteCommand(cn))
        {
            cm.CommandText = "create table person (PersonId INTEGER PRIMARY KEY AUTOINCREMENT, Navn VARCHAR(50), Alder INT)";
            cm.CommandType = System.Data.CommandType.Text;
            cm.ExecuteNonQuery();
        }

        using (SQLiteCommand cm = new SQLiteCommand(cn))
        {
            string sql = "insert into person (navn, alder) values('Mikkel',15);";
            sql += "insert into person (navn, alder) values('Mathias',12);";
            sql += "insert into person (navn, alder) values('Lene',53);";
            sql += "insert into person (navn, alder) values('Michell',51);";
            sql += "insert into person (navn, alder) values('Lis',73);";
            sql += "insert into person (navn, alder) values('Bjarne',72);";
            cm.CommandText = sql;
            cm.CommandType = System.Data.CommandType.Text;
            cm.ExecuteNonQuery();
        }

    }
}
```

Din opgave er nu at 

- Skabe en metode der henter og udskriver data sorteret efter alder ved hjælp af SQLiteConnection, SQLiteCommand (select * from person order by alder) og SQLiteDataReader og ExecuteReader.
- Skabe en metode der finder antal personer under 20 år ved hjælp af SQLiteConnection, SQLiteCommand (select count(*) from person where alder<20) og ExecuteScalar.
- Skabe en metode der opdaterer alder til 16 på personen med personid=1 ved hjælp af SQLiteConnection, SQLiteCommand (update person set alder = 16 where personid = 1) og ExecuteNonQuery.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->
