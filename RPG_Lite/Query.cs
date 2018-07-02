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
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
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
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Skill_Type) wr.Type = reader.GetString(i);
                        else if(tmp == Columns.Skill_Stat)
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
                        if (tmp == Columns.Id) wr.Id = reader.GetInt32(i);
                        else if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Availability) wr.Availability = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Price) wr.Price = reader.GetString(i);
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
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Weight) wr.Weight = reader.GetFloat(i);
                        else if (tmp == Columns.Armor_Cover) wr.Cover = reader.GetString(i);
                        else if (tmp == Columns.Armor_Points) wr.Points = reader.GetInt32(i);
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
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                    }
                    var talent = new Types.Talent(wr);
                    list.Add(talent);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Spells()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_spells);
            var list = new List<Types.AType>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WSpell();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Spell_MType) wr.MagicType = reader.GetString(i);
                        else if (tmp == Columns.Spell_Lvl) wr.RequiredLevel = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_Cast) wr.CastTime = reader.GetInt32(i);
                        else if (tmp == Columns.Spell_Durat) wr.Duration = reader.GetInt32(i);
                        else if(tmp== Columns.Spell_ReqTal)
                        {
                            var a = new Types.Wrapper.WTalent();
                            a.Name = reader.GetString(i);
                            wr.RequiredTalent = new Types.Talent(a);
                        }
                    }
                    var spell = new Types.Spell(wr);
                    list.Add(spell);
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Gods()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_gods);
            var list = new List<Types.AType>();
            var pre_list = new List<Types.Wrapper.WGod>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WGod();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                    }
                    pre_list.Add(wr);
                }
            }
            foreach(Types.Wrapper.WGod god in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_god_talent,god.Name));
                if (reader.HasRows)
                {
                    var tal_list = new List<Types.Talent>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WTalent();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Talent) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        tal_list.Add(new Types.Talent(wr));
                    }
                    god.Talents = tal_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WGod god in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_god_skill, god.Name));
                if (reader.HasRows)
                {
                    var skill_list = new List<Types.Skill>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSkill();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Skill) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        skill_list.Add(new Types.Skill(wr));
                    }
                    god.Skills = skill_list.ToArray();
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Races()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_races);
            var list = new List<Types.AType>();
            var pre_list = new List<Types.Wrapper.WRace>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WRace();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Desc) wr.Description = reader.GetString(i);
                        else if (tmp == Columns.Race_History) wr.History = reader.GetString(i);
                        else if (tmp == Columns.Race_Tips) wr.Tips = reader.GetString(i);
                    }
                    pre_list.Add(wr);
                }
            }
            foreach(Types.Wrapper.WRace race in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_race_talent, race.Name));
                if (reader.HasRows)
                {
                    var tal_list = new List<Types.Talent>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WTalent();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Talent) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        tal_list.Add(new Types.Talent(wr));
                    }
                    race.StartingTalents = tal_list.ToArray();
                }
            }
            foreach(Types.Wrapper.WRace race in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_race_skill, race.Name));
                if (reader.HasRows)
                {
                    var skill_list = new List<Types.Skill>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSkill();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Skill) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        skill_list.Add(new Types.Skill(wr));
                    }
                    race.StartingSkills = skill_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WRace race in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_race_stat, race.Name));
                if (reader.HasRows)
                {
                    var stat_list = new List<Types.Stat>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WStat();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_stat) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Value) wr.Starting = reader.GetInt32(i);
                        }
                        stat_list.Add(new Types.Stat(wr));
                    }
                    race.StartingStats = stat_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WRace race in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_race_career, race.Name));
                if (reader.HasRows)
                {
                    var car_list = new List<Types.Career>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WCareer();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Career) wr.Name = reader.GetString(i);
                        }
                        car_list.Add(new Types.Career(wr));
                    }
                    race.PossibleCareer = car_list.ToArray();
                }
            }
            conn.Close();
            return list;
        }
        public static List<Types.AType> Records_Careers()
        {
            SqlDataReader reader = Call_Command(Commands.RECORDS_careers);
            var list = new List<Types.AType>();
            var pre_list = new List<Types.Wrapper.WCareer>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var wr = new Types.Wrapper.WCareer();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tmp = reader.GetName(i);
                        if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        else if (tmp == Columns.Career_Type) wr.Type = reader.GetString(i);
                    }
                    pre_list.Add(wr);
                }
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_career_talent, career.Name));
                if (reader.HasRows)
                {
                    var tal_list = new List<Types.Talent>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WTalent();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Talent) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        tal_list.Add(new Types.Talent(wr));
                    }
                    career.AvailableTalents = tal_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_career_skill, career.Name));
                if (reader.HasRows)
                {
                    var skill_list = new List<Types.Skill>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WSkill();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Skill) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Add_Info) wr.AdditionalInfo = reader.GetString(i);
                        }
                        skill_list.Add(new Types.Skill(wr));
                    }
                    career.AvailableSkills = skill_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_career_stat, career.Name));
                if (reader.HasRows)
                {
                    var stat_list = new List<Types.Stat>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WStat();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_stat) wr.Name = reader.GetString(i);
                            else if (tmp == Columns.Value) wr.Starting = reader.GetInt32(i);
                        }
                        stat_list.Add(new Types.Stat(wr));
                    }
                    career.StatsScheme = stat_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_career_career, career.Name));
                if (reader.HasRows)
                {
                    var car_list = new List<Types.Career>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WCareer();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_AvailCareer) wr.Name = reader.GetString(i);
                        }
                        car_list.Add(new Types.Career(wr));
                    }
                    career.AvailableCareer = car_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_carrer_weapon, career.Name));
                if (reader.HasRows)
                {
                    var weapon_list = new List<Types.Weapon>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WWeapon();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Weapon) wr.Name = reader.GetString(i);
                        }
                        weapon_list.Add(new Types.Weapon(wr));
                    }
                    career.StartWeapons = weapon_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_career_armor, career.Name));
                if (reader.HasRows)
                {
                    var armor_list = new List<Types.Armor>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WArmor();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Con_Armor) wr.Name = reader.GetString(i);
                        }
                        armor_list.Add(new Types.Armor(wr));
                    }
                    career.StartArmor = armor_list.ToArray();
                }
            }
            foreach (Types.Wrapper.WCareer career in pre_list)
            {
                reader = Call_Command(string.Format(Commands.SUPP_career_item, career.Name));
                if (reader.HasRows)
                {
                    var item_list = new List<Types.Item>();
                    while (reader.Read())
                    {
                        var wr = new Types.Wrapper.WItem();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tmp = reader.GetName(i);
                            if (tmp == Columns.Name) wr.Name = reader.GetString(i);
                        }
                        item_list.Add(new Types.Item(wr));
                    }
                    career.StartEquipment = item_list.ToArray();
                }
            }
            conn.Close();
            return list;
        }

    }
}
