using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerDataLayer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Extras { get; set; }
        public double RecommendedPrice { get; set; }

    }
}
