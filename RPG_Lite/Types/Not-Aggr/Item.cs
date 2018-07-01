using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Item
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string AdditionalInfo { get; }
        public string Price { get; }
        public string Availability { get; }
        public float Weight { get; }
        public string Quality { get; }
        public int Quantity { get; }
        public int Bonus { get; }
        public Item(string name, string desc, string info, string price, string avail, float weight, string quality, int quant)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.AdditionalInfo = info;
            this.Availability = avail;
            this.Weight = weight;
            this.Quantity = quant;
            this.Quality = quality;
            this.Bonus = 0;
        }
        public Item(string name, string desc, string price, string avail, float weight)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Availability = avail;
            this.Weight = weight;
            this.Quantity = 0;
            this.Quality = null;
            this.Bonus = 0;
        }
        public Item(string name, string desc, string price, string avail, float weight, int bonus)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Availability = avail;
            this.Weight = weight;
            this.Bonus = bonus;
            this.Quantity = 0;
            this.Quality = null;
        }

    }
}
