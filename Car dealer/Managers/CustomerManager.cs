using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealerDataLayer.DAL;
using CarDealerDataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_dealer
{
    public class CustomerManager
    {
        private readonly CarDealerDBContext context;
        public CustomerManager(CarDealerDBContext dbContext)
        {
            context = dbContext;
        }

        public List<Customer> GetCustomersByName(string name)
        {
            List<Customer> customers = new List<Customer>();
            var dbCustomers = context.Customers
                .Where(c => c.Name == name)
                .Include(c => c.Address);

            if (dbCustomers.Any())
            {
                customers = dbCustomers.ToList();
            }

            return customers;
        }

        public List<Customer> GetCustomersByStreetName(string streetName)
        {
            List<Customer> customers = new List<Customer>();
            var dbCustomers = context.Customers
                .Where(c => c.Address.Street == streetName)
                .Include(c => c.Address);

            if (dbCustomers.Any())
            {
                customers = dbCustomers.ToList();
            }

            return customers;
        }

        public List<Customer> GetCustomersByCarMake(string carMake)
        {
            List<Customer> customers = new List<Customer>();
            var dbCustomers = context.CarPurchases
                .Where(c => c.Car.Make == carMake)
                .Include(c => c.Customer)
                .ThenInclude(c => c.Address)
                .Select(c => c.Customer);

            if (dbCustomers.Any())
            {
                customers = dbCustomers.ToList();
            }

            return customers;
        }

        public List<Customer> GetCustomersByCarModel(string carModel)
        {
            List<Customer> customers = new List<Customer>();
            var dbCustomers = context.CarPurchases
                .Where(c => c.Car.Model == carModel)
                .Include(c => c.Customer)
                .ThenInclude(c => c.Address)
                .Select(c => c.Customer);

            if (dbCustomers.Any())
            {
                customers = dbCustomers.ToList();
            }

            return customers;
        }

        public List<Customer> GetCustomersBySalesPersonName(string SalesPersonName)
        {
            List<Customer> customers = new List<Customer>();
            var dbCustomers = context.CarPurchases
                .Where(c => c.SalesPerson.Name == SalesPersonName)
                .Include(c => c.Customer)
                .ThenInclude(c => c.Address)
                .Select(c => c.Customer);

            if (dbCustomers.Any())
            {
                customers = dbCustomers.ToList();
            }

            return customers;
        }
    }
}
