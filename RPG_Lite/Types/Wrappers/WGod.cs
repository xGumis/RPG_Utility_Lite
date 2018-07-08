using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WGod
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public System.Drawing.Bitmap Symbol { get; set; }
        public Talent[] Talents { get; set; }
        public Skill[] Skills { get; set; }
        public WGod()
        {
            this.Name = "";
            this.Description = "";
            this.Symbol = null;
            this.Talents = null;
            this.Skills = null;
        }
        public WGod(Types.God god)
        {
            this.Name = god.Name;
            this.Description = god.Description;
            this.Symbol = god.Symbol;
            this.Talents = god.Talents;
            this.Skills = god.Skills;
        }
    }
}
