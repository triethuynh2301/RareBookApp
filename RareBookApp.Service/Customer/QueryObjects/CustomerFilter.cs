using System;
using RareBookApp.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.Customer.QueryObjects
{
    /// <summary>
    /// This class contains extension methods for Customer to filter
    /// customer data
    /// </summary>
    public static class CustomerFilter
    {
        public static IQueryable<RareBookApp.Domain.Customer> FilterCustomerBasedOnLocation(this IQueryable<RareBookApp.Domain.Customer> customers, string city)
        {
            return customers.Where(x => x.City.Contains(city));
        }
    }
}
