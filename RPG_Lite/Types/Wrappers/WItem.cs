using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AdditionalInfo { get; set; }
        public string Price { get; set; }
        public string Availability { get; set; }
        public float Weight { get; set; }
        public string Quality { get; set; }
        public int Quantity { get; set; }
        public int Bonus { get; set; }

    }
}
