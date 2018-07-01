using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Talent
    {
        public string Name { get; }
        public string Description { get; }
        public Stat Bonus { get; }
        public Talent(string name, string desc)
        {
            this.Name = name;
            this.Description = desc;
            this.Bonus = null;
        }
        public Talent(string name, string desc, Stat bonus)
        {
            this.Name = name;
            this.Description = desc;
            this.Bonus = bonus;
        }
    }
}
