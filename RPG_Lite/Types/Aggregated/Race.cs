using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Race : AType
    {
        public string Name { get; }
        public string Description { get; }
        public string History { get; }
        public string Tips { get; }
        public Stat[] StartingStats { get; } 
        public Talent[] StartingTalents { get; }
        public Skill[] StartingSkills { get; }
        public Career[] PossibleCareer { get; }
        public Race(string name, string desc, string history, string tips, Stat[] stats, Talent[] talents, Skill[] skills, Career[] careers):base(name)
        {
            this.Name = name;
            this.Description = desc;
            this.History = history;
            this.Tips = tips;
            this.StartingTalents = talents;
            this.StartingStats = stats;
            this.StartingSkills = skills;
            this.PossibleCareer = careers;
        }
        public Race(Wrapper.WRace wr) : base(wr.Name)
        {
            this.Name = wr.Name;
            this.Description = wr.Description;
            this.History = wr.History;
            this.Tips = wr.Tips;
            this.StartingTalents = wr.StartingTalents;
            this.StartingStats = wr.StartingStats;
            this.StartingSkills = wr.StartingSkills;
            this.PossibleCareer = wr.PossibleCareer;
        }
    }
}
