using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WRace
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string Tips { get; set; }
        public Stat[] StartingStats { get; set; } 
        public Talent[] StartingTalents { get; set; }
        public Skill[] StartingSkills { get; set; }
        public Career[] PossibleCareer { get; set; }
        public WRace()
        {
            this.Name = "";
            this.Description = "";
            this.History = "";
            this.Tips = "";
            this.StartingStats = null;
            this.StartingTalents = null;
            this.StartingSkills = null;
            this.PossibleCareer = null;
        }
        public WRace(Types.Race race)
        {
            this.Name = race.Name;
            this.Description = race.Description;
            this.History = race.History;
            this.Tips = race.Tips;
            this.StartingStats = race.StartingStats;
            this.StartingTalents = race.StartingTalents;
            this.StartingSkills = race.StartingSkills;
            this.PossibleCareer = race.PossibleCareer;
        }
    }
}
