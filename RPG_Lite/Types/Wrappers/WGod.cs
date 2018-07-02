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
    }
}
