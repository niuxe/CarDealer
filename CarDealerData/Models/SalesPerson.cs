using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerDataLayer.Models
{
    public class SalesPerson
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string JobTitle { get; set; }
        public Address Address { get; set; }
        public double Salary { get; set; }
        
    }
}
