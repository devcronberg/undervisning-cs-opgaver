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

        private static string databaseFil = "c:\\temp\\people.db";
        private static string connectionString = "Data Source=" + databaseFil;

        static void Main(string[] args)
        {
            

            VisData_DataReader();
            Console.WriteLine();
            Console.WriteLine(FindAntalUnder160());
            Console.WriteLine();
            OpdaterPerson();
            Console.WriteLine();
            
        }

        private static void OpdaterPerson()
        {

            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    cm.CommandText = "update person set height = 160 where personid = 1";
                    cm.CommandType = System.Data.CommandType.Text;
                    int antal = cm.ExecuteNonQuery();
                    Console.WriteLine("Person opdateret - " + antal + " poster påvirket");
                }
            }
        }

        private static int FindAntalUnder160()
        {

            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    cm.CommandText = "select count(*) from person where height<160";
                    cm.CommandType = System.Data.CommandType.Text;
                    object resultat = cm.ExecuteScalar();
                    return Convert.ToInt32(resultat);
                }
            }
        }

        private static void VisData_DataReader()
        {

            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    cm.CommandText = "select * from person order by height";
                    cm.CommandType = System.Data.CommandType.Text;
                    using (SQLiteDataReader r = cm.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Console.WriteLine($"{r["personid"]} {r["lastname"]} ({r["height"]})");
                        }
                    }
                }
            }
        }
    }
}
