using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite.Types
{
    class Armor
    {
        public string Name { get; }
        public string Price { get; }
        public float Weight { get; }
        public int Points { get; }
        public string Availability { get; }
        public string Cover { get; }
        public int Quantity { get; }
        public string Quality { get; }
        public Armor(string name, string price, float weight, int points,string avail, string cover, int quant, string quality)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
            this.Points = points;
            this.Availability = avail;
            this.Cover = cover;
            this.Quantity = quant;
            this.Quality = quality;
        }
        public Armor(string name, string price, float weight, int points, string avail, string cover)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
            this.Points = points;
            this.Availability = avail;
            this.Cover = cover;
            this.Quantity = 0;
            this.Quality = null;
        }
    }
}
