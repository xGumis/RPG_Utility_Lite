using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WTalent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AdditionalInfo { get; set; }
        public Stat Bonus { get; set; }
        public WTalent()
        {
            this.Name = "";
            this.Description = "";
            this.AdditionalInfo = "";
            this.Bonus = new Stat();
        }
        public WTalent(Types.Talent talent)
        {
            this.Name = talent.Name;
            this.Description = talent.Description;
            this.AdditionalInfo = talent.AdditionalInfo;
            this.Bonus = talent.Bonus;
        }
    }
}
