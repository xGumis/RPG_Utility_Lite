using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RPG_Lite
{
    static class Query
    {
        private static string username = "test";
        private static string password = "123qweASD";
        private static string server = "rpglite.database.windows.net";
        private static string catalog = "RPG Utility Lite";
        private static string role;
        private static SqlConnection conn;
        private static string Build_Connection_String()
        {
            SqlConnectionStringBuilder connstr = new SqlConnectionStringBuilder();
            connstr.DataSource = server;
            connstr.InitialCatalog = catalog;
            connstr.UserID = username;
            connstr.Password = password;
            return connstr.ToString();
        }
        private static void Build_Connection()
        {
            conn = new SqlConnection(Build_Connection_String());
        }
        private static SqlDataReader Call_Command(string command)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand com = new SqlCommand(command);
                com.Connection = conn;
                conn.Open();
                reader = com.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
        }
        public static void Change_Login(string user, string pass)
        {
            username = user;
            password = pass;
        }
        public static void Initiate()
        {
            Build_Connection();
            SqlDataReader reader = Call_Command(Commands.show_role);
            if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        role = reader.GetString(0);
                    }
                }
            conn.Close();
        }
        public static string Show_Role() { return role; }
        public static string[][] Fetch_Stats()
        {
            SqlDataReader reader = Call_Command(Commands.show_all_stats);
            List<string[]> tmp = new List<string[]>();
            if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var str = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                            str[i] = reader.GetString(i);
                        tmp.Add(str);
                    }
                }
            conn.Close();
            return tmp.ToArray();
        }

    }
}
