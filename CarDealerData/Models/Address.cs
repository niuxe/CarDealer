using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CarDealerDataLayer.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }

    }
}
