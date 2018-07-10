using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite
{
    class DBOperator
    {
        private Dictionary<string, Types.AType> holdList;
        private Types.AType holdItem;
        private Types.AType viewItem;
        private bool allFlag = false;
        public string[] GetTables()
        {
            return new string[] { "Bogowie", "Bronie", "Cechy", "Pancerze", "Postaci", "Profesje", "Przedmioty", "Rasy", "Umiejętności", "Zaklęcia", "Zdolności" };
        }
        public string[] GetColumnNames(string table)
        {
            switch (table)
            {
                default:
                    return null;
                case "Bogowie":
                    return new string[] { "Nazwa" };
                case "Bronie":
                    return new string[] { "Nazwa", "Kategoria", "Siła", "Zasięg", "Cena" };
                case "Cechy":
                    return new string[] { "Nazwa" };
                case "Pancerze":
                    return new string[] { "Nazwa", "PZ" };
                case "Postaci":
                    return new string[] { "Nazwa", "Rasa", "Profesja", "XP" };
                case "Profesje":
                    return new string[] { "Nazwa", "Rodzaj" };
                case "Przedmioty":
                    return new string[] { "Nazwa", "Cena" };
                case "Rasy":
                    return new string[] { "Nazwa" };
                case "Umiejętności":
                    return new string[] { "Nazwa", "Cecha", "Typ" };
                case "Zaklęcia":
                    return new string[] { "Nazwa", "Typ magii", "Wymagany poziom" };
                case "Zdolności":
                    return new string[] { "Nazwa" };
            }
        }
        public List<string[]> GetRecordsList(string table)
        {
            var list = new List<string[]>();
            #region Bogowie
            if (table == "Bogowie")
            {
                holdList = Query.Records_Gods();
                foreach (var word in holdList)
                {
                    var god = (Types.God)word.Value;
                    list.Add(new string[] { word.Key, god.Name });
                }
            }
            #endregion
            #region Bronie
            else if (table == "Bronie")
            {
                holdList = Query.Records_Weapons();
                foreach (var word in holdList)
                {
                    var weapon = (Types.Weapon)word.Value;
                    list.Add(new string[] { word.Key, weapon.Name, weapon.Category, weapon.Damage, weapon.Range.ToString(), weapon.Price });
                }
            }
            #endregion
            #region Cechy
            else if (table == "Cechy")
            {
                holdList = Query.Records_Stats();
                foreach (var word in holdList)
                {
                    var stat = (Types.Stat)word.Value;
                    list.Add(new string[] { word.Key, stat.Name });
                }
            }
            #endregion
            #region Pancerze
            else if (table == "Pancerze")
            {
                holdList = Query.Records_Armor();
                foreach (var word in holdList)
                {
                    var armor = (Types.Armor)word.Value;
                    list.Add(new string[] { word.Key, armor.Name, armor.Points.ToString() });
                }
            }
            #endregion
            #region Postaci
            else if (table == "Postaci")
            {
                if (Query.is_Admin() && allFlag == true)
                    holdList = Query.Records_Characters(true);
                else
                {
                    holdList = Query.Records_Characters(false);
                }
                foreach (var word in holdList)
                {
                    var character = (Types.Character)word.Value;
                    list.Add(new string[] { word.Key, character.Name, character.Race.Name, character.CurrentCareer.Name, character.Exp.ToString() });
                }
            }
            #endregion
            #region Profesje
            else if (table == "Profesje")
            {
                holdList = Query.Records_Careers();
                foreach (var word in holdList)
                {
                    var career = (Types.Career)word.Value;
                    list.Add(new string[] { word.Key, career.Name, career.Type });
                }
            }
            #endregion
            #region Przedmioty
            else if (table == "Przedmioty")
            {
                holdList = Query.Records_Items();
                foreach (var word in holdList)
                {
                    var item = (Types.Item)word.Value;
                    list.Add(new string[] { word.Key, item.Name, item.Price });
                }
            }
            #endregion
            #region Rasy
            else if (table == "Rasy")
            {
                holdList = Query.Records_Races();
                foreach (var word in holdList)
                {
                    var race = (Types.Race)word.Value;
                    list.Add(new string[] { word.Key, race.Name });
                }
            }
            #endregion
            #region Umiejętności
            else if (table == "Umiejętności")
            {
                holdList = Query.Records_Skills();
                foreach (var word in holdList)
                {
                    var skill = (Types.Skill)word.Value;
                    list.Add(new string[] { word.Key, skill.Name, skill.Characteristic.Name, skill.Type });
                }
            }
            #endregion
            #region Zaklęcia
            else if (table == "Zaklęcia")
            {
                holdList = Query.Records_Spells();
                foreach (var word in holdList)
                {
                    var spell = (Types.Spell)word.Value;
                    list.Add(new string[] { word.Key, spell.Name, spell.MagicType, spell.RequiredLevel.ToString() });
                }
            }
            #endregion
            #region Zdolności
            else if (table == "Zdolności")
            {
                holdList = Query.Records_Talents();
                foreach (var word in holdList)
                {
                    var talent = (Types.Talent)word.Value;
                    list.Add(new string[] { word.Key, talent.Name });
                }
            }
            #endregion
            return list;
        }
        public void SwitchMode()
        {
            if (Query.is_Admin())
            {
                if (allFlag == false)
                    allFlag = true;
                else allFlag = false;
            }
        }
        public string Show_Role()
        {
            if (Query.is_Admin())
                return "admin";
            else
                return "user";
        }
        public bool Login(string username, string password)
        {
            Query.Change_Login(username, password);
            Query.Initiate();
            allFlag = false;
            return Query.is_Logged();
        }
        public void DeleteItem(string table, string key)
        {
            if (Query.is_Admin())
            {
                #region Bogowie
                if (table == "Bogowie")
                {
                    Query.Delete_God(key);
                }
                #endregion
                #region Bronie
                else if (table == "Bronie")
                {
                    Query.Delete_Weapon(key);
                }
                #endregion
                #region Cechy
                else if (table == "Cechy")
                {
                    Query.Delete_Stat(key);
                }
                #endregion
                #region Pancerze
                else if (table == "Pancerze")
                {
                    Query.Delete_Armor(key);
                }
                #endregion
                #region Profesje
                else if (table == "Profesje")
                {
                    Query.Delete_Career(key);
                }
                #endregion
                #region Przedmioty
                else if (table == "Przedmioty")
                {
                    Query.Delete_Item(int.Parse(key));
                }
                #endregion
                #region Rasy
                else if (table == "Rasy")
                {
                    Query.Delete_Race(key);
                }
                #endregion
                #region Umiejętności
                else if (table == "Umiejętności")
                {
                    Query.Delete_Skill(key);
                }
                #endregion
                #region Zaklęcia
                else if (table == "Zaklęcia")
                {
                    Query.Delete_Spell(key);
                }
                #endregion
                #region Zdolności
                else if (table == "Zdolności")
                {
                    Query.Delete_Talent(key);
                }
                #endregion
            }
            #region Postaci
            else if (table == "Postaci")
            {
                if (Query.is_Admin())
                    Query.Delete_Character(int.Parse(key));
                else
                {
                    Query.Delete_Character_User(int.Parse(key));
                }
            }
            #endregion
        }
        public void CreateNewItem(string table)
        {
            if (Query.is_Admin())
            {
                #region Bogowie
                if (table == "Bogowie")
                {
                    holdItem = new Types.God();
                }
                #endregion
                #region Bronie
                else if (table == "Bronie")
                {
                    holdItem = new Types.Weapon();
                }
                #endregion
                #region Cechy
                else if (table == "Cechy")
                {
                    holdItem = new Types.Stat();
                }
                #endregion
                #region Pancerze
                else if (table == "Pancerze")
                {
                    holdItem = new Types.Armor();
                }
                #endregion
                #region Profesje
                else if (table == "Profesje")
                {
                    holdItem = new Types.Career();
                }
                #endregion
                #region Przedmioty
                else if (table == "Przedmioty")
                {
                    holdItem = new Types.Item();
                }
                #endregion
                #region Rasy
                else if (table == "Rasy")
                {
                    holdItem = new Types.Race();
                }
                #endregion
                #region Umiejętności
                else if (table == "Umiejętności")
                {
                    holdItem = new Types.Skill();
                }
                #endregion
                #region Zaklęcia
                else if (table == "Zaklęcia")
                {
                    holdItem = new Types.Spell();
                }
                #endregion
                #region Zdolności
                else if (table == "Zdolności")
                {
                    holdItem = new Types.Talent();
                }
                #endregion
            }
            #region Postaci
            else if (table == "Postaci")
            {
                holdItem = new Types.Character();
            }
            #endregion
        }
        public void InsertItem()
        {
            if (holdItem != null)
            {
                if (holdItem.Key != null)
                {
                    if (Query.is_Admin())
                    {
                        #region Bogowie
                        if (holdItem is Types.God)
                        {
                            var god = holdItem as Types.God;
                            Query.Add_God(god);
                        }
                        #endregion
                        #region Bronie
                        if (holdItem is Types.Weapon)
                        {
                            var weapon = holdItem as Types.Weapon;
                            Query.Add_Weapon(weapon);
                        }
                        #endregion
                        #region Cechy
                        if (holdItem is Types.Stat)
                        {
                            var stat = holdItem as Types.Stat;
                            Query.Add_Stat(stat);
                        }
                        #endregion
                        #region Pancerze
                        if (holdItem is Types.Armor)
                        {
                            var armor = holdItem as Types.Armor;
                            Query.Add_Armor(armor);
                        }
                        #endregion
                        #region Profesje
                        if (holdItem is Types.Career)
                        {
                            var career = holdItem as Types.Career;
                            Query.Add_Career(career);
                        }
                        #endregion
                        #region Przedmioty
                        if (holdItem is Types.Item && int.Parse(holdItem.Key) != -1)
                        {
                            var item = holdItem as Types.Item;
                            if (item.Name != null)
                                Query.Add_Item(item);
                        }
                        #endregion
                        #region Rasy
                        if (holdItem is Types.Race)
                        {
                            var race = holdItem as Types.Race;
                            Query.Add_Race(race);
                        }
                        #endregion
                        #region Umiejętności
                        if (holdItem is Types.Skill)
                        {
                            var skill = holdItem as Types.Skill;
                            if (skill.Characteristic.Key != null)
                                Query.Add_Skill(skill);
                        }
                        #endregion
                        #region Zaklęcia
                        if (holdItem is Types.Spell)
                        {
                            var spell = holdItem as Types.Spell;
                            if (spell.RequiredTalent != null)
                                Query.Add_Spell(spell);
                        }
                        #endregion
                        #region Zdolności
                        if (holdItem is Types.Talent)
                        {
                            var talent = holdItem as Types.Talent;
                            Query.Add_Talent(talent);
                        }
                        #endregion
                    }
                    #region Postaci
                    if (holdItem is Types.Character && int.Parse(holdItem.Key) != -1)
                    {
                        var character = holdItem as Types.Character;
                        if (character.Race.Key != null && character.WorshipedGod.Key != null && character.Name != null && character.CurrentCareer.Key != null)
                            Query.Add_Character(character);
                    }
                    #endregion
                }
            }
        }
        public void UpdateItem(string column, string value)
        {
            if (holdItem != null)
            {
                if (value != null)
                {
                    if (Query.is_Admin())
                    {
                        #region Bogowie
                        if (holdItem is Types.God)
                        {
                            var god = new Types.Wrapper.WGod(holdItem as Types.God);
                            if (column == Columns.Name) god.Name = value;
                            else if (column == Columns.God_Symbol) god.Symbol = new System.Drawing.Bitmap(value);
                            else if (column == Columns.Desc) god.Description = value;
                            holdItem = new Types.God(god);
                        }
                        #endregion
                        #region Bronie
                        if (holdItem is Types.Weapon)
                        {
                            var weapon = new Types.Wrapper.WWeapon(holdItem as Types.Weapon);
                            if (column == Columns.Name) weapon.Name = value;
                            else if (column == Columns.Weapon_Treats) weapon.Treats = value;
                            else if (column == Columns.Desc) weapon.Description = value;
                            else if (column == Columns.Availability) weapon.Availability = value;
                            else if (column == Columns.Weight) weapon.Weight = float.Parse(value);
                            else if (column == Columns.Price) weapon.Price = value;
                            else if (column == Columns.Weapon_Range) weapon.Range = float.Parse(value);
                            else if (column == Columns.Weapon_Reload) weapon.Reload = int.Parse(value);
                            else if (column == Columns.Weapon_Dmg) weapon.Damage = value;
                            else if (column == Columns.Weapon_Category) weapon.Category = value;
                            holdItem = new Types.Weapon(weapon);
                        }
                        #endregion
                        #region Cechy
                        if (holdItem is Types.Stat)
                        {
                            var stat = new Types.Wrapper.WStat(holdItem as Types.Stat);
                            if (column == Columns.Name) stat.Name = value;
                            else if (column == Columns.Desc) stat.Description = value;
                            holdItem = new Types.Stat(stat);
                        }
                        #endregion
                        #region Pancerze
                        if (holdItem is Types.Armor)
                        {
                            var armor = new Types.Wrapper.WArmor(holdItem as Types.Armor);
                            if (column == Columns.Name) armor.Name = value;
                            else if (column == Columns.Desc) armor.Description = value;
                            else if (column == Columns.Weight) armor.Weight = float.Parse(value);
                            else if (column == Columns.Availability) armor.Availability = value;
                            else if (column == Columns.Armor_Cover) armor.Cover = value;
                            else if (column == Columns.Armor_Points) armor.Points = int.Parse(value);
                            holdItem = new Types.Armor(armor);
                        }
                        #endregion
                        #region Profesje
                        if (holdItem is Types.Career)
                        {
                            var career = new Types.Wrapper.WCareer(holdItem as Types.Career);
                            if (column == Columns.Name) career.Name = value;
                            else if (column == Columns.Career_Type) career.Type = value;
                            holdItem = new Types.Career(career);
                        }
                        #endregion
                        #region Przedmioty
                        if (holdItem is Types.Item)
                        {
                            var item = new Types.Wrapper.WItem(holdItem as Types.Item);
                            if (column == Columns.Name)
                            {
                                item.Name = value;
                                item.Id = 0;
                            }
                            else if (column == Columns.Desc) item.Description = value;
                            else if (column == Columns.Availability) item.Availability = value;
                            else if (column == Columns.Weight) item.Weight = float.Parse(value);
                            else if (column == Columns.Price) item.Price = value;
                            holdItem = new Types.Item(item);
                        }
                        #endregion
                        #region Rasy
                        if (holdItem is Types.Race)
                        {
                            var race = new Types.Wrapper.WRace(holdItem as Types.Race);
                            if (column == Columns.Name) race.Name = value;
                            else if (column == Columns.Desc) race.Description = value;
                            else if (column == Columns.Race_History) race.History = value;
                            else if (column == Columns.Race_Tips) race.Tips = value;
                            holdItem = new Types.Race(race);
                        }
                        #endregion
                        #region Umiejętności
                        if (holdItem is Types.Skill)
                        {
                            var skill = new Types.Wrapper.WSkill(holdItem as Types.Skill);
                            if (column == Columns.Name) skill.Name = value;
                            else if (column == Columns.Desc) skill.Description = value;
                            else if (column == Columns.Skill_Type) skill.Type = value;
                            else if (column == Columns.Skill_Stat)
                            {
                                var a = new Types.Wrapper.WStat();
                                a.Name = value;
                                skill.Characteristic = new Types.Stat(a);
                            }
                            holdItem = new Types.Skill(skill);
                        }
                        #endregion
                        #region Zaklęcia
                        if (holdItem is Types.Spell)
                        {
                            var spell = new Types.Wrapper.WSpell(holdItem as Types.Spell);
                            if (column == Columns.Name) spell.Name = value;
                            else if (column == Columns.Desc) spell.Description = value;
                            else if (column == Columns.Spell_MType) spell.MagicType = value;
                            else if (column == Columns.Spell_Lvl) spell.RequiredLevel = int.Parse(value);
                            else if (column == Columns.Spell_Cast) spell.CastTime = int.Parse(value);
                            else if (column == Columns.Spell_Durat) spell.Duration = int.Parse(value);
                            else if (column == Columns.Spell_ReqTal)
                            {
                                var a = new Types.Wrapper.WTalent();
                                a.Name = value;
                                spell.RequiredTalent = new Types.Talent(a);
                            }
                            else if (column == Columns.Con_Item)
                            {
                                var a = new Types.Wrapper.WItem();
                                a.Id = int.Parse(value);
                                spell.SupportingItem = new Types.Item(a);
                            }
                            else if (column == Columns.Spell_Bonus)
                            {
                                var a = new Types.Wrapper.WItem();
                                a.Id = spell.SupportingItem.Id;
                                a.Bonus = int.Parse(value);
                                spell.SupportingItem = new Types.Item(a);

                            }
                            holdItem = new Types.Spell(spell);
                        }
                        #endregion
                        #region Zdolności
                        if (holdItem is Types.Talent)
                        {
                            var talent = new Types.Wrapper.WTalent(holdItem as Types.Talent);
                            if (column == Columns.Name) talent.Name = value;
                            else if (column == Columns.Desc) talent.Description = value;
                            else if (column == Columns.Con_stat)
                            {
                                var a = new Types.Wrapper.WStat();
                                a.Name = value;
                                talent.Bonus = new Types.Stat(a);
                            }
                            else if (column == Columns.Value)
                            {
                                var a = new Types.Wrapper.WStat();
                                a.Name = talent.Bonus.Name;
                                a.Advance = int.Parse(value);
                                talent.Bonus = new Types.Stat(a);
                            }
                            holdItem = new Types.Talent(talent);
                        }
                        #endregion
                    }
                    #region Postaci
                    if (holdItem is Types.Character)
                    {
                        var character = new Types.Wrapper.WCharacter(holdItem as Types.Character);
                        if (column == Columns.Name)
                        {
                            character.Name = value;
                            character.Id = 0;
                        }
                        else if (column == Columns.Char_God)
                        {
                            var a = new Types.Wrapper.WGod();
                            a.Name = value;
                            character.WorshipedGod = new Types.God(a);
                        }
                        else if (column == Columns.Con_Race)
                        {
                            var a = new Types.Wrapper.WRace();
                            a.Name = value;
                            character.Race = new Types.Race(a);
                        }
                        else if (column == Columns.Con_Career)
                        {

                            var a = new Types.Wrapper.WCareer();
                            a.Name = value;
                            character.CurrentCareer = new Types.Career(a);
                        }
                        else if (column == Columns.Char_AddInfo) character.AdditionalInfo = value;
                        else if (column == Columns.Char_Gender) character.Gender = value;
                        else if (column == Columns.Char_EyeColor) character.EyeColor = value;
                        else if (column == Columns.Char_HairColor) character.HairColor = value;
                        else if (column == Columns.Char_StarSign) character.StarSign = value;
                        else if (column == Columns.Char_Features) character.SpecialFeatures = value;
                        else if (column == Columns.Char_BirthPlace) character.BirthPlace = value;
                        else if (column == Columns.Char_Family) character.Family = value;
                        else if (column == Columns.Char_MentalCondition) character.MentalCondition = value;
                        else if (column == Columns.Char_Scars) character.CutsBruises = value;
                        else if (column == Columns.Char_History) character.History = value;
                        else if (column == Columns.Char_EXP) character.Exp = int.Parse(value);
                        else if (column == Columns.Char_Age) character.Age = int.Parse(value);
                        else if (column == Columns.Char_Weight) character.Weight = float.Parse(value);
                        else if (column == Columns.Char_Height) character.Height = float.Parse(value);
                        holdItem = new Types.Character(character);
                    }
                    #endregion
                }
            }
        }
        public void GetItem(string table, string key)
        {
            #region Bogowie
            if (table == "Bogowie")
            {
                viewItem = Query.Rec_God(key);
            }
            #endregion
            #region Bronie
            else if (table == "Bronie")
            {
                viewItem = Query.Rec_Weapons(key);
            }
            #endregion
            #region Cechy
            else if (table == "Cechy")
            {
                viewItem = Query.Rec_Stat(key);
            }
            #endregion
            #region Pancerze
            else if (table == "Pancerze")
            {
                viewItem = Query.Rec_Armor(key);
            }
            #endregion
            #region Profesje
            else if (table == "Profesje")
            {
                viewItem = Query.Rec_Career(key);
            }
            #endregion
            #region Przedmioty
            else if (table == "Przedmioty")
            {
                viewItem = Query.Rec_Items(int.Parse(key));
            }
            #endregion
            #region Rasy
            else if (table == "Rasy")
            {
                viewItem = Query.Rec_Race(key);
            }
            #endregion
            #region Umiejętności
            else if (table == "Umiejętności")
            {
                viewItem = Query.Rec_Skill(key);
            }
            #endregion
            #region Zaklęcia
            else if (table == "Zaklęcia")
            {
                viewItem = Query.Rec_Spell(key);
            }
            #endregion
            #region Zdolności
            else if (table == "Zdolności")
            {
                viewItem = Query.Rec_Talent(key);
            }
            #endregion
            #region Postaci
            else if (table == "Postaci")
            {
                if (Query.is_Admin())
                    viewItem = Query.Rec_Character(int.Parse(key), true);
                else
                    viewItem = Query.Rec_Character(int.Parse(key), false);
            }
            #endregion
        }
        public void UpdateItemList(string column, Dictionary<string, string>[] values)
        {
            if (holdItem != null)
            {
                if (values != null)
                {
                    if (Query.is_Admin())
                    {
                        #region Bogowie
                        if (holdItem is Types.God)
                        {
                            var god = new Types.Wrapper.WGod(holdItem as Types.God);
                            if (column == Columns.Con_Talent)
                            {
                                var a = new List<Types.Talent>();
                                foreach (var talent in values)
                                {
                                    var b = new Types.Wrapper.WTalent();
                                    foreach (var col in talent)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    }
                                    a.Add(new Types.Talent(b));
                                }
                                god.Talents = a.ToArray();
                            }
                            if (column == Columns.Con_Skill)
                            {
                                var a = new List<Types.Skill>();
                                foreach (var skill in values)
                                {
                                    var b = new Types.Wrapper.WSkill();
                                    foreach (var col in skill)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    }
                                    a.Add(new Types.Skill(b));
                                }
                                god.Skills = a.ToArray();
                            }
                            holdItem = new Types.God(god);
                        }
                        #endregion
                        #region Profesje
                        if (holdItem is Types.Career)
                        {
                            var career = new Types.Wrapper.WCareer(holdItem as Types.Career);
                            if (column == Columns.Con_Talent)
                            {
                                var a = new List<Types.Talent>();
                                foreach (var talent in values)
                                {
                                    var b = new Types.Wrapper.WTalent();
                                    foreach (var col in talent)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    }
                                    a.Add(new Types.Talent(b));
                                }
                                career.AvailableTalents = a.ToArray();
                            }
                            if (column == Columns.Con_Skill)
                            {
                                var a = new List<Types.Skill>();
                                foreach (var skill in values)
                                {
                                    var b = new Types.Wrapper.WSkill();
                                    foreach (var col in skill)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    }
                                    a.Add(new Types.Skill(b));
                                }
                                career.AvailableSkills = a.ToArray();
                            }
                            if (column == Columns.Con_stat)
                            {
                                var a = new List<Types.Stat>();
                                foreach (var stat in values)
                                {
                                    var b = new Types.Wrapper.WStat();
                                    foreach (var col in stat)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Con_AdvStat) b.Advance = int.Parse(col.Value);
                                    }
                                    a.Add(new Types.Stat(b));
                                }
                                career.StatsScheme = a.ToArray();
                            }
                            if (column == Columns.Con_Item)
                            {
                                var a = new List<Types.Item>();
                                foreach (var item in values)
                                {
                                    var b = new Types.Wrapper.WItem();
                                    foreach (var col in item)
                                    {
                                        if (col.Key == Columns.Id) b.Id = int.Parse(col.Value);
                                    }
                                    a.Add(new Types.Item(b));
                                }
                                career.StartEquipment = a.ToArray();
                            }
                            if (column == Columns.Con_Weapon)
                            {
                                var a = new List<Types.Weapon>();
                                foreach (var weapon in values)
                                {
                                    var b = new Types.Wrapper.WWeapon();
                                    foreach (var col in weapon)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                    }
                                    a.Add(new Types.Weapon(b));
                                }
                                career.StartWeapons = a.ToArray();
                            }
                            if (column == Columns.Con_Armor)
                            {
                                var a = new List<Types.Armor>();
                                foreach (var armor in values)
                                {
                                    var b = new Types.Wrapper.WArmor();
                                    foreach (var col in armor)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                    }
                                    a.Add(new Types.Armor(b));
                                }
                                career.StartArmor = a.ToArray();
                            }
                            if (column == Columns.Con_Career)
                            {
                                var a = new List<Types.Career>();
                                foreach (var car in values)
                                {
                                    var b = new Types.Wrapper.WCareer();
                                    foreach (var col in car)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                    }
                                    a.Add(new Types.Career(b));
                                }
                                career.AvailableCareer = a.ToArray();
                            }
                            holdItem = new Types.Career(career);
                        }
                        #endregion
                        #region Rasy
                        if (holdItem is Types.Race)
                        {
                            var race = new Types.Wrapper.WRace(holdItem as Types.Race);
                            if (column == Columns.Con_Talent)
                            {
                                var a = new List<Types.Talent>();
                                foreach (var talent in values)
                                {
                                    var b = new Types.Wrapper.WTalent();
                                    foreach (var col in talent)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    }
                                    a.Add(new Types.Talent(b));
                                }
                                race.StartingTalents = a.ToArray();
                            }
                            if (column == Columns.Con_Skill)
                            {
                                var a = new List<Types.Skill>();
                                foreach (var skill in values)
                                {
                                    var b = new Types.Wrapper.WSkill();
                                    foreach (var col in skill)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    }
                                    a.Add(new Types.Skill(b));
                                }
                                race.StartingSkills = a.ToArray();
                            }
                            if (column == Columns.Con_stat)
                            {
                                var a = new List<Types.Stat>();
                                foreach (var stat in values)
                                {
                                    var b = new Types.Wrapper.WStat();
                                    foreach (var col in stat)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                        else if (col.Key == Columns.Con_StartStat) b.Starting = int.Parse(col.Value);
                                    }
                                    a.Add(new Types.Stat(b));
                                }
                                race.StartingStats = a.ToArray();
                            }
                            if (column == Columns.Con_Career)
                            {
                                var a = new List<Types.Career>();
                                foreach (var car in values)
                                {
                                    var b = new Types.Wrapper.WCareer();
                                    foreach (var col in car)
                                    {
                                        if (col.Key == Columns.Name) b.Name = col.Value;
                                    }
                                    a.Add(new Types.Career(b));
                                }
                                race.PossibleCareer = a.ToArray();
                            }
                            holdItem = new Types.Race(race);
                        }
                        #endregion
                    }
                    #region Postaci
                    if (holdItem is Types.Character)
                    {
                        var character = new Types.Wrapper.WCharacter(holdItem as Types.Character);
                        if (column == Columns.Con_Talent)
                        {
                            var a = new List<Types.Talent>();
                            foreach (var talent in values)
                            {
                                var b = new Types.Wrapper.WTalent();
                                foreach (var col in talent)
                                {
                                    if (col.Key == Columns.Name) b.Name = col.Value;
                                    else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                }
                                a.Add(new Types.Talent(b));
                            }
                            character.Talents = a.ToArray();
                        }
                        if (column == Columns.Con_Skill)
                        {
                            var a = new List<Types.Skill>();
                            foreach (var skill in values)
                            {
                                var b = new Types.Wrapper.WSkill();
                                foreach (var col in skill)
                                {
                                    if (col.Key == Columns.Name) b.Name = col.Value;
                                    else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    else if (col.Key == Columns.Level) b.Level = int.Parse(col.Value);
                                }
                                a.Add(new Types.Skill(b));
                            }
                            character.Skills = a.ToArray();
                        }
                        if (column == Columns.Con_stat)
                        {
                            var a = new List<Types.Stat>();
                            foreach (var stat in values)
                            {
                                var b = new Types.Wrapper.WStat();
                                foreach (var col in stat)
                                {
                                    if (col.Key == Columns.Name) b.Name = col.Value;
                                    else if (col.Key == Columns.Con_StartStat) b.Starting = int.Parse(col.Value);
                                    else if (col.Key == Columns.Con_AdvStat) b.Advance = int.Parse(col.Value);
                                    else if (col.Key == Columns.Con_CurrStat) b.Current = int.Parse(col.Value);
                                }
                                a.Add(new Types.Stat(b));
                            }
                            character.Stats = a.ToArray();
                        }
                        if (column == Columns.Con_Item)
                        {
                            var a = new List<Types.Item>();
                            foreach (var item in values)
                            {
                                var b = new Types.Wrapper.WItem();
                                foreach (var col in item)
                                {
                                    if (col.Key == Columns.Id) b.Id = int.Parse(col.Value);
                                    else if (col.Key == Columns.Add_Info) b.AdditionalInfo = col.Value;
                                    else if (col.Key == Columns.Quality) b.Quality = col.Value;
                                    else if (col.Key == Columns.Quantity) b.Quantity = int.Parse(col.Value);
                                }
                                a.Add(new Types.Item(b));
                            }
                            character.Items = a.ToArray();
                        }
                        if (column == Columns.Con_Weapon)
                        {
                            var a = new List<Types.Weapon>();
                            foreach (var weapon in values)
                            {
                                var b = new Types.Wrapper.WWeapon();
                                foreach (var col in weapon)
                                {
                                    if (col.Key == Columns.Name) b.Name = col.Value;
                                    else if (col.Key == Columns.Quality) b.Quality = col.Value;
                                    else if (col.Key == Columns.Quantity) b.Quantity = int.Parse(col.Value);
                                    else if (col.Key == Columns.Con_Equipped) b.Equipped = bool.Parse(col.Value);
                                }
                                a.Add(new Types.Weapon(b));
                            }
                            character.Weapons = a.ToArray();
                        }
                        if (column == Columns.Con_Armor)
                        {
                            var a = new List<Types.Armor>();
                            foreach (var armor in values)
                            {
                                var b = new Types.Wrapper.WArmor();
                                foreach (var col in armor)
                                {
                                    if (col.Key == Columns.Name) b.Name = col.Value;
                                    else if (col.Key == Columns.Quality) b.Quality = col.Value;
                                    else if (col.Key == Columns.Quantity) b.Quantity = int.Parse(col.Value);
                                    else if (col.Key == Columns.Con_Equipped) b.Equipped = bool.Parse(col.Value);
                                }
                                a.Add(new Types.Armor(b));
                            }
                            character.Armor = a.ToArray();
                        }
                        if (column == Columns.Con_Spell)
                        {
                            var a = new List<Types.Spell>();
                            foreach (var car in values)
                            {
                                var b = new Types.Wrapper.WSpell();
                                foreach (var col in car)
                                {
                                    if (col.Key == Columns.Name) b.Name = col.Value;
                                }
                                a.Add(new Types.Spell(b));
                            }
                            character.Spells = a.ToArray();
                        }
                        holdItem = new Types.Character(character);
                    }
                    #endregion
                }
            }
        }
        public void Edit()
        {
            holdItem = viewItem;
        }
        public object ReadColumn(string column)
        {
            if (viewItem != null)
            {
                #region Bogowie
                if (viewItem is Types.God)
                {
                    var god = viewItem as Types.God;
                    if (column == Columns.Name) return god.Name;
                    else if (column == Columns.God_Symbol) return god.Symbol;
                    else if (column == Columns.Desc) return god.Description;
                }
                #endregion
                #region Bronie
                if (viewItem is Types.Weapon)
                {
                    var weapon = viewItem as Types.Weapon;
                    if (column == Columns.Name) return weapon.Name;
                    else if (column == Columns.Weapon_Treats) return weapon.Treats;
                    else if (column == Columns.Desc) return weapon.Description;
                    else if (column == Columns.Availability) return weapon.Availability;
                    else if (column == Columns.Weight) return weapon.Weight;
                    else if (column == Columns.Price) return weapon.Price ;
                    else if (column == Columns.Weapon_Range) return weapon.Range;
                    else if (column == Columns.Weapon_Reload) return weapon.Reload;
                    else if (column == Columns.Weapon_Dmg) return weapon.Damage ;
                    else if (column == Columns.Weapon_Category) return weapon.Category ;
                }
                #endregion
                #region Cechy
                if (viewItem is Types.Stat)
                {
                    var stat = viewItem as Types.Stat;
                    if (column == Columns.Name) return stat.Name;
                    else if (column == Columns.Desc) return stat.Description;
                }
                #endregion
                #region Pancerze
                if (viewItem is Types.Armor)
                {
                    var armor = viewItem as Types.Armor;
                    if (column == Columns.Name) return armor.Name;
                    else if (column == Columns.Desc) return armor.Description;
                    else if (column == Columns.Weight) return armor.Weight;
                    else if (column == Columns.Availability) return armor.Availability;
                    else if (column == Columns.Armor_Cover) return armor.Cover;
                    else if (column == Columns.Armor_Points) return armor.Points;
                }
                #endregion
                #region Profesje
                if (viewItem is Types.Career)
                {
                    var career = viewItem as Types.Career;
                    if (column == Columns.Name) return career.Name ;
                    else if (column == Columns.Career_Type) return career.Type ;
                }
                #endregion
                #region Przedmioty
                if (viewItem is Types.Item)
                {
                    var item = viewItem as Types.Item;
                    if (column == Columns.Name) return item.Name ;
                    else if (column == Columns.Desc) return item.Description ;
                    else if (column == Columns.Availability) return item.Availability ;
                    else if (column == Columns.Weight) return item.Weight ;
                    else if (column == Columns.Price) return item.Price ;
                }
                #endregion
                #region Rasy
                if (viewItem is Types.Race)
                {
                    var race = viewItem as Types.Race;
                    if (column == Columns.Name) return race.Name ;
                    else if (column == Columns.Desc) return race.Description ;
                    else if (column == Columns.Race_History) return race.History ;
                    else if (column == Columns.Race_Tips) return race.Tips ;
                }
                #endregion
                #region Umiejętności
                if (viewItem is Types.Skill)
                {
                    var skill = viewItem as Types.Skill;
                    if (column == Columns.Name) return skill.Name ;
                    else if (column == Columns.Desc) return skill.Description ;
                    else if (column == Columns.Skill_Type) return skill.Type ;
                    else if (column == Columns.Skill_Stat) return skill.Characteristic.Name;
                }
                #endregion
                #region Zaklęcia
                if (viewItem is Types.Spell)
                {
                    var spell = viewItem as Types.Spell;
                    if (column == Columns.Name) return spell.Name ;
                    else if (column == Columns.Desc) return spell.Description ;
                    else if (column == Columns.Spell_MType) return spell.MagicType ;
                    else if (column == Columns.Spell_Lvl) return spell.RequiredLevel;
                    else if (column == Columns.Spell_Cast) return spell.CastTime;
                    else if (column == Columns.Spell_Durat) return spell.Duration;
                    else if (column == Columns.Spell_ReqTal) return spell.RequiredTalent.Name;
                    else if (column == Columns.Con_Item) return spell.SupportingItem.Name;
                    else if (column == Columns.Spell_Bonus) return spell.SupportingItem.Bonus;
                }
                #endregion
                #region Zdolności
                if (viewItem is Types.Talent)
                {
                    var talent = viewItem as Types.Talent;
                    if (column == Columns.Name) return talent.Name ;
                    else if (column == Columns.Desc) return talent.Description ;
                    else if (column == Columns.Con_stat) return talent.Bonus.Name;
                    else if (column == Columns.Value) return talent.Bonus.Advance;
                }
                #endregion
                #region Postaci
                if (viewItem is Types.Character)
                {
                    var character = viewItem as Types.Character;
                    if (column == Columns.Name) return character.Name ;
                    else if (column == Columns.Char_God) return character.WorshipedGod.Name;
                    else if (column == Columns.Con_Race) return character.Race.Name;
                    else if (column == Columns.Con_Career) return character.CurrentCareer.Name;
                    else if (column == Columns.Char_AddInfo) return character.AdditionalInfo ;
                    else if (column == Columns.Char_Gender) return character.Gender ;
                    else if (column == Columns.Char_EyeColor) return character.EyeColor ;
                    else if (column == Columns.Char_HairColor) return character.HairColor ;
                    else if (column == Columns.Char_StarSign) return character.StarSign ;
                    else if (column == Columns.Char_Features) return character.SpecialFeatures ;
                    else if (column == Columns.Char_BirthPlace) return character.BirthPlace ;
                    else if (column == Columns.Char_Family) return character.Family ;
                    else if (column == Columns.Char_MentalCondition) return character.MentalCondition ;
                    else if (column == Columns.Char_Scars) return character.CutsBruises ;
                    else if (column == Columns.Char_History) return character.History ;
                    else if (column == Columns.Char_EXP) return character.Exp;
                    else if (column == Columns.Char_Age) return character.Age;
                    else if (column == Columns.Char_Weight) return character.Weight;
                    else if (column == Columns.Char_Height) return character.Height;
                }
                #endregion
            }
            return null;
        }
        public Dictionary<string,string>[] ReadList(string column)
        {
            if (viewItem != null)
            {
                var a = new List<Dictionary<string, string>>();
                #region Bogowie
                if (viewItem is Types.God)
                {
                    var god = viewItem as Types.God;
                    if (column == Columns.Con_Talent)
                    {
                        if (god.Talents != null)
                            foreach (var talent in god.Talents)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, talent.Name);
                            b.Add(Columns.Add_Info, talent.AdditionalInfo);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Skill)
                    {
                        if (god.Skills != null)
                            foreach (var skill in god.Skills)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, skill.Name);
                            b.Add(Columns.Add_Info, skill.AdditionalInfo);
                            a.Add(b);
                        }
                    }
                }
                #endregion
                #region Profesje
                if (viewItem is Types.Career)
                {
                    var career = viewItem as Types.Career;
                    if (column == Columns.Con_Talent)
                    {
                        if (career.AvailableTalents != null)
                            foreach (var talent in career.AvailableTalents)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, talent.Name);
                            b.Add(Columns.Add_Info, talent.AdditionalInfo);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Skill)
                    {
                        if (career.AvailableSkills != null)
                            foreach (var skill in career.AvailableSkills)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, skill.Name);
                            b.Add(Columns.Add_Info, skill.AdditionalInfo);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_stat)
                    {
                        if (career.StatsScheme != null)
                            foreach (var stat in career.StatsScheme)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, stat.Name);
                            b.Add(Columns.Con_AdvStat, stat.Advance.ToString());
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Item)
                    {
                        if (career.StartEquipment != null)
                            foreach (var item in career.StartEquipment)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Id, item.Id.ToString());
                            b.Add(Columns.Name, item.Name);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Weapon)
                    {
                        if (career.StartWeapons != null)
                            foreach (var weapon in career.StartWeapons)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, weapon.Name);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Armor)
                    {
                        if (career.StartArmor != null)
                            foreach (var armor in career.StartArmor)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, armor.Name);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Career)
                    {
                        if (career.AvailableCareer != null)
                            foreach (var car in career.AvailableCareer)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name, car.Name);
                            a.Add(b);
                        }
                    }
                }
                #endregion
                #region Rasy
                if (viewItem is Types.Race)
                {
                    var race = viewItem as Types.Race;
                    if (column == Columns.Con_Talent)
                    {
                        if(race.StartingTalents != null)
                        foreach (var talent in race.StartingTalents)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,talent.Name);
                            b.Add(Columns.Add_Info,talent.AdditionalInfo);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Skill)
                    {
                        if (race.StartingSkills != null)
                            foreach (var skill in race.StartingSkills)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,skill.Name);
                            b.Add(Columns.Add_Info,skill.AdditionalInfo);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_stat)
                    {
                        if (race.StartingStats != null)
                            foreach (var stat in race.StartingStats)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,stat.Name);
                            b.Add(Columns.Con_StartStat, stat.Starting.ToString());
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Career)
                    {
                        if (race.PossibleCareer != null)
                            foreach (var car in race.PossibleCareer)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,car.Name);
                            a.Add(b);
                        }
                    }
                }
                #endregion
                #region Postaci
                if (viewItem is Types.Character)
                {
                    var character = viewItem as Types.Character;
                    if (column == Columns.Con_Talent)
                    {
                        if (character.Talents != null)
                            foreach (var talent in character.Talents)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,talent.Name);
                            b.Add(Columns.Add_Info,talent.AdditionalInfo);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Skill)
                    {
                        if (character.Skills != null)
                            foreach (var skill in character.Skills)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,skill.Name);
                            b.Add(Columns.Add_Info,skill.AdditionalInfo);
                            b.Add(Columns.Level,skill.Level.ToString());
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_stat)
                    {
                        if (character.Stats != null)
                            foreach (var stat in character.Stats)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,stat.Name);
                            b.Add(Columns.Con_StartStat,stat.Starting.ToString());
                            b.Add(Columns.Con_AdvStat,stat.Advance.ToString());
                            b.Add(Columns.Con_CurrStat,stat.Current.ToString());
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Item)
                    {
                        if (character.Items != null)
                            foreach (var item in character.Items)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Id,item.Id.ToString());
                            b.Add(Columns.Add_Info,item.AdditionalInfo);
                            b.Add(Columns.Quality,item.Quality);
                            b.Add(Columns.Quantity,item.Quantity.ToString());
                            b.Add(Columns.Name, item.Name);
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Weapon)
                    {
                        if (character.Weapons != null)
                            foreach (var weapon in character.Weapons)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,weapon.Name);
                            b.Add(Columns.Quality,weapon.Quality);
                            b.Add(Columns.Quantity,weapon.Quantity.ToString());
                            b.Add(Columns.Con_Equipped,weapon.Equipped.ToString());
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Armor)
                    {
                        if (character.Armor != null)
                            foreach (var armor in character.Armor)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,armor.Name);
                            b.Add(Columns.Quality,armor.Quality);
                            b.Add(Columns.Quantity,armor.Quantity.ToString());
                            b.Add(Columns.Con_Equipped,armor.Equipped.ToString());
                            a.Add(b);
                        }
                    }
                    if (column == Columns.Con_Spell)
                    {
                        if (character.Spells != null)
                            foreach (var car in character.Spells)
                        {
                            var b = new Dictionary<string, string>();
                            b.Add(Columns.Name,car.Name);
                            a.Add(b);
                        }
                    }
                }
                #endregion
                return a.ToArray();
            }
            return null;
        }
    }
}
