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

    }
}
