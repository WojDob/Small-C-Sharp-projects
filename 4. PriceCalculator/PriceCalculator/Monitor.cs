using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
    class Monitor
    {
        public Monitor(int price, int diameter, string brand)
        {
            Price = price;
            Diameter = diameter;
            Brand = brand;
        }

        public int Price { get; set; }
        public int Diameter { get; set; }
        public string Brand { get; set; }
    }
}
