using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Career : AType
    {
        public string Name { get; }
        public string Type { get; }
        public Stat[] StatsScheme { get; }
        public Skill[] AvailableSkills { get; }
        public Talent[] AvailableTalents { get; }
        public Weapon[] StartWeapons { get; }
        public Armor[] StartArmor { get; }
        public Item[] StartEquipment { get; }
        public Career[] AvailableCareer { get; }
        public Career(string name, string type, Stat[] stats, Skill[] skills, Talent[] talents, Weapon[] weapons, Armor[] armor, Item[] eq, Career[] careers):base(name)
        {
            this.Name = name;
            this.Type = type;
            this.StatsScheme = stats;
            this.AvailableSkills = skills;
            this.AvailableTalents = talents;
            this.StartWeapons = weapons;
            this.StartArmor = armor;
            this.StartEquipment = eq;
            this.AvailableCareer = careers;
        }
        public Career(string name, string type):base(name)
        {
            this.Name = name;
            this.Type = type;
            this.StatsScheme = null;
            this.AvailableSkills = null;
            this.AvailableTalents = null;
            this.StartWeapons = null;
            this.StartArmor = null;
            this.StartEquipment = null;
            this.AvailableCareer = null;
        }
        public Career(Wrapper.WCareer wr):base(wr.Name)
        {
            this.Name = wr.Name;
            this.Type = wr.Type;
            this.StatsScheme = wr.StatsScheme;
            this.AvailableSkills = wr.AvailableSkills;
            this.AvailableTalents = wr.AvailableTalents;
            this.StartWeapons = wr.StartWeapons;
            this.StartArmor = wr.StartArmor;
            this.StartEquipment = wr.StartEquipment;
            this.AvailableCareer = wr.AvailableCareer;
        }
        public Career():base(null)
        {
            this.Name = "";
            this.Type = "";
            this.StatsScheme = null;
            this.AvailableSkills = null;
            this.AvailableTalents = null;
            this.StartWeapons = null;
            this.StartArmor = null;
            this.StartEquipment = null;
            this.AvailableCareer = null;
        }
    }
}
