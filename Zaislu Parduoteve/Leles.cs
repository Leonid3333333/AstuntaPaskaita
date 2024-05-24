using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaislu_Parduoteve
{
    public class Puppet : Toy
    {
        public HairstyleType Hairstyle { get; set; }

        public Puppet(string name, string manufacturer, int ageLimit, double price, HairstyleType hairstyle)
            : base(name, manufacturer, ageLimit, price)
        {
            Hairstyle = hairstyle;
        }
    }
}
