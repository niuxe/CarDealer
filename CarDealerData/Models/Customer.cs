using System;
using CarDealerDataLayer;

namespace CarDealerDataLayer.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }

    }
}