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
        public int Exp { get; set; }
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
        public WCharacter()
        {
            this.Id = -1;
            this.Name = "";
            this.Age = 0;
            this.Weight = 0;
            this.Height = 0;
            this.Exp = 0;
            this.BirthPlace = "";
            this.Gender = "";
            this.EyeColor = "";
            this.HairColor = "";
            this.StarSign = "";
            this.SpecialFeatures = "";
            this.CutsBruises = "";
            this.Family = "";
            this.History = "";
            this.AdditionalInfo = "";
            this.MentalCondition = "";
            this.Race = new Race();
            this.CurrentCareer = new Career();
            this.WorshipedGod = new God();
            this.Stats = null;
            this.Talents = null;
            this.Skills = null;
            this.Spells = null;
            this.Weapons = null;
            this.Armor = null;
            this.Items = null;
        }
        public WCharacter(Types.Character character)
        {
            this.Id = character.Id;
            this.Name = character.Name;
            this.Age = character.Age;
            this.Weight = character.Weight;
            this.Height = character.Height;
            this.Exp = character.Exp;
            this.BirthPlace = character.BirthPlace;
            this.Gender = character.Gender;
            this.EyeColor = character.EyeColor;
            this.HairColor = character.HairColor;
            this.StarSign = character.StarSign;
            this.SpecialFeatures = character.SpecialFeatures;
            this.CutsBruises = character.CutsBruises;
            this.Family = character.Family;
            this.History = character.History;
            this.AdditionalInfo = character.AdditionalInfo;
            this.MentalCondition = character.MentalCondition;
            this.Race = character.Race;
            this.CurrentCareer = character.CurrentCareer;
            this.WorshipedGod = character.WorshipedGod;
            this.Stats = character.Stats;
            this.Talents = character.Talents;
            this.Skills = character.Skills;
            this.Spells = character.Spells;
            this.Weapons = character.Weapons;
            this.Armor = character.Armor;
            this.Items = character.Items;
        }
    }
}
