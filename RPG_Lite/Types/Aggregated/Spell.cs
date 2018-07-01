using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Spell
    {
        public string Name { get; }
        public string MagicType { get; }
        public int RequiredLevel { get; }
        public int CastTime { get; }
        public int Duration { get; }
        public string Description { get; }
        public Talent RequiredTalent { get; }
        public Item SupportingItem { get; }
        public Spell(string name, string desc, string type, int level, int cast, int durat, Talent talent, Item item)
        {
            this.Name = name;
            this.Description = desc;
            this.MagicType = type;
            this.RequiredLevel = level;
            this.CastTime = cast;
            this.Duration = durat;
            this.RequiredTalent = talent;
            this.SupportingItem = item;
        }
    }
}
