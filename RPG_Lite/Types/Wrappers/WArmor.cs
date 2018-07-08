using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WArmor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public float Weight { get; set; }
        public int Points { get; set; }
        public string Availability { get; set; }
        public string Cover { get; set; }
        public int Quantity { get; set; }
        public string Quality { get; set; }
        public bool Equipped { get; set; }
        public WArmor(Types.Armor armor)
        {
            this.Name = armor.Name;
            this.Description = armor.Description;
            this.Price = armor.Price;
            this.Weight = armor.Weight;
            this.Points = armor.Points;
            this.Availability = armor.Availability;
            this.Cover = armor.Cover;
            this.Quantity = armor.Quantity;
            this.Quality = armor.Quality;
            this.Equipped = armor.Equipped;
        }
        public WArmor()
        {
            this.Name = "";
            this.Description = "";
            this.Price = "";
            this.Weight = 0;
            this.Points = 0;
            this.Availability = "";
            this.Cover = "";
            this.Quantity = 0;
            this.Quality = "";
            this.Equipped = false;
        }
    }
}
