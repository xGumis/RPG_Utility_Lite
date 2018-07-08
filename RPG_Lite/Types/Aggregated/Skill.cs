using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Skill : AType
    {
        public string Name { get; }
        public string Type { get; }
        public string Description { get; }
        public int Level { get; }
        public string AdditionalInfo { get; }
        public Stat Characteristic { get; }
        public Skill(string name, string type, string desc, Stat charac) : base(name)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Level = 0;
            this.AdditionalInfo = null;
            this.Characteristic = charac;
        }
        public Skill(string name, string type, string desc, Stat charac, int level, string info) : base(name)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Level = level;
            this.AdditionalInfo = info;
            this.Characteristic = charac;
        }
        public Skill(string name, string type, string desc, Stat charac, string info) : base(name)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Level = 0;
            this.AdditionalInfo = info;
            this.Characteristic = charac;
        }
        public Skill(Wrapper.WSkill wr) : base(wr.Name)
        {
            this.Name = wr.Name;
            this.Type = wr.Type;
            this.Description = wr.Description;
            this.Level = wr.Level;
            this.AdditionalInfo = wr.AdditionalInfo;
            this.Characteristic = wr.Characteristic;
        }
        public Skill() : base(null)
        {
            this.Name = "";
            this.Type = "";
            this.Description = "";
            this.Level = 0;
            this.AdditionalInfo = "";
            this.Characteristic = new Stat();
        }
    }
}
