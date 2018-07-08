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
        public WItem()
        {
            this.Id = -1;
            this.Name = "";
            this.Description = "";
            this.AdditionalInfo = "";
            this.Price = "";
            this.Availability = "";
            this.Weight = 0;
            this.Quality = "";
            this.Quantity = 0;
            this.Bonus = 0;
        }
        public WItem(Types.Item item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Description = item.Description;
            this.AdditionalInfo = item.AdditionalInfo;
            this.Price = item.Price;
            this.Availability = item.Availability;
            this.Weight = item.Weight;
            this.Quality = item.Quality;
            this.Quantity = item.Quantity;
            this.Bonus = item.Bonus;
        }
    }
}
