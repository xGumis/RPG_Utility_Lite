using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Weapon : AType
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
        public bool Equipped { get; }
        public Weapon(string name, string desc, string price, float weight,string dmg, int reload, float range, string treat, string avail, string cat, int quant, string quality):base(name)
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
        public Weapon(string name, string desc, string price, float weight, string dmg, int reload, float range, string treat, string avail, string cat):base(name)
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
        public Weapon(Wrapper.WWeapon wr) : base(wr.Name)
        {
            this.Name = wr.Name;
            this.Description = wr.Description;
            this.Price = wr.Price;
            this.Weight = wr.Weight;
            this.Damage = wr.Damage;
            this.Reload = wr.Reload;
            this.Range = wr.Range;
            this.Equipped = wr.Equipped;
            this.Availability = wr.Availability;
            this.Treats = wr.Treats;
            this.Category = wr.Category;
            this.Quantity = wr.Quantity;
            this.Quality = wr.Quality;
        }
        public Weapon() : base(null)
        {
            this.Name = "";
            this.Description = "";
            this.Price = "";
            this.Weight = 0;
            this.Damage = "";
            this.Reload = 0;
            this.Range = 0;
            this.Equipped = false;
            this.Availability = "";
            this.Treats = "";
            this.Category = "";
            this.Quantity = 0;
            this.Quality = "";
        }
    }
}
