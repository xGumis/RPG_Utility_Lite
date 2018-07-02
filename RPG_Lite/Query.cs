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
        public static List<Types.AType> Records_Stats()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_stats);
            var list = new List<Types.AType>();
            if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WStat();
                        for(int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == "nazwa") wr.Name = reader.GetString(i);
                        else if (tmp == "opis") wr.Description = reader.GetString(i);
                    }
                        var stat = new Types.Stat(wr);
                        list.Add(stat);
                    }
                }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Skills()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_skills);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WSkill();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == "nazwa") wr.Name = reader.GetString(i);
                        else if (tmp == "opis") wr.Description = reader.GetString(i);
                        else if (tmp == "typ") wr.Type = reader.GetString(i);
                        else if(tmp == "cecha")
                        {
                            var a = new Types.Wrapper.WStat();
                            a.Name = reader.GetString(i);
                            wr.Characteristic = new Types.Stat(a);
                        }
                    }
                    var skill = new Types.Skill(wr);
                    list.Add(skill);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Items()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_items);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WItem();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == "id") wr.Id = reader.GetInt32(i);
                        else if (tmp == "nazwa") wr.Name = reader.GetString(i);
                        else if (tmp == "opis") wr.Description = reader.GetString(i);
                        else if (tmp == "dostepnosc") wr.Availability = reader.GetString(i);
                        else if (tmp == "obciazenie") wr.Weight = reader.GetFloat(i);
                        else if (tmp == "cena") wr.Price = reader.GetString(i);
                    }
                    var item = new Types.Item(wr);
                    list.Add(item);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Weapons()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_weapons);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WWeapon();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == "nazwa") wr.Name = reader.GetString(i);
                        else if (tmp == "cechy") wr.Treats = reader.GetString(i);
                        else if (tmp == "opis") wr.Description = reader.GetString(i);
                        else if (tmp == "dostepnosc") wr.Availability = reader.GetString(i);
                        else if (tmp == "obciazenie") wr.Weight = reader.GetFloat(i);
                        else if (tmp == "cena") wr.Price = reader.GetString(i);
                        else if (tmp == "zasieg") wr.Range = reader.GetFloat(i);
                        else if (tmp == "przeladowanie") wr.Reload = reader.GetInt32(i);
                        else if (tmp == "sila") wr.Damage = reader.GetString(i);
                        else if (tmp == "kategoria") wr.Category = reader.GetString(i);
                    }
                    var weapon = new Types.Weapon(wr);
                    list.Add(weapon);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Armor()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_armor);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WArmor();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == "nazwa") wr.Name = reader.GetString(i);
                        else if (tmp == "opis") wr.Description = reader.GetString(i);
                        else if (tmp == "obciazenie") wr.Weight = reader.GetFloat(i);
                        else if (tmp == "chronione_lokacje") wr.Cover = reader.GetString(i);
                        else if (tmp == "PZ") wr.Points = reader.GetInt32(i);
                    }
                    var armor = new Types.Armor(wr);
                    list.Add(armor);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Talents()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_talents);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WTalent();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);

                    }
                    var stat = new Types.Stat(reader.GetString(0), reader.GetString(1));
                    list.Add(stat);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Stats()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_stats);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var stat = new Types.Stat(reader.GetString(0), reader.GetString(1));
                    list.Add(stat);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Stats()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_stats);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var stat = new Types.Stat(reader.GetString(0), reader.GetString(1));
                    list.Add(stat);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Stats()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_stats);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var stat = new Types.Stat(reader.GetString(0), reader.GetString(1));
                    list.Add(stat);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Stats()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_stats);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var stat = new Types.Stat(reader.GetString(0), reader.GetString(1));
                    list.Add(stat);
                }
            }
            conn.Close();
            return list;
        }

    }
}
