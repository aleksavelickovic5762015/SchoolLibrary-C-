using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_2
{
    static partial class Utils
    {
        public static class DB
        {
            public static readonly string connectionString = @"Data Source=c:\Users\aleks\Documents\Predmeti\PISiBP\Projekat_SkolskaBiblioteka\Biblioteka_2\Biblioteka_2\biblioteka.db; foreign keys=true;"; //biblioteka.db //biblioteka_term

            public static SQLiteConnection connectDB()
            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }

            public static SQLiteCommand BuildSQLiteCommand(SQLiteConnection connection, string query, Dictionary<string, object> parameters = null)
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameters != null)
                    foreach (KeyValuePair<string, object> entry in parameters)
                    {
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                    }

                return command;
            }

            public static DataTable DataTableFromQuery(string query, Dictionary<string, object> parameters = null)
            {
                using (SQLiteConnection conn = connectDB())
                using (SQLiteCommand cmd = BuildSQLiteCommand(conn, query, parameters))
                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    return dt;
                }
            }

            public static void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
            {
                using (SQLiteConnection conn = connectDB())
                using (SQLiteCommand cmd = BuildSQLiteCommand(conn, query, parameters))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            public static string SelectSingleValueFromQuery(string query, Dictionary<string, object> parameters = null)
            {
                using (SQLiteConnection conn = connectDB())
                using (SQLiteCommand cmd = BuildSQLiteCommand(conn, query, parameters))
                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    return (sdr.Read() ? sdr[0].ToString() : null);
                }
            }
        }
    }
}
