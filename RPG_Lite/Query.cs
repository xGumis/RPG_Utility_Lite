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
            username = user;
            password = pass;
        }
        public static void Initiate()
        {
            Build_Connection();
            var cmd = new SqlCommand(Commands.show_role);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_stats);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_skills);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_items);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_weapons);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_armor);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_talents);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_spells);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_gods);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_races);
            SqlDataReader reader = Call_Command(cmd);
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
            var cmd = new SqlCommand(Commands.RECORDS_careers);
            SqlDataReader reader = Call_Command(cmd);
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
            cmd = new SqlCommand(Commands.ADD_talent_stat);
            cmd.Parameters.AddWithValue("@talent", talent.Key);
            cmd.Parameters.AddWithValue("@stat", talent.Bonus.Key);
            cmd.Parameters.AddWithValue("@value", talent.Bonus.Advance);
            Call_Command(cmd);
            conn.Close();
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
            cmd = new SqlCommand(Commands.ADD_spell_item);
            cmd.Parameters.AddWithValue("@spell", spell.Key);
            cmd.Parameters.AddWithValue("@item", spell.SupportingItem.Key);
            cmd.Parameters.AddWithValue("@bonus", spell.SupportingItem.Bonus);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Add_God(Types.God god)
        {
            var cmd = new SqlCommand(Commands.ADD_gods);
            cmd.Parameters.AddWithValue("@name", god.Name);
            cmd.Parameters.AddWithValue("@desc", god.Description);
            cmd.Parameters.AddWithValue("@symbol", god.Symbol);
            Call_Command(cmd);
            foreach(Types.Skill skill in god.Skills)
            {
                cmd = new SqlCommand(Commands.ADD_god_skill);
                cmd.Parameters.AddWithValue("@skill", skill.Key);
                cmd.Parameters.AddWithValue("@god", god.Key);
                cmd.Parameters.AddWithValue("@addinfo", skill.AdditionalInfo);
                Call_Command(cmd);
            }
            foreach (Types.Talent talent in god.Talents)
            {
                cmd = new SqlCommand(Commands.ADD_god_talent);
                cmd.Parameters.AddWithValue("@talent", talent.Key);
                cmd.Parameters.AddWithValue("@god", god.Key);
                cmd.Parameters.AddWithValue("@addinfo", talent.AdditionalInfo);
                Call_Command(cmd);
            }
            conn.Close();
        }
        public static void Add_Race(Types.Race race)
        {
            var cmd = new SqlCommand(Commands.ADD_races);
            cmd.Parameters.AddWithValue("@name", race.Name);
            cmd.Parameters.AddWithValue("@desc", race.Description);
            cmd.Parameters.AddWithValue("@history", race.History);
            cmd.Parameters.AddWithValue("@tips", race.Tips);
            Call_Command(cmd);
            foreach (Types.Skill skill in race.StartingSkills)
            {
                cmd = new SqlCommand(Commands.ADD_race_skill);
                cmd.Parameters.AddWithValue("@skill", skill.Key);
                cmd.Parameters.AddWithValue("@race", race.Key);
                cmd.Parameters.AddWithValue("@addinfo", skill.AdditionalInfo);
                Call_Command(cmd);
            }
            foreach (Types.Talent talent in race.StartingTalents)
            {
                cmd = new SqlCommand(Commands.ADD_race_talent);
                cmd.Parameters.AddWithValue("@talent", talent.Key);
                cmd.Parameters.AddWithValue("@race", race.Key);
                cmd.Parameters.AddWithValue("@addinfo", talent.AdditionalInfo);
                Call_Command(cmd);
            }
            foreach (Types.Stat stat in race.StartingStats)
            {
                cmd = new SqlCommand(Commands.ADD_race_stat);
                cmd.Parameters.AddWithValue("@stat", stat.Key);
                cmd.Parameters.AddWithValue("@race", race.Key);
                cmd.Parameters.AddWithValue("@value", stat.Starting);
                Call_Command(cmd);
            }
            foreach (Types.Career career in race.PossibleCareer)
            {
                cmd = new SqlCommand(Commands.ADD_race_career);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@race", race.Key);
                Call_Command(cmd);
            }
            conn.Close();
        }
        public static void Add_Career(Types.Career career)
        {
            var cmd = new SqlCommand(Commands.ADD_careers);
            cmd.Parameters.AddWithValue("@name", career.Name);
            cmd.Parameters.AddWithValue("@type", career.Type);
            Call_Command(cmd);
            foreach (Types.Skill skill in career.AvailableSkills)
            {
                cmd = new SqlCommand(Commands.ADD_career_skill);
                cmd.Parameters.AddWithValue("@skill", skill.Key);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@addinfo", skill.AdditionalInfo);
                Call_Command(cmd);
            }
            foreach (Types.Talent talent in career.AvailableTalents)
            {
                cmd = new SqlCommand(Commands.ADD_career_talent);
                cmd.Parameters.AddWithValue("@talent", talent.Key);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@addinfo", talent.AdditionalInfo);
                Call_Command(cmd);
            }
            foreach (Types.Stat stat in career.StatsScheme)
            {
                cmd = new SqlCommand(Commands.ADD_career_stat);
                cmd.Parameters.AddWithValue("@stat", stat.Key);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@value", stat.Advance);
                Call_Command(cmd);
            }
            foreach (Types.Career poscareer in career.AvailableCareer)
            {
                cmd = new SqlCommand(Commands.ADD_career_career);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@possiblecareer", poscareer.Key);
                Call_Command(cmd);
            }
            foreach (Types.Armor armor in career.StartArmor)
            {
                cmd = new SqlCommand(Commands.ADD_career_armor);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@armor", armor.Key);
                Call_Command(cmd);
            }
            foreach (Types.Weapon weapon in career.StartWeapons)
            {
                cmd = new SqlCommand(Commands.ADD_career_weapon);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@weapon", weapon.Key);
                Call_Command(cmd);
            }
            foreach (Types.Item item in career.StartEquipment)
            {
                cmd = new SqlCommand(Commands.ADD_career_item);
                cmd.Parameters.AddWithValue("@career", career.Key);
                cmd.Parameters.AddWithValue("@item", item.Key);
                Call_Command(cmd);
            }
            conn.Close();
        }
        public static void Delete_Stat(Types.Stat stat)
        {
            var cmd = new SqlCommand(Commands.DELETE_stat);
            cmd.Parameters.AddWithValue("@stat", stat.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Item(Types.Item item)
        {
            var cmd = new SqlCommand(Commands.DELETE_items);
            cmd.Parameters.AddWithValue("@item", item.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Weapon(Types.Weapon weapon)
        {
            var cmd = new SqlCommand(Commands.DELETE_weapons);
            cmd.Parameters.AddWithValue("@weapon", weapon.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Armor(Types.Armor armor)
        {
            var cmd = new SqlCommand(Commands.DELETE_armor);
            cmd.Parameters.AddWithValue("@armor", armor.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Skill(Types.Skill skill)
        {
            var cmd = new SqlCommand(Commands.DELETE_skills);
            cmd.Parameters.AddWithValue("@skill", skill.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Talent(Types.Talent talent)
        {
            var cmd = new SqlCommand(Commands.DELETE_talent_stat);
            cmd.Parameters.AddWithValue("@talent", talent.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_talents);
            cmd.Parameters.AddWithValue("@talent", talent.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Spell(Types.Spell spell)
        {
            var cmd = new SqlCommand(Commands.DELETE_spell_item);
            cmd.Parameters.AddWithValue("@spell", spell.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_spells);
            cmd.Parameters.AddWithValue("@spell", spell.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_God(Types.God god)
        {
            var cmd = new SqlCommand(Commands.DELETE_god_skill);
            cmd.Parameters.AddWithValue("@god", god.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_god_talent);
            cmd.Parameters.AddWithValue("@god", god.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_gods);
            cmd.Parameters.AddWithValue("@god", god.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Race(Types.Race race)
        {
            var cmd = new SqlCommand(Commands.DELETE_race_skill);
            cmd.Parameters.AddWithValue("@race", race.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_race_talent);
            cmd.Parameters.AddWithValue("@race", race.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_race_stat);
            cmd.Parameters.AddWithValue("@race", race.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_race_career);
            cmd.Parameters.AddWithValue("@race", race.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_races);
            cmd.Parameters.AddWithValue("@race", race.Key);
            Call_Command(cmd);
            conn.Close();
        }
        public static void Delete_Career(Types.Career career)
        {
            var cmd = new SqlCommand(Commands.DELETE_career_skill);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_career_talent);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_career_stat);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_career_career);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_career_armor);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_career_weapon);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_career_item);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            cmd = new SqlCommand(Commands.DELETE_careers);
            cmd.Parameters.AddWithValue("@career", career.Key);
            Call_Command(cmd);
            conn.Close();
        }


    }
}
