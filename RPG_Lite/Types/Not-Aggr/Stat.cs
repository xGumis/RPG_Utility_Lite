using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Stat : AType
    {
        public string Name { get; }
        public string Description { get; }
        public int Starting { get; }
        public int Advance { get; }
        public int Current { get; }
        public Stat(string name, string desc):base(name) { this.Name = name; this.Description = desc; }
        public Stat(string name, string desc, int start):base(name) { this.Name = name; this.Description = desc; this.Starting = start; }
        public Stat(string name, string desc, int start, int adv, int curr):base(name) { this.Name = name; this.Description = desc; this.Starting = start; this.Advance = adv;  this.Current = curr; }
        public Stat(Wrapper.WStat wr) : base(wr.Name)
        {
            this.Name = wr.Name;
            this.Description = wr.Description;
            this.Starting = wr.Starting;
            this.Advance = wr.Advance;
            this.Current = wr.Current;
        }
    }
}
