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
    }
}
