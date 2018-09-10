using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_sqlite
{
    class Program
    {

        private static string databaseFil = "personer.db";
        private static string connectionString = "Data Source=" + databaseFil + ";Version=3;";

        static void Main(string[] args)
        {
            // Sørg for at køre denne mindst en gang
            // Den opretter en simpel database med en tabel kaldet Person
            // med skemaet PersonId (int/auto/key), Navn (varchar), Alder (int)
            // og nogle få rækker
            Setup();
            VisData_DataReader();
            Console.WriteLine();
            VisData_DataTable();

        }

        private static void VisData_DataReader()
        {

            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    cm.CommandText = "select * from person order by alder";
                    cm.CommandType = System.Data.CommandType.Text;
                    using (SQLiteDataReader r = cm.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Console.WriteLine($"{r["personid"]} {r["navn"]} ({r["alder"]})");
                        }
                    }
                }
            }
        }

        private static void VisData_DataTable()
        {
            DataTable dt = new DataTable("data");
            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("select * from person order by alder", cn))
                {
                    da.Fill(dt);
                }
            }

            foreach (System.Data.DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r["personid"]} {r["navn"]} ({r["alder"]})");
            }
        }

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
    }
}
