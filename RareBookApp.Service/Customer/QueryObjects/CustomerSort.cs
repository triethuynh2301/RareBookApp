using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.Customer.QueryObjects
{
    /// <summary>
    /// This class contains extension methods to sort Customer in different way
    /// </summary>
    public static class CustomerSort
    {
        /// <summary>
        /// Extension method for Customer to sort customer data by first name
        /// </summary>
        public static IQueryable<RareBookApp.Domain.Customer> SortCustomerByFirstName(this IQueryable<RareBookApp.Domain.Customer> customers)
        {
            return customers.OrderBy(x => x.FirstName);
        }

        /// <summary>
        /// Extension method for Customer to sort customer data by last name
        /// </summary>
        public static IQueryable<RareBookApp.Domain.Customer> SortCustomerByLastName(this IQueryable<RareBookApp.Domain.Customer> customers)
        {
            return customers.OrderBy(x => x.LastName);
        }
    }
}
