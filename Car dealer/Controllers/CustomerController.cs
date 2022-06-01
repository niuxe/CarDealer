using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_dealer.ViewModels;
using CarDealerDataLayer.DAL;
using CarDealerDataLayer.Models;

namespace Car_dealer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerManager _manager;

        public CustomerController(CarDealerDBContext dbContext)
        {
            this._manager = new CustomerManager(dbContext);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCustomer(CustomerSubmitForm customer)
        {
            List<Customer> customers = new List<Customer>();

            if(customer.Name != null) customers.AddRange(_manager.GetCustomersByName(customer.Name));
            if (customer.Street != null) customers.AddRange(_manager.GetCustomersByStreetName(customer.Street));
            if (customer.Make != null) customers.AddRange(_manager.GetCustomersByCarMake(customer.Make));
            if (customer.Model != null) customers.AddRange(_manager.GetCustomersByCarModel(customer.Model));
            if (customer.SalePersonsName != null) customers.AddRange(_manager.GetCustomersBySalesPersonName(customer.SalePersonsName));


            return View(customers.Distinct().ToList());
        }
    }
}
