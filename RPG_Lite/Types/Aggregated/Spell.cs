using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Spell : AType
    {
        public string Name { get; }
        public string MagicType { get; }
        public int RequiredLevel { get; }
        public int CastTime { get; }
        public int Duration { get; }
        public string Description { get; }
        public Talent RequiredTalent { get; }
        public Item SupportingItem { get; }
        public Spell(string name, string desc, string type, int level, int cast, int durat, Talent talent, Item item):base(name)
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
        public Spell(Wrapper.WSpell wr) : base(wr.Name)
        {
            this.Name = wr.Name;
            this.Description = wr.Description;
            this.MagicType = wr.MagicType;
            this.RequiredLevel = wr.RequiredLevel;
            this.CastTime = wr.CastTime;
            this.Duration = wr.Duration;
            this.RequiredTalent = wr.RequiredTalent;
            this.SupportingItem = wr.SupportingItem;
        }
        public Spell() : base(null)
        {
            this.Name = "";
            this.Description = "";
            this.MagicType = "";
            this.RequiredLevel = 0;
            this.CastTime = 0;
            this.Duration = 0;
            this.RequiredTalent = new Talent();
            this.SupportingItem = new Item();
        }
    }
}
