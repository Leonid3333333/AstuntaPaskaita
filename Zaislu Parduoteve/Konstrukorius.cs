using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaislu_Parduoteve
{
    public class Constructor : Toy
    {
        public int DetailCount { get; set; }

        public Constructor(string name, string manufacturer, int ageLimit, double price, int detailCount)
            : base(name, manufacturer, ageLimit, price)
        {
            DetailCount = detailCount;
        }
    }
}
