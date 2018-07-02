using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string StarSign { get; set; }
        public string SpecialFeatures { get; set; }
        public string CutsBruises { get; set; }
        public string Family { get; set; }
        public string BirthPlace { get; set; }
        public string History { get; set; }
        public string AdditionalInfo { get; set; }
        public string MentalCondition { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public Race Race { get; set; }
        public Career CurrentCareer { get; set; }
        public God WorshipedGod { get; set; }
        public Stat[] Stats { get; set; }
        public Talent[] Talents { get; set; }
        public Skill[] Skills { get; set; }
        public Spell[] Spells { get; set; }
        public Weapon[] Weapons { get; set; }
        public Armor[] Armor { get; set; }
        public Item[] Items { get; set; }
    }
}
