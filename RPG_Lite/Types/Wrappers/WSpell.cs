using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WSpell
    {
        public string Name { get; set; }
        public string MagicType { get; set; }
        public int RequiredLevel { get; set; }
        public int CastTime { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Talent RequiredTalent { get; set; }
        public Item SupportingItem { get; set; }
        public WSpell()
        {
            this.Name = "";
            this.MagicType = "";
            this.RequiredLevel = 0;
            this.CastTime = 0;
            this.Duration = 0;
            this.Description = "";
            this.RequiredTalent = new Talent();
            this.SupportingItem = new Item();
        }
        public WSpell(Types.Spell spell)
        {
            this.Name = spell.Name;
            this.MagicType = spell.MagicType;
            this.RequiredLevel = spell.RequiredLevel;
            this.CastTime = spell.CastTime;
            this.Duration = spell.Duration;
            this.Description = spell.Description;
            this.RequiredTalent = spell.RequiredTalent;
            this.SupportingItem = spell.SupportingItem;
        }
    }
}
