using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaislu_Parduoteve
{
    public class Toy
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int AgeLimit { get; set; }
        public double Price { get; set; }

        public Toy(string name, string manufacturer, int ageLimit, double price)
        {
            Name = name;
            Manufacturer = manufacturer;
            AgeLimit = ageLimit;
            Price = price;
        }
    }
}
