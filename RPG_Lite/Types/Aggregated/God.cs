using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class God
    {
        public string Name { get; }
        public string Description { get; }
        public System.Drawing.Bitmap Symbol { get; }
        public Talent[] Talents { get; }
        public Skill[] Skills { get; }
        public God(string name, string desc, Talent[] talents, Skill[] skills)
        {
            this.Name = name;
            this.Description = desc;
            this.Talents = talents;
            this.Skills = skills;
        }
    }
}
