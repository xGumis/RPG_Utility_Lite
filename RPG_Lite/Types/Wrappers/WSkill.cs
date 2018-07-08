using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WSkill
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public string AdditionalInfo { get; set; }
        public Stat Characteristic { get; set; }
        public WSkill()
        {
            this.Name = "";
            this.Type = "";
            this.Description = "";
            this.Level = 0;
            this.AdditionalInfo = "";
            this.Characteristic = new Stat();
        }
        public WSkill(Types.Skill skill)
        {
            this.Name = skill.Name;
            this.Type = skill.Type;
            this.Description = skill.Description;
            this.Level = skill.Level;
            this.AdditionalInfo = skill.AdditionalInfo;
            this.Characteristic = skill.Characteristic;
        }
    }
}
