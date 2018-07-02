using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Talent : AType
    {
        public string Name { get; }
        public string Description { get; }
        public Stat Bonus { get; }
        public Talent(string name, string desc):base(name)
        {
            this.Name = name;
            this.Description = desc;
            this.Bonus = null;
        }
        public Talent(string name, string desc, Stat bonus):base(name)
        {
            this.Name = name;
            this.Description = desc;
            this.Bonus = bonus;
        }
        public Talent(Wrapper.WTalent wr) : base(wr.Name)
        {
            this.Name = wr.Name;
            this.Description = wr.Description;
            this.Bonus = wr.Bonus;
        }
    }
}
