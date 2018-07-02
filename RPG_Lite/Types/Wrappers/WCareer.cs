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
    }
}
