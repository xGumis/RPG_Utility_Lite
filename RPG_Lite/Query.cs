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
        private static bool isAdmin;
        private static bool log;
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
        private static SqlDataReader Call_Command(SqlCommand command)
        {
            try
            {
                SqlDataReader reader;
                command.Connection = conn;
                conn.Open();
                reader = command.ExecuteReader();
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
            if(user == null && pass == null)
            {
                username = "test";
                password = "123qweASD";
            }
            else if (!(user == null || pass == null))
            {
                username = user;
                password = pass;
            }
        }
        public static void Initiate()
        {
            Build_Connection();
            var cmd = new SqlCommand(Commands.show_role);
            SqlDataReader reader = Call_Command(cmd);
            if (reader != null)
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        isAdmin = reader.GetBoolean(0);
                    }
                }
                log = true;
            }
            else log = false;
            conn.Close();
        }
        public static bool is_Admin() { return isAdmin; }
        public static bool is_Logged() { return log; }
        public static Dictionary<string, Types.AType> Records_Stats()
        {
            var cmd = new SqlCommand(Commands.RECORDS_stats);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WStat();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                    }
                    var stat = new Types.Stat(wr);
                    list.Add(stat.Key, stat);
                }
            }
            conn.Close();
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Skills()
        {
            var cmd = new SqlCommand(Commands.RECORDS_skills);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WSkill();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Skill_Type) wr.Type = reader.GetString(i);
                        else if (tmp == Columns.Skill_Stat)
                        {
                            var a = new Types.Wrapper.WStat();
                            a.Name = reader.GetString(i);
                            wr.Characteristic = new Types.Stat(a);
                        }
                    }
                    var skill = new Types.Skill(wr);
                    list.Add(skill.Key, skill);
                }
            }
            conn.Close();
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Items()
        {
            var cmd = new SqlCommand(Commands.RECORDS_items);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WItem();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Id) wr.Id = reader.GetInt32(i);
                        else if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Availability) wr.Availability = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Price) wr.Price = reader.GetString(i);
                    }
                    var item = new Types.Item(wr);
                    list.Add(item.Key.ToString(), item);
                }
            }
            conn.Close();
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Weapons()
        {
            var cmd = new SqlCommand(Commands.RECORDS_weapons);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WWeapon();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Weapon_Treats) wr.Treats = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Availability) wr.Availability = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Price) wr.Price = reader.GetString(i);
                        else if (tmp == Columns.Weapon_Range) wr.Range = reader.GetFloat(i);
                        else if (tmp == Columns.Weapon_Reload) wr.Reload = reader.GetInt32(i);
                        else if (tmp == Columns.Weapon_Dmg) wr.Damage = reader.GetString(i);
                        else if (tmp == Columns.Weapon_Category) wr.Category = reader.GetString(i);
                    }
                    var weapon = new Types.Weapon(wr);
                    list.Add(weapon.Key, weapon);
                }
            }
            conn.Close();
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Armor()
        {
            var cmd = new SqlCommand(Commands.RECORDS_armor);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WArmor();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Availability) wr.Availability = reader.GetString(i);
                        else if (tmp == Columns.Armor_Cover) wr.Cover = reader.GetString(i);
                        else if (tmp == Columns.Armor_Points) wr.Points = reader.GetInt32(i);
                    }
                    var armor = new Types.Armor(wr);
                    list.Add(armor.Key, armor);
                }
            }
            conn.Close();
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Talents()
        {
            var cmd = new SqlCommand(Commands.RECORDS_talents);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            var pre_list = new List<Types.Wrapper.WTalent>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WTalent();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                    }
                    pre_list.Add(wr);
                }
            }
            conn.Close();
            foreach (Types.Wrapper.WTalent talent in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_talent_stat);
                cmd.Parameters.AddWithValue("@talent", talent.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WStat();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_stat) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Value) wr.Advance = reader.GetInt32(i);
                        }
                        talent.Bonus = new Types.Stat(wr);
                    }
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WTalent talent in pre_list)
            {
                var a = new Types.Talent(talent);
                list.Add(a.Key, a);
            }
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Spells()
        {
            var cmd = new SqlCommand(Commands.RECORDS_spells);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            var pre_list = new List<Types.Wrapper.WSpell>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WSpell();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Spell_MType) wr.MagicType = reader.GetString(i);
                        else if (tmp == Columns.Spell_Lvl) wr.RequiredLevel = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_Cast) wr.CastTime = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_Durat) wr.Duration = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_ReqTal)
                        {
                            var a = new Types.Wrapper.WTalent();
                            a.Name = reader.GetString(i);
                            wr.RequiredTalent = new Types.Talent(a);
                        }
                    }
                    pre_list.Add(wr);
                }
            }
            conn.Close();
            foreach (Types.Wrapper.WSpell spell in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_spell_item);
                cmd.Parameters.AddWithValue("@spell", spell.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WItem();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Spell_Bonus) wr.Bonus = reader.GetInt32(i);
                        }
                        spell.SupportingItem = new Types.Item(wr);
                    }
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WSpell spell in pre_list)
            {
                var a = new Types.Spell(spell);
                list.Add(a.Key, a);
            }
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Gods()
        {
            var cmd = new SqlCommand(Commands.RECORDS_gods);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            var pre_list = new List<Types.Wrapper.WGod>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WGod();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.God_Symbol)
                        {
                            byte[] imagebyte = reader.GetSqlBytes(i).Value;
                            var ms = new System.IO.MemoryStream();
                            ms.Write(imagebyte, 0, imagebyte.Length);
                            wr.Symbol = new System.Drawing.Bitmap(ms);
                        }
                    }
                    pre_list.Add(wr);
                }
            }
            conn.Close();
            foreach (Types.Wrapper.WGod god in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_god_talent);
                cmd.Parameters.AddWithValue("@god", god.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var tal_list = new List<Types.Talent>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WTalent();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Talent) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        tal_list.Add(new Types.Talent(wr));
                    }
                    god.Talents = tal_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WGod god in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_god_skill);
                cmd.Parameters.AddWithValue("@god", god.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var skill_list = new List<Types.Skill>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSkill();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Skill) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        skill_list.Add(new Types.Skill(wr));
                    }
                    god.Skills = skill_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WGod god in pre_list)
            {
                var a = new Types.God(god);
                list.Add(a.Key, a);
            }
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Races()
        {
            var cmd = new SqlCommand(Commands.RECORDS_races);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            var pre_list = new List<Types.Wrapper.WRace>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WRace();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Race_History) wr.History = reader.GetString(i);
                        else if (tmp == Columns.Race_Tips) wr.Tips = reader.GetString(i);
                    }
                    pre_list.Add(wr);
                }
            }
            conn.Close();
            foreach (Types.Wrapper.WRace race in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_race_talent);
                cmd.Parameters.AddWithValue("@race", race.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var tal_list = new List<Types.Talent>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WTalent();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Talent) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        tal_list.Add(new Types.Talent(wr));
                    }
                    race.StartingTalents = tal_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WRace race in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_race_skill);
                cmd.Parameters.AddWithValue("@race", race.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var skill_list = new List<Types.Skill>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSkill();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Skill) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        skill_list.Add(new Types.Skill(wr));
                    }
                    race.StartingSkills = skill_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WRace race in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_race_stat);
                cmd.Parameters.AddWithValue("@race", race.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var stat_list = new List<Types.Stat>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WStat();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_stat) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Value) wr.Starting = reader.GetInt32(i);
                        }
                        stat_list.Add(new Types.Stat(wr));
                    }
                    race.StartingStats = stat_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WRace race in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_race_career);
                cmd.Parameters.AddWithValue("@race", race.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var car_list = new List<Types.Career>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WCareer();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Career) wr.Name = reader.GetString(i);
                        }
                        car_list.Add(new Types.Career(wr));
                    }
                    race.PossibleCareer = car_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WRace race in pre_list)
            {
                var a = new Types.Race(race);
                list.Add(a.Key, a);
            }
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Careers()
        {
            var cmd = new SqlCommand(Commands.RECORDS_careers);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            var pre_list = new List<Types.Wrapper.WCareer>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WCareer();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Career_Type) wr.Type = reader.GetString(i);
                    }
                    pre_list.Add(wr);
                }
            }
            conn.Close();
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_career_talent);
                cmd.Parameters.AddWithValue("@career", career.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var tal_list = new List<Types.Talent>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WTalent();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Talent) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        tal_list.Add(new Types.Talent(wr));
                    }
                    career.AvailableTalents = tal_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_career_skill);
                cmd.Parameters.AddWithValue("@career", career.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var skill_list = new List<Types.Skill>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSkill();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Skill) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        skill_list.Add(new Types.Skill(wr));
                    }
                    career.AvailableSkills = skill_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_career_stat);
                cmd.Parameters.AddWithValue("@career", career.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var stat_list = new List<Types.Stat>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WStat();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_stat) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Value) wr.Starting = reader.GetInt32(i);
                        }
                        stat_list.Add(new Types.Stat(wr));
                    }
                    career.StatsScheme = stat_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_career_career);
                cmd.Parameters.AddWithValue("@career", career.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var car_list = new List<Types.Career>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WCareer();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_AvailCareer) wr.Name = reader.GetString(i);
                        }
                        car_list.Add(new Types.Career(wr));
                    }
                    career.AvailableCareer = car_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_carrer_weapon);
                cmd.Parameters.AddWithValue("@career", career.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var weapon_list = new List<Types.Weapon>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WWeapon();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Weapon) wr.Name = reader.GetString(i);
                        }
                        weapon_list.Add(new Types.Weapon(wr));
                    }
                    career.StartWeapons = weapon_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_career_armor);
                cmd.Parameters.AddWithValue("@career", career.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var armor_list = new List<Types.Armor>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WArmor();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Armor) wr.Name = reader.GetString(i);
                        }
                        armor_list.Add(new Types.Armor(wr));
                    }
                    career.StartArmor = armor_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_career_item);
                cmd.Parameters.AddWithValue("@career", career.Name);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var item_list = new List<Types.Item>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WItem();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        }
                        item_list.Add(new Types.Item(wr));
                    }
                    career.StartEquipment = item_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                var a = new Types.Career(career);
                list.Add(a.Key, a);
            }
            return list;
        }
        public static Dictionary<string, Types.AType> Records_Characters(bool admin)
        {
            SqlCommand cmd;
            if (admin)
                cmd = new SqlCommand(Commands.RECORDS_characters);
            else
                cmd = new SqlCommand(Commands.USER_Get_characters);
            SqlDataReader reader = Call_Command(cmd);
            var list = new Dictionary<string, Types.AType>();
            var pre_list = new List<Types.Wrapper.WCharacter>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WCharacter();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Char_God)
                        {
                            var a = new Types.Wrapper.WGod();
                            a.Name = reader.GetString(i);
                            wr.WorshipedGod = new Types.God(a);
                        }
                        else if (tmp == Columns.Con_Race)
                        {
                            var a = new Types.Wrapper.WRace();
                            a.Name = reader.GetString(i);
                            wr.Race = new Types.Race(a);
                        }
                        else if (tmp == Columns.Con_Career)
                        {

                            var a = new Types.Wrapper.WCareer();
                            a.Name = reader.GetString(i);
                            wr.CurrentCareer = new Types.Career(a);
                        }
                        else if (tmp == Columns.Char_AddInfo) wr.AdditionalInfo = reader.GetString(i);
                        else if (tmp == Columns.Char_Gender) wr.Gender = reader.GetString(i);
                        else if (tmp == Columns.Char_EyeColor) wr.EyeColor = reader.GetString(i);
                        else if (tmp == Columns.Char_HairColor) wr.HairColor = reader.GetString(i);
                        else if (tmp == Columns.Char_StarSign) wr.StarSign = reader.GetString(i);
                        else if (tmp == Columns.Char_Features) wr.SpecialFeatures = reader.GetString(i);
                        else if (tmp == Columns.Char_BirthPlace) wr.BirthPlace = reader.GetString(i);
                        else if (tmp == Columns.Char_Family) wr.Family = reader.GetString(i);
                        else if (tmp == Columns.Char_MentalCondition) wr.MentalCondition = reader.GetString(i);
                        else if (tmp == Columns.Char_Scars) wr.CutsBruises = reader.GetString(i);
                        else if (tmp == Columns.Char_History) wr.History = reader.GetString(i);
                        else if (tmp == Columns.Char_EXP) wr.Exp = reader.GetInt32(i);
                        else if (tmp == Columns.Char_Age) wr.Age = reader.GetInt32(i);
                        else if (tmp == Columns.Char_Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Char_Height) wr.Height = reader.GetFloat(i);
                        else if (tmp == Columns.Id) wr.Id = reader.GetInt32(i);
                    }
                    pre_list.Add(wr);
                }
            }
            conn.Close();
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_char_talent);
                cmd.Parameters.AddWithValue("@character", character.Id);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var tal_list = new List<Types.Talent>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WTalent();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Talent) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        tal_list.Add(new Types.Talent(wr));
                    }
                    character.Talents = tal_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_char_skill);
                cmd.Parameters.AddWithValue("@character", character.Id);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var skill_list = new List<Types.Skill>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSkill();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Skill) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Level) wr.Level = reader.GetInt32(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        skill_list.Add(new Types.Skill(wr));
                    }
                    character.Skills = skill_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_char_stat);
                cmd.Parameters.AddWithValue("@character", character.Id);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var stat_list = new List<Types.Stat>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WStat();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_stat) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Con_StartStat) wr.Starting = reader.GetInt32(i);
                            else if (tmp == Columns.Con_AdvStat) wr.Advance = reader.GetInt32(i);
                            else if (tmp == Columns.Con_CurrStat) wr.Current = reader.GetInt32(i);
                        }
                        stat_list.Add(new Types.Stat(wr));
                    }
                    character.Stats = stat_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_char_weapon);
                cmd.Parameters.AddWithValue("@character", character.Id);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var weapon_list = new List<Types.Weapon>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WWeapon();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Weapon) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Quality) wr.Quality = reader.GetString(i);
                            else if (tmp == Columns.Quantity) wr.Quantity = reader.GetInt32(i);
                            else if (tmp == Columns.Con_Equipped) wr.Equipped = reader.GetBoolean(i);
                        }
                        weapon_list.Add(new Types.Weapon(wr));
                    }
                    character.Weapons = weapon_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_char_armor);
                cmd.Parameters.AddWithValue("@character", character.Id);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var armor_list = new List<Types.Armor>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WArmor();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Armor) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Quality) wr.Quality = reader.GetString(i);
                            else if (tmp == Columns.Quantity) wr.Quantity = reader.GetInt32(i);
                            else if (tmp == Columns.Con_Equipped) wr.Equipped = reader.GetBoolean(i);
                        }
                        armor_list.Add(new Types.Armor(wr));
                    }
                    character.Armor = armor_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_char_item);
                cmd.Parameters.AddWithValue("@character", character.Id);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var item_list = new List<Types.Item>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WItem();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Quality) wr.Quality = reader.GetString(i);
                            else if (tmp == Columns.Quantity) wr.Quantity = reader.GetInt32(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        item_list.Add(new Types.Item(wr));
                    }
                    character.Items = item_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                cmd = new SqlCommand(Commands.SUPP_char_spell);
                cmd.Parameters.AddWithValue("@character", character.Id);
                reader = Call_Command(cmd);
                if (reader.HasRows)
                {
                    var spell_list = new List<Types.Spell>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSpell();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                            if (tmp == Columns.Con_Spell) wr.Name = reader.GetString(i);
                        }
                        spell_list.Add(new Types.Spell(wr));
                    }
                    character.Spells = spell_list.ToArray();
                }
                conn.Close();
            }
            foreach (Types.Wrapper.WCharacter character in pre_list)
            {
                var a = new Types.Character(character);
                list.Add(a.Key.ToString(), a);
            }
            return list;
        }
        public static void Add_Stat(Types.Stat stat)
        {
            var cmd = new SqlCommand(Commands.ADD_stat);
            cmd.Parameters.AddWithValue("@name", stat.Name);
            cmd.Parameters.AddWithValue("@desc", stat.Description);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Add_Item(Types.Item item)
        {
            var cmd = new SqlCommand(Commands.ADD_items);
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@desc", item.Description);
            cmd.Parameters.AddWithValue("@weight", item.Weight);
            cmd.Parameters.AddWithValue("@price", item.Price);
            cmd.Parameters.AddWithValue("@availability", item.Availability);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Add_Weapon(Types.Weapon weapon)
        {
            var cmd = new SqlCommand(Commands.ADD_weapons);
            cmd.Parameters.AddWithValue("@name", weapon.Name);
            cmd.Parameters.AddWithValue("@desc", weapon.Description);
            cmd.Parameters.AddWithValue("@weight", weapon.Weight);
            cmd.Parameters.AddWithValue("@price", weapon.Price);
            cmd.Parameters.AddWithValue("@availability", weapon.Availability);
            cmd.Parameters.AddWithValue("@treats", weapon.Treats);
            cmd.Parameters.AddWithValue("@damage", weapon.Damage);
            cmd.Parameters.AddWithValue("@range", weapon.Range);
            cmd.Parameters.AddWithValue("@reload", weapon.Reload);
            cmd.Parameters.AddWithValue("@category", weapon.Category);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Add_Armor(Types.Armor armor)
        {
            var cmd = new SqlCommand(Commands.ADD_armor);
            cmd.Parameters.AddWithValue("@name", armor.Name);
            cmd.Parameters.AddWithValue("@desc", armor.Description);
            cmd.Parameters.AddWithValue("@availability", armor.Availability);
            cmd.Parameters.AddWithValue("@weight", armor.Weight);
            cmd.Parameters.AddWithValue("@cover", armor.Cover);
            cmd.Parameters.AddWithValue("@points", armor.Points);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Add_Skill(Types.Skill skill)
        {
            var cmd = new SqlCommand(Commands.ADD_skills);
            cmd.Parameters.AddWithValue("@name", skill.Name);
            cmd.Parameters.AddWithValue("@desc", skill.Description);
            cmd.Parameters.AddWithValue("@type", skill.Type);
            cmd.Parameters.AddWithValue("@stat", skill.Characteristic.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Add_Talent(Types.Talent talent)
        {
            var cmd = new SqlCommand(Commands.ADD_talents);
            cmd.Parameters.AddWithValue("@name", talent.Name);
            cmd.Parameters.AddWithValue("@desc", talent.Description);
            Call_Command(cmd);
            conn.Close();
            if (talent.Bonus.Key != null)
            {
                cmd = new SqlCommand(Commands.ADD_talent_stat);
                cmd.Parameters.AddWithValue("@talent", talent.Key);
                cmd.Parameters.AddWithValue("@stat", talent.Bonus.Key);
                cmd.Parameters.AddWithValue("@value", talent.Bonus.Advance);
                Call_Command(cmd);
                conn.Close();
            }
        }
        public static void Add_Spell(Types.Spell spell)
        {
            var cmd = new SqlCommand(Commands.ADD_spells);
            cmd.Parameters.AddWithValue("@name", spell.Name);
            cmd.Parameters.AddWithValue("@desc", spell.Description);
            cmd.Parameters.AddWithValue("@talent", spell.RequiredTalent.Key);
            cmd.Parameters.AddWithValue("@type", spell.MagicType);
            cmd.Parameters.AddWithValue("@level", spell.RequiredLevel);
            cmd.Parameters.AddWithValue("@casttime", spell.CastTime);
            cmd.Parameters.AddWithValue("@duration", spell.Duration);
            Call_Command(cmd);
            conn.Close();
            if (spell.SupportingItem.Key != null)
            {
                cmd = new SqlCommand(Commands.ADD_spell_item);
                cmd.Parameters.AddWithValue("@spell", spell.Key);
                cmd.Parameters.AddWithValue("@item", spell.SupportingItem.Key);
                cmd.Parameters.AddWithValue("@bonus", spell.SupportingItem.Bonus);
                Call_Command(cmd);
                conn.Close();
            }
        }
        public static void Add_God(Types.God god)
        {
            var cmd = new SqlCommand(Commands.ADD_gods);
            cmd.Parameters.AddWithValue("@name", god.Name);
            cmd.Parameters.AddWithValue("@desc", god.Description);
            var ms = new System.IO.MemoryStream();
            if (god.Symbol != null)
                god.Symbol.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            cmd.Parameters.AddWithValue("@symbol", ms.ToArray());
            Call_Command(cmd);
            conn.Close();
            if (god.Skills != null)
                foreach (Types.Skill skill in god.Skills)
                {
                    cmd = new SqlCommand(Commands.ADD_god_skill);
                    cmd.Parameters.AddWithValue("@skill", skill.Key);
                    cmd.Parameters.AddWithValue("@god", god.Key);
                    cmd.Parameters.AddWithValue("@addinfo", skill.AdditionalInfo);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (god.Talents != null)
                foreach (Types.Talent talent in god.Talents)
                {
                    cmd = new SqlCommand(Commands.ADD_god_talent);
                    cmd.Parameters.AddWithValue("@talent", talent.Key);
                    cmd.Parameters.AddWithValue("@god", god.Key);
                    cmd.Parameters.AddWithValue("@addinfo", talent.AdditionalInfo);
                    Call_Command(cmd);
                    conn.Close();
                }
        }
        public static void Add_Race(Types.Race race)
        {
            var cmd = new SqlCommand(Commands.ADD_races);
            cmd.Parameters.AddWithValue("@name", race.Name);
            cmd.Parameters.AddWithValue("@desc", race.Description);
            cmd.Parameters.AddWithValue("@history", race.History);
            cmd.Parameters.AddWithValue("@tips", race.Tips);
            Call_Command(cmd);
            conn.Close();
            if (race.StartingSkills != null)
                foreach (Types.Skill skill in race.StartingSkills)
                {
                    cmd = new SqlCommand(Commands.ADD_race_skill);
                    cmd.Parameters.AddWithValue("@skill", skill.Key);
                    cmd.Parameters.AddWithValue("@race", race.Key);
                    cmd.Parameters.AddWithValue("@addinfo", skill.AdditionalInfo);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (race.StartingTalents != null)
                foreach (Types.Talent talent in race.StartingTalents)
                {
                    cmd = new SqlCommand(Commands.ADD_race_talent);
                    cmd.Parameters.AddWithValue("@talent", talent.Key);
                    cmd.Parameters.AddWithValue("@race", race.Key);
                    cmd.Parameters.AddWithValue("@addinfo", talent.AdditionalInfo);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (race.StartingStats != null)
                foreach (Types.Stat stat in race.StartingStats)
                {
                    cmd = new SqlCommand(Commands.ADD_race_stat);
                    cmd.Parameters.AddWithValue("@stat", stat.Key);
                    cmd.Parameters.AddWithValue("@race", race.Key);
                    cmd.Parameters.AddWithValue("@value", stat.Starting);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (race.PossibleCareer != null)
                foreach (Types.Career career in race.PossibleCareer)
                {
                    cmd = new SqlCommand(Commands.ADD_race_career);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@race", race.Key);
                    Call_Command(cmd);
                    conn.Close();
                }
        }
        public static void Add_Career(Types.Career career)
        {
            var cmd = new SqlCommand(Commands.ADD_careers);
            cmd.Parameters.AddWithValue("@name", career.Name);
            cmd.Parameters.AddWithValue("@type", career.Type);
            Call_Command(cmd);
            conn.Close();
            if (career.AvailableSkills != null)
                foreach (Types.Skill skill in career.AvailableSkills)
                {
                    cmd = new SqlCommand(Commands.ADD_career_skill);
                    cmd.Parameters.AddWithValue("@skill", skill.Key);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@addinfo", skill.AdditionalInfo);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (career.AvailableTalents != null)
                foreach (Types.Talent talent in career.AvailableTalents)
                {
                    cmd = new SqlCommand(Commands.ADD_career_talent);
                    cmd.Parameters.AddWithValue("@talent", talent.Key);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@addinfo", talent.AdditionalInfo);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (career.StatsScheme != null)
                foreach (Types.Stat stat in career.StatsScheme)
                {
                    cmd = new SqlCommand(Commands.ADD_career_stat);
                    cmd.Parameters.AddWithValue("@stat", stat.Key);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@value", stat.Advance);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (career.AvailableCareer != null)
                foreach (Types.Career poscareer in career.AvailableCareer)
                {
                    cmd = new SqlCommand(Commands.ADD_career_career);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@possiblecareer", poscareer.Key);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (career.StartArmor != null)
                foreach (Types.Armor armor in career.StartArmor)
                {
                    cmd = new SqlCommand(Commands.ADD_career_armor);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@armor", armor.Key);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (career.StartWeapons != null)
                foreach (Types.Weapon weapon in career.StartWeapons)
                {
                    cmd = new SqlCommand(Commands.ADD_career_weapon);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@weapon", weapon.Key);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (career.StartEquipment != null)
                foreach (Types.Item item in career.StartEquipment)
                {
                    cmd = new SqlCommand(Commands.ADD_career_item);
                    cmd.Parameters.AddWithValue("@career", career.Key);
                    cmd.Parameters.AddWithValue("@item", item.Key);
                    Call_Command(cmd);
                    conn.Close();
                }

        }
        public static void Add_Character(Types.Character character)
        {
            var cmd = new SqlCommand(Commands.ADD_character);
            cmd.Parameters.AddWithValue("@name", character.Name);
            cmd.Parameters.AddWithValue("@god", character.WorshipedGod.Key);
            cmd.Parameters.AddWithValue("@race", character.Race.Key);
            cmd.Parameters.AddWithValue("@career", character.CurrentCareer.Key);
            cmd.Parameters.AddWithValue("@gender", character.Gender);
            cmd.Parameters.AddWithValue("@eyecolor", character.EyeColor);
            cmd.Parameters.AddWithValue("@haircolor", character.HairColor);
            cmd.Parameters.AddWithValue("@age", character.Age);
            cmd.Parameters.AddWithValue("@weight", character.Weight);
            cmd.Parameters.AddWithValue("@height", character.Height);
            cmd.Parameters.AddWithValue("@starsign", character.StarSign);
            cmd.Parameters.AddWithValue("@features", character.SpecialFeatures);
            cmd.Parameters.AddWithValue("@birthplace", character.BirthPlace);
            cmd.Parameters.AddWithValue("@family", character.Family);
            cmd.Parameters.AddWithValue("@mentalcondition", character.MentalCondition);
            cmd.Parameters.AddWithValue("@scars", character.CutsBruises);
            cmd.Parameters.AddWithValue("@history", character.History);
            cmd.Parameters.AddWithValue("@addinfo", character.AdditionalInfo);
            cmd.Parameters.AddWithValue("@exp", character.Exp);
            Call_Command(cmd);
            conn.Close();
            if (character.Skills != null)
                foreach (Types.Skill skill in character.Skills)
                {
                    cmd = new SqlCommand(Commands.ADD_char_skill);
                    cmd.Parameters.AddWithValue("@skill", skill.Key);
                    cmd.Parameters.AddWithValue("@character", character.Key);
                    cmd.Parameters.AddWithValue("@addinfo", skill.AdditionalInfo);
                    cmd.Parameters.AddWithValue("@level", skill.Level);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (character.Talents != null)
                foreach (Types.Talent talent in character.Talents)
                {
                    cmd = new SqlCommand(Commands.ADD_char_talent);
                    cmd.Parameters.AddWithValue("@talent", talent.Key);
                    cmd.Parameters.AddWithValue("@character", character.Key);
                    cmd.Parameters.AddWithValue("@addinfo", talent.AdditionalInfo);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (character.Stats != null)
                foreach (Types.Stat stat in character.Stats)
                {
                    cmd = new SqlCommand(Commands.ADD_char_stat);
                    cmd.Parameters.AddWithValue("@stat", stat.Key);
                    cmd.Parameters.AddWithValue("@character", character.Key);
                    cmd.Parameters.AddWithValue("@start", stat.Starting);
                    cmd.Parameters.AddWithValue("@adv", stat.Advance);
                    cmd.Parameters.AddWithValue("@curr", stat.Current);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (character.Spells != null)
                foreach (Types.Spell spell in character.Spells)
                {
                    cmd = new SqlCommand(Commands.ADD_char_spell);
                    cmd.Parameters.AddWithValue("@character", character.Key);
                    cmd.Parameters.AddWithValue("@spell", spell.Key);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (character.Armor != null)
                foreach (Types.Armor armor in character.Armor)
                {
                    cmd = new SqlCommand(Commands.ADD_char_armor);
                    cmd.Parameters.AddWithValue("@character", character.Key);
                    cmd.Parameters.AddWithValue("@armor", armor.Key);
                    cmd.Parameters.AddWithValue("@quality", armor.Quality);
                    cmd.Parameters.AddWithValue("@equipped", armor.Equipped);
                    cmd.Parameters.AddWithValue("@quantity", armor.Quantity);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (character.Weapons != null)
                foreach (Types.Weapon weapon in character.Weapons)
                {
                    cmd = new SqlCommand(Commands.ADD_char_weapon);
                    cmd.Parameters.AddWithValue("@character", character.Key);
                    cmd.Parameters.AddWithValue("@weapon", weapon.Key);
                    cmd.Parameters.AddWithValue("@quality", weapon.Quality);
                    cmd.Parameters.AddWithValue("@equipped", weapon.Equipped);
                    cmd.Parameters.AddWithValue("@quantity", weapon.Quantity);
                    Call_Command(cmd);
                    conn.Close();
                }
            if (character.Items != null)
                foreach (Types.Item item in character.Items)
                {
                    cmd = new SqlCommand(Commands.ADD_char_item);
                    cmd.Parameters.AddWithValue("@character", character.Key);
                    cmd.Parameters.AddWithValue("@item", item.Key);
                    cmd.Parameters.AddWithValue("@quality", item.Quality);
                    cmd.Parameters.AddWithValue("@addinfo", item.AdditionalInfo);
                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                    Call_Command(cmd);
                    conn.Close();
                }
        }
        public static void Delete_Stat(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_stat);
            cmd.Parameters.AddWithValue("@stat", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Item(int key)
        {
            var cmd = new SqlCommand(Commands.DELETE_items);
            cmd.Parameters.AddWithValue("@item", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Weapon(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_weapons);
            cmd.Parameters.AddWithValue("@weapon", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Armor(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_armor);
            cmd.Parameters.AddWithValue("@armor", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Skill(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_skills);
            cmd.Parameters.AddWithValue("@skill", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Talent(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_talent_stat);
            cmd.Parameters.AddWithValue("@talent", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_talents);
            cmd.Parameters.AddWithValue("@talent", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Spell(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_spell_item);
            cmd.Parameters.AddWithValue("@spell", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_spells);
            cmd.Parameters.AddWithValue("@spell", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_God(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_god_skill);
            cmd.Parameters.AddWithValue("@god", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_god_talent);
            cmd.Parameters.AddWithValue("@god", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_gods);
            cmd.Parameters.AddWithValue("@god", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Race(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_race_skill);
            cmd.Parameters.AddWithValue("@race", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_race_talent);
            cmd.Parameters.AddWithValue("@race", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_race_stat);
            cmd.Parameters.AddWithValue("@race", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_race_career);
            cmd.Parameters.AddWithValue("@race", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_races);
            cmd.Parameters.AddWithValue("@race", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Career(string key)
        {
            var cmd = new SqlCommand(Commands.DELETE_career_skill);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_career_talent);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_career_stat);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_career_career);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_career_armor);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_career_weapon);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_career_item);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_careers);
            cmd.Parameters.AddWithValue("@career", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Character(int key)
        {
            var cmd = new SqlCommand(Commands.DELETE_char_skill);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_char_talent);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_char_stat);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_char_spell);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_char_armor);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_char_weapon);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_char_item);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
            cmd = new SqlCommand(Commands.DELETE_character);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Character_User(int key)
        {
            var cmd = new SqlCommand(Commands.USER_Del_character);
            cmd.Parameters.AddWithValue("@character", key);
            Call_Command(cmd);
            conn.Close();
        }
        public static Types.AType Rec_Stat(string name)
        {
            var cmd = new SqlCommand(Commands.REC_stats);
            cmd.Parameters.AddWithValue("@stat", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WStat();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                    }
                }
            }
            conn.Close();
            return new Types.Stat(wr);
        }
        public static Types.AType Rec_Skill(string name)
        {
            var cmd = new SqlCommand(Commands.REC_skills);
            cmd.Parameters.AddWithValue("@skill", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WSkill();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Skill_Type) wr.Type = reader.GetString(i);
                        else if (tmp == Columns.Skill_Stat)
                        {
                            var a = new Types.Wrapper.WStat();
                            a.Name = reader.GetString(i);
                            wr.Characteristic = new Types.Stat(a);
                        }
                    }
                }
            }
            conn.Close();
            return new Types.Skill(wr);
        }
        public static Types.AType Rec_Items(int id)
        {
            var cmd = new SqlCommand(Commands.REC_items);
            cmd.Parameters.AddWithValue("@item", id);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WItem();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Id) wr.Id = reader.GetInt32(i);
                        else if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Availability) wr.Availability = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Price) wr.Price = reader.GetString(i);
                    }
                }
            }
            conn.Close();
            return new Types.Item(wr);
        }
        public static Types.AType Rec_Weapons(string name)
        {
            var cmd = new SqlCommand(Commands.REC_weapons);
            cmd.Parameters.AddWithValue("@weapon", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WWeapon();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Weapon_Treats) wr.Treats = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Availability) wr.Availability = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Price) wr.Price = reader.GetString(i);
                        else if (tmp == Columns.Weapon_Range) wr.Range = reader.GetFloat(i);
                        else if (tmp == Columns.Weapon_Reload) wr.Reload = reader.GetInt32(i);
                        else if (tmp == Columns.Weapon_Dmg) wr.Damage = reader.GetString(i);
                        else if (tmp == Columns.Weapon_Category) wr.Category = reader.GetString(i);
                    }
                }
            }
            conn.Close();
            return new Types.Weapon(wr);
        }
        public static Types.AType Rec_Armor(string name)
        {
            var cmd = new SqlCommand(Commands.REC_armor);
            cmd.Parameters.AddWithValue("@armor", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WArmor();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Armor_Cover) wr.Cover = reader.GetString(i);
                        else if (tmp == Columns.Armor_Points) wr.Points = reader.GetInt32(i);
                    }
                }
            }
            conn.Close();
            return new Types.Armor(wr);
        }
        public static Types.AType Rec_Talent(string name)
        {
            var cmd = new SqlCommand(Commands.REC_talents);
            cmd.Parameters.AddWithValue("@talent", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WTalent();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                    }
                }
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_talent_stat);
            cmd.Parameters.AddWithValue("@talent", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var a = new Types.Wrapper.WStat();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_stat) a.Name = reader.GetString(i);
                        else if (tmp == Columns.Value) a.Advance = reader.GetInt32(i);
                    }
                }
                wr.Bonus = new Types.Stat(a);
            }
            conn.Close();
            return new Types.Talent(wr);
        }
        public static Types.AType Rec_Spell(string name)
        {
            var cmd = new SqlCommand(Commands.REC_spells);
            cmd.Parameters.AddWithValue("@spell", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WSpell();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Spell_MType) wr.MagicType = reader.GetString(i);
                        else if (tmp == Columns.Spell_Lvl) wr.RequiredLevel = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_Cast) wr.CastTime = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_Durat) wr.Duration = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_ReqTal)
                        {
                            var a = new Types.Wrapper.WTalent();
                            a.Name = reader.GetString(i);
                            wr.RequiredTalent = new Types.Talent(a);
                        }
                    }
                }
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_spell_item);
            cmd.Parameters.AddWithValue("@spell", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var a = new Types.Wrapper.WItem();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) a.Name = reader.GetString(i);
                        else if (tmp == Columns.Spell_Bonus) a.Bonus = reader.GetInt32(i);
                    }
                }
                wr.SupportingItem = new Types.Item(a);
            }
            conn.Close();
            return new Types.Spell(wr);
        }
        public static Types.AType Rec_God(string name)
        {
            var cmd = new SqlCommand(Commands.REC_gods);
            cmd.Parameters.AddWithValue("@god", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WGod();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                    }
                }
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_god_talent);
            cmd.Parameters.AddWithValue("@god", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var tal_list = new List<Types.Talent>();
                while (reader.Read())
                {
                    var wrt = new Types.Wrapper.WTalent();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Talent) wrt.Name = reader.GetString(i);
                        else if (tmp == Columns.Add_Info) wrt.AdditionalInfo = reader.GetString(i);
                    }
                    tal_list.Add(new Types.Talent(wrt));
                }
                wr.Talents = tal_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_god_skill);
            cmd.Parameters.AddWithValue("@god", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var skill_list = new List<Types.Skill>();
                while (reader.Read())
                {
                    var wrs = new Types.Wrapper.WSkill();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Skill) wrs.Name = reader.GetString(i);
                        else if (tmp == Columns.Add_Info) wrs.AdditionalInfo = reader.GetString(i);
                    }
                    skill_list.Add(new Types.Skill(wrs));
                }
                wr.Skills = skill_list.ToArray();
            }
            conn.Close();
            return new Types.God(wr);
        }
        public static Types.AType Rec_Race(string name)
        {
            var cmd = new SqlCommand(Commands.REC_races);
            cmd.Parameters.AddWithValue("@race", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WRace();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Race_History) wr.History = reader.GetString(i);
                        else if (tmp == Columns.Race_Tips) wr.Tips = reader.GetString(i);
                    }
                }
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_race_talent);
            cmd.Parameters.AddWithValue("@race", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var tal_list = new List<Types.Talent>();
                while (reader.Read())
                {
                    var wrt = new Types.Wrapper.WTalent();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Talent) wrt.Name = reader.GetString(i);
                        else if (tmp == Columns.Add_Info) wrt.AdditionalInfo = reader.GetString(i);
                    }
                    tal_list.Add(new Types.Talent(wrt));
                }
                wr.StartingTalents = tal_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_race_skill);
            cmd.Parameters.AddWithValue("@race", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var skill_list = new List<Types.Skill>();
                while (reader.Read())
                {
                    var wrs = new Types.Wrapper.WSkill();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Skill) wrs.Name = reader.GetString(i);
                        else if (tmp == Columns.Add_Info) wrs.AdditionalInfo = reader.GetString(i);
                    }
                    skill_list.Add(new Types.Skill(wrs));
                }
                wr.StartingSkills = skill_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_race_stat);
            cmd.Parameters.AddWithValue("@race", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var stat_list = new List<Types.Stat>();
                while (reader.Read())
                {
                    var wrst = new Types.Wrapper.WStat();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_stat) wrst.Name = reader.GetString(i);
                        else if (tmp == Columns.Value) wrst.Starting = reader.GetInt32(i);
                    }
                    stat_list.Add(new Types.Stat(wrst));
                }
                wr.StartingStats = stat_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_race_career);
            cmd.Parameters.AddWithValue("@race", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var car_list = new List<Types.Career>();
                while (reader.Read())
                {
                    var wrc = new Types.Wrapper.WCareer();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Career) wrc.Name = reader.GetString(i);
                    }
                    car_list.Add(new Types.Career(wrc));
                }
                wr.PossibleCareer = car_list.ToArray();
            }
            conn.Close();
            return new Types.Race(wr);
        }
        public static Types.AType Rec_Career(string name)
        {
            var cmd = new SqlCommand(Commands.REC_careers);
            cmd.Parameters.AddWithValue("@career", name);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WCareer();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Career_Type) wr.Type = reader.GetString(i);
                    }
                }
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_career_talent);
            cmd.Parameters.AddWithValue("@career", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var tal_list = new List<Types.Talent>();
                while (reader.Read())
                {
                    var wrt = new Types.Wrapper.WTalent();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Talent) wrt.Name = reader.GetString(i);
                        else if (tmp == Columns.Add_Info) wrt.AdditionalInfo = reader.GetString(i);
                    }
                    tal_list.Add(new Types.Talent(wrt));
                }
                wr.AvailableTalents = tal_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_career_skill);
            cmd.Parameters.AddWithValue("@career", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var skill_list = new List<Types.Skill>();
                while (reader.Read())
                {
                    var wrs = new Types.Wrapper.WSkill();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Skill) wrs.Name = reader.GetString(i);
                        else if (tmp == Columns.Add_Info) wrs.AdditionalInfo = reader.GetString(i);
                    }
                    skill_list.Add(new Types.Skill(wrs));
                }
                wr.AvailableSkills = skill_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_career_stat);
            cmd.Parameters.AddWithValue("@career", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var stat_list = new List<Types.Stat>();
                while (reader.Read())
                {
                    var wrst = new Types.Wrapper.WStat();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_stat) wrst.Name = reader.GetString(i);
                        else if (tmp == Columns.Value) wrst.Starting = reader.GetInt32(i);
                    }
                    stat_list.Add(new Types.Stat(wrst));
                }
                wr.StatsScheme = stat_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_career_career);
            cmd.Parameters.AddWithValue("@career", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var car_list = new List<Types.Career>();
                while (reader.Read())
                {
                    var wrc = new Types.Wrapper.WCareer();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_AvailCareer) wrc.Name = reader.GetString(i);
                    }
                    car_list.Add(new Types.Career(wrc));
                }
                wr.AvailableCareer = car_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_carrer_weapon);
            cmd.Parameters.AddWithValue("@career", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var weapon_list = new List<Types.Weapon>();
                while (reader.Read())
                {
                    var wrw = new Types.Wrapper.WWeapon();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Weapon) wrw.Name = reader.GetString(i);
                    }
                    weapon_list.Add(new Types.Weapon(wrw));
                }
                wr.StartWeapons = weapon_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_career_armor);
            cmd.Parameters.AddWithValue("@career", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var armor_list = new List<Types.Armor>();
                while (reader.Read())
                {
                    var wra = new Types.Wrapper.WArmor();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Armor) wra.Name = reader.GetString(i);
                    }
                    armor_list.Add(new Types.Armor(wra));
                }
                wr.StartArmor = armor_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_career_item);
            cmd.Parameters.AddWithValue("@career", name);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var item_list = new List<Types.Item>();
                while (reader.Read())
                {
                    var wri = new Types.Wrapper.WItem();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wri.Name = reader.GetString(i);
                    }
                    item_list.Add(new Types.Item(wri));
                }
                wr.StartEquipment = item_list.ToArray();
            }
            conn.Close();
            return new Types.Career(wr);
        }
        public static Types.AType Rec_Character(int id, bool admin)
        {
            SqlCommand cmd;
            if (admin)
                cmd = new SqlCommand(Commands.REC_characters);
            else
                cmd = new SqlCommand(Commands.USER_Get_Character);
            cmd.Parameters.AddWithValue("@character", id);
            SqlDataReader reader = Call_Command(cmd);
            var wr = new Types.Wrapper.WCharacter();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Char_God)
                        {
                            var a = new Types.Wrapper.WGod();
                            a.Name = reader.GetString(i);
                            wr.WorshipedGod = new Types.God(a);
                        }
                        else if (tmp == Columns.Con_Race)
                        {
                            var a = new Types.Wrapper.WRace();
                            a.Name = reader.GetString(i);
                            wr.Race = new Types.Race(a);
                        }
                        else if (tmp == Columns.Con_Career)
                        {

                            var a = new Types.Wrapper.WCareer();
                            a.Name = reader.GetString(i);
                            wr.CurrentCareer = new Types.Career(a);
                        }
                        else if (tmp == Columns.Char_AddInfo) wr.AdditionalInfo = reader.GetString(i);
                        else if (tmp == Columns.Char_Gender) wr.Gender = reader.GetString(i);
                        else if (tmp == Columns.Char_EyeColor) wr.EyeColor = reader.GetString(i);
                        else if (tmp == Columns.Char_HairColor) wr.HairColor = reader.GetString(i);
                        else if (tmp == Columns.Char_StarSign) wr.StarSign = reader.GetString(i);
                        else if (tmp == Columns.Char_Features) wr.SpecialFeatures = reader.GetString(i);
                        else if (tmp == Columns.Char_BirthPlace) wr.BirthPlace = reader.GetString(i);
                        else if (tmp == Columns.Char_Family) wr.Family = reader.GetString(i);
                        else if (tmp == Columns.Char_MentalCondition) wr.MentalCondition = reader.GetString(i);
                        else if (tmp == Columns.Char_Scars) wr.CutsBruises = reader.GetString(i);
                        else if (tmp == Columns.Char_History) wr.History = reader.GetString(i);
                        else if (tmp == Columns.Char_EXP) wr.Exp = reader.GetInt32(i);
                        else if (tmp == Columns.Char_Age) wr.Age = reader.GetInt32(i);
                        else if (tmp == Columns.Char_Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Char_Height) wr.Height = reader.GetFloat(i);
                        else if (tmp == Columns.Id) wr.Id = reader.GetInt32(i);
                    }
                }
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_char_talent);
            cmd.Parameters.AddWithValue("@character", id);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var tal_list = new List<Types.Talent>();
                while (reader.Read())
                {
                    var wrt = new Types.Wrapper.WTalent();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Talent) wrt.Name = reader.GetString(i);
                        else if (tmp == Columns.Add_Info) wrt.AdditionalInfo = reader.GetString(i);
                    }
                    tal_list.Add(new Types.Talent(wrt));
                }
                wr.Talents = tal_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_char_skill);
            cmd.Parameters.AddWithValue("@character", id);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var skill_list = new List<Types.Skill>();
                while (reader.Read())
                {
                    var wrs = new Types.Wrapper.WSkill();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Skill) wrs.Name = reader.GetString(i);
                        else if (tmp == Columns.Level) wrs.Level = reader.GetInt32(i);
                        else if (tmp == Columns.Add_Info) wrs.AdditionalInfo = reader.GetString(i);
                    }
                    skill_list.Add(new Types.Skill(wrs));
                }
                wr.Skills = skill_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_char_stat);
            cmd.Parameters.AddWithValue("@character", id);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var stat_list = new List<Types.Stat>();
                while (reader.Read())
                {
                    var wrst = new Types.Wrapper.WStat();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_stat) wrst.Name = reader.GetString(i);
                        else if (tmp == Columns.Con_StartStat) wrst.Starting = reader.GetInt32(i);
                        else if (tmp == Columns.Con_AdvStat) wrst.Advance = reader.GetInt32(i);
                        else if (tmp == Columns.Con_CurrStat) wrst.Current = reader.GetInt32(i);
                    }
                    stat_list.Add(new Types.Stat(wrst));
                }
                wr.Stats = stat_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_char_weapon);
            cmd.Parameters.AddWithValue("@character", id);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var weapon_list = new List<Types.Weapon>();
                while (reader.Read())
                {
                    var wrw = new Types.Wrapper.WWeapon();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Weapon) wrw.Name = reader.GetString(i);
                        else if (tmp == Columns.Quality) wrw.Quality = reader.GetString(i);
                        else if (tmp == Columns.Quantity) wrw.Quantity = reader.GetInt32(i);
                        else if (tmp == Columns.Con_Equipped) wrw.Equipped = reader.GetBoolean(i);
                    }
                    weapon_list.Add(new Types.Weapon(wrw));
                }
                wr.Weapons = weapon_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_char_armor);
            cmd.Parameters.AddWithValue("@character", id);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var armor_list = new List<Types.Armor>();
                while (reader.Read())
                {
                    var wra = new Types.Wrapper.WArmor();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Armor) wra.Name = reader.GetString(i);
                        else if (tmp == Columns.Quality) wra.Quality = reader.GetString(i);
                        else if (tmp == Columns.Quantity) wra.Quantity = reader.GetInt32(i);
                        else if (tmp == Columns.Con_Equipped) wra.Equipped = reader.GetBoolean(i);
                    }
                    armor_list.Add(new Types.Armor(wra));
                }
                wr.Armor = armor_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_char_item);
            cmd.Parameters.AddWithValue("@character", id);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var item_list = new List<Types.Item>();
                while (reader.Read())
                {
                    var wri = new Types.Wrapper.WItem();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Name) wri.Name = reader.GetString(i);
                        else if (tmp == Columns.Quality) wri.Quality = reader.GetString(i);
                        else if (tmp == Columns.Quantity) wri.Quantity = reader.GetInt32(i);
                        else if (tmp == Columns.Add_Info) wri.AdditionalInfo = reader.GetString(i);
                    }
                    item_list.Add(new Types.Item(wri));
                }
                wr.Items = item_list.ToArray();
            }
            conn.Close();
            cmd = new SqlCommand(Commands.SUPP_char_spell);
            cmd.Parameters.AddWithValue("@character", id);
            reader = Call_Command(cmd);
            if (reader.HasRows)
            {
                var spell_list = new List<Types.Spell>();
                while (reader.Read())
                {
                    var wrsp = new Types.Wrapper.WSpell();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i); if (reader.IsDBNull(i)) continue;
                        if (tmp == Columns.Con_Spell) wrsp.Name = reader.GetString(i);
                    }
                    spell_list.Add(new Types.Spell(wrsp));
                }
                wr.Spells = spell_list.ToArray();
            }
            conn.Close();
            return new Types.Character(wr);
        }
    }
}
