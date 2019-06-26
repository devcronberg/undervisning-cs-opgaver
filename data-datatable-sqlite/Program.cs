using System;
using System.Data;
using System.Data.SQLite;

namespace data_datatable_sqlite
{
    class Program
    {
        // https://github.com/devcronberg/undervisning-db-sqlite
        private static string databaseFil = "c:\\temp\\people.db";
        private static string connectionString = "Data Source=" + databaseFil;

        static void Main(string[] args)
        {

            DataTable dt = FindAllePersonerUnder(160);
            foreach (DataRow row in dt.Rows)
                Console.WriteLine(row["firstname"]  + " " + row["firstname"]);

            Console.WriteLine();
            foreach (DataColumn dataColumn in dt.Columns)
                Console.WriteLine(dataColumn.ColumnName + " " + dataColumn.DataType.ToString());

        }

        static DataTable FindAllePersonerUnder(int height) {
            DataTable dt = new DataTable("data");
            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    // PS pas på med at "konstruere" et sql kald - bør benytte parametre (undgå SQL injection attacks)
                    // cm.CommandText = "select * from person where height < " + height;

                    cm.Parameters.Add(new SQLiteParameter("@height", height.ToString()));
                    cm.CommandText = "select * from person where height < @height";
                    cm.CommandType = System.Data.CommandType.Text;
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cm))
                    {
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}

