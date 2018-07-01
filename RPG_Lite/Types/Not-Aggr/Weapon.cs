using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Weapon
    {
        public string Name { get; }
        public string Description { get; }
        public string Price { get; }
        public float Weight { get; }
        public string Damage { get; }
        public string Availability { get; }
        public string Category { get; }
        public float Range { get; }
        public int Reload { get; }
        public string Treats { get; }
        public int Quantity { get; }
        public string Quality { get; }
        public Weapon(string name, string desc, string price, float weight,string dmg, int reload, float range, string treat, string avail, string cat, int quant, string quality)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Weight = weight;
            this.Damage = dmg;
            this.Reload = reload;
            this.Range = range;
            this.Availability = avail;
            this.Treats = treat;
            this.Category = cat;
            this.Quantity = quant;
            this.Quality = quality;
        }
        public Weapon(string name, string desc, string price, float weight, string dmg, int reload, float range, string treat, string avail, string cat)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Weight = weight;
            this.Damage = dmg;
            this.Reload = reload;
            this.Range = range;
            this.Availability = avail;
            this.Treats = treat;
            this.Category = cat;
            this.Quantity = 0;
            this.Quality = null;
        }
    }
}
