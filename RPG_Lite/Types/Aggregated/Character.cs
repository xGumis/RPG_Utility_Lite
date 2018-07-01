using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Character
    {
        public int Id { get; }
        public string Name { get; }
        public string Gender { get; }
        public string EyeColor { get; }
        public string HairColor { get; }
        public string StarSign { get; }
        public string SpecialFeatures { get; }
        public string CutsBruises { get; }
        public string Family { get; }
        public string BirthPlace { get; }
        public string History { get; }
        public string AdditionalInfo { get; }
        public string MentalCondition { get; }
        public int Age { get; }
        public float Weight { get; }
        public float Height { get; }
        public Race Race { get; }
        public Career CurrentCareer { get; }
        public God WorshipedGod { get; }
        public Stat[] Stats { get; }
        public Talent[] Talents { get; }
        public Skill[] Skills { get; }
        public Spell[] Spells { get; }
        public Weapon[] Weapons { get; }
        public Armor[] Armor { get; }
        public Item[] Items { get; }
        public Character(string name, string gender, string eye, string hair, string sign, string feat, string cuts,
            string fam, string bplace, string history, string info, string condition, int age, float weight, float height,
            Race race, Career career, God god, Stat[] stats, Talent[] talents, Skill[] skills, Spell[] spells, Weapon[] weapons,
            Armor[] armor, Item[] item)
        {
            this.Name = name;
            this.Gender = gender;
            this.EyeColor = eye;
            this.HairColor = hair;
            this.StarSign = sign;
            this.SpecialFeatures = feat;
            this.CutsBruises = cuts;
            this.Family = fam;
            this.BirthPlace = bplace;
            this.History = history;
            this.AdditionalInfo = info;
            this.MentalCondition = condition;
            this.Age = age;
            this.Weapons = weapons;
            this.Weight = weight;
            this.Height = height;
            this.Race = race;
            this.CurrentCareer = career;
            this.WorshipedGod = god;
            this.Stats = stats;
            this.Talents = talents;
            this.Skills = skills;
            this.Spells = spells;
            this.Armor = armor;
            this.Items = item;
        }
    }
}
