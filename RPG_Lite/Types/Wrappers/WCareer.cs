using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WCareer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Stat[] StatsScheme { get; set; }
        public Skill[] AvailableSkills { get; set; }
        public Talent[] AvailableTalents { get; set; }
        public Weapon[] StartWeapons { get; set; }
        public Armor[] StartArmor { get; set; }
        public Item[] StartEquipment { get; set; }
        public Career[] AvailableCareer { get; set; }
        public WCareer()
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
        public WCareer(Types.Career career)
        {
            this.Name = career.Name;
            this.Type = career.Type;
            this.StatsScheme = career.StatsScheme;
            this.AvailableSkills = career.AvailableSkills;
            this.AvailableTalents = career.AvailableTalents;
            this.StartWeapons = career.StartWeapons;
            this.StartArmor = career.StartArmor;
            this.StartEquipment = career.StartEquipment;
            this.AvailableCareer = career.AvailableCareer;
        }
    }
}
