using Microsoft.EntityFrameworkCore;
using RareBookApp.Service.BookServices.QueryObjects;
using RareBookApp.Service.Customer.QueryObjects;
using RareBookApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.BookServices.Concrete
{
    public class ListCustomerContactService
    {
        private readonly RareBookAppContext _context;

        public ListCustomerContactService(RareBookAppContext context)
        {
            _context = context;
        }

        public IQueryable<CustomerContactDTO> RetrieveCustomerContact()
        {
            var customerContactQuery = _context.Customers
                                                    .SelectCustomerDTO();

            return customerContactQuery;
        }

        public IQueryable<CustomerContactDTO> RetrieveCustomerContactAndSort(OrderByOptions orderByOptions)
        {
            var customerContactQuery = _context.Customers
                                                    .SelectCustomerDTO()
                                                    .SortCustomerDTO(orderByOptions);

            return customerContactQuery;
        }
    }
}
