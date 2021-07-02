using RareBookApp.Data;
using RareBookApp.Domain;
using RareBookApp.Service.Customer.QueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.Customer.Concrete
{
    public class CustomerService
    {
        private readonly RareBookAppContext _context;

        public CustomerService(RareBookAppContext context)
        {
            _context = context;
        }

        public IQueryable<RareBookApp.Domain.Customer> RetrieveCustomerBasedOnLocation(string city)
        {
            return _context.Customers
                                .FilterCustomerBasedOnLocation(city);
        }
    }
}
