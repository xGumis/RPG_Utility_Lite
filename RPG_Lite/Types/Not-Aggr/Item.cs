using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Item : AType
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
        public Item(int id, string name, string desc, string info, string price, string avail, float weight, string quality, int quant):base(id.ToString())
        {
            this.Id = id;
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
        public Item(int id, string name, string desc, string price, string avail, float weight):base(id.ToString())
        {
            this.Id = id;
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Availability = avail;
            this.Weight = weight;
            this.Quantity = 0;
            this.Quality = null;
            this.Bonus = 0;
        }
        public Item(int id, string name, string desc, string price, string avail, float weight, int bonus):base(id.ToString())
        {
            this.Id = id;
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Availability = avail;
            this.Weight = weight;
            this.Bonus = bonus;
            this.Quantity = 0;
            this.Quality = null;
        }
        public Item(Wrapper.WItem wr) : base(wr.Id.ToString())
        {
            this.Id = wr.Id;
            this.Name = wr.Name;
            this.Description = wr.Description;
            this.Price = wr.Price;
            this.Availability = wr.Availability;
            this.Weight = wr.Weight;
            this.Quantity = wr.Quantity;
            this.Quality = wr.Quality;
            this.Bonus = wr.Bonus;
        }
        public Item() : base(null)
        {
            this.Id = -1;
            this.Name = "";
            this.Description = "";
            this.Price = "";
            this.Availability = "";
            this.Weight = 0;
            this.Quantity = 0;
            this.Quality = "";
            this.Bonus = 0;
        }
    }
}
