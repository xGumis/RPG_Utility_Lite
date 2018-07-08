using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WStat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Starting { get; set; }
        public int Advance { get; set; }
        public int Current { get; set; }
        public WStat()
        {
            this.Name = "";
            this.Description = "";
            this.Starting = 0;
            this.Advance = 0;
            this.Current = 0;
        }
        public WStat(Types.Stat stat)
        {
            this.Name = stat.Name;
            this.Description = stat.Description;
            this.Starting = stat.Starting;
            this.Advance = stat.Advance;
            this.Current = stat.Current;
        }
    }
}
