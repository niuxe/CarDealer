using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerDataLayer.Models
{
    public class CarPurchase
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public DateTime OrderDate { get; set; }
        public double PricePaid { get; set; }
        public SalesPerson SalesPerson { get; set; }
    }
}
