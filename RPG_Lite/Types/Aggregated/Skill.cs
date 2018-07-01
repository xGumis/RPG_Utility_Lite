using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Skill
    {
        public string Name { get; }
        public string Type { get; }
        public string Description { get; }
        public int Level { get; }
        public string AdditionalInfo { get; }
        public Stat Characteristic { get; }
        public Skill(string name, string type, string desc, Stat charac)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Level = 0;
            this.AdditionalInfo = null;
            this.Characteristic = charac;
        }
        public Skill(string name, string type, string desc, Stat charac, int level, string info)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Level = level;
            this.AdditionalInfo = info;
            this.Characteristic = charac;
        }
        public Skill(string name, string type, string desc, Stat charac, string info)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Level = 0;
            this.AdditionalInfo = info;
            this.Characteristic = charac;
        }
    }
}
