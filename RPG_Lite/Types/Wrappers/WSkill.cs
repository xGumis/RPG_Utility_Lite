using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WSkill
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public string AdditionalInfo { get; set; }
        public Stat Characteristic { get; set; }
    }
}
