using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Armor : AType
    {
        public string Name { get; }
        public string Description { get; }
        public string Price { get; }
        public float Weight { get; }
        public int Points { get; }
        public string Availability { get; }
        public string Cover { get; }
        public int Quantity { get; }
        public string Quality { get; }
        public bool Equipped { get; }
        public Armor(string name, string desc, string price, float weight, int points,string avail, string cover, int quant, string quality):base(name)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Weight = weight;
            this.Points = points;
            this.Availability = avail;
            this.Cover = cover;
            this.Quantity = quant;
            this.Quality = quality;
        }
        public Armor(string name,string desc, string price, float weight, int points, string avail, string cover):base(name)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
            this.Weight = weight;
            this.Points = points;
            this.Availability = avail;
            this.Cover = cover;
            this.Quantity = 0;
            this.Quality = null;
        }
        public Armor(Wrapper.WArmor wr) : base(wr.Name)
        {
            this.Name = wr.Name;
            this.Description = wr.Description;
            this.Price = wr.Price;
            this.Weight = wr.Weight;
            this.Points = wr.Points;
            this.Equipped = wr.Equipped;
            this.Availability = wr.Availability;
            this.Cover = wr.Cover;
            this.Quantity = wr.Quantity;
            this.Quality = wr.Quality;
        }
        public Armor() : base(null)
        {
            this.Name = "";
            this.Description = "";
            this.Price = "";
            this.Weight = 0;
            this.Points = 0;
            this.Equipped = false;
            this.Availability = "";
            this.Cover = "";
            this.Quantity = 0;
            this.Quality = "";
        }
    }
}
