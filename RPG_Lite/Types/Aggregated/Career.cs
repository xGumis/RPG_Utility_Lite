using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Career
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
        public Career(string name, string type, Stat[] stats, Skill[] skills, Talent[] talents, Weapon[] weapons, Armor[] armor, Item[] eq, Career[] careers)
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
        public Career(string name)
        {
            this.Name = name;
            this.Type = null;
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
