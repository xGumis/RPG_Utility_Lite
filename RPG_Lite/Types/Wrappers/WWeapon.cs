using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types.Wrapper
{
    class WWeapon
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public float Weight { get; set; }
        public string Damage { get; set; }
        public string Availability { get; set; }
        public string Category { get; set; }
        public float Range { get; set; }
        public int Reload { get; set; }
        public string Treats { get; set; }
        public int Quantity { get; set; }
        public string Quality { get; set; }
        public bool Equipped { get; set; }
        public WWeapon()
        {
            this.Name = "";
            this.Description = "";
            this.Price = "";
            this.Weight = 0;
            this.Damage = "";
            this.Availability = "";
            this.Category = "";
            this.Range = 0;
            this.Reload = 0;
            this.Treats = "";
            this.Quantity = 0;
            this.Quality = "";
            this.Equipped = false;
        }
        public WWeapon(Types.Weapon weapon)
        {
            this.Name = weapon.Name;
            this.Description = weapon.Description;
            this.Price = weapon.Price;
            this.Weight = weapon.Weight;
            this.Damage = weapon.Damage;
            this.Availability = weapon.Availability;
            this.Category = weapon.Category;
            this.Range = weapon.Range;
            this.Reload = weapon.Reload;
            this.Treats = weapon.Treats;
            this.Quantity = weapon.Quantity;
            this.Quality = weapon.Quality;
            this.Equipped = weapon.Equipped;
        }
    }
}
