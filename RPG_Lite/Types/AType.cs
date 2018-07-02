using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    abstract class AType
    {
        public string Key { get; }
        public AType(string key) { this.Key = key; }
    }
}
