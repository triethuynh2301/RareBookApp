using RareBookApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.BookServices.QueryObjects
{
    /// <summary>
    /// This class contains an extension method for Customer class
    /// </summary>
    public static class CustomerContactDTOSelect
    {
        public static IQueryable<CustomerContactDTO> SelectCustomerDTO(this IQueryable<RareBookApp.Domain.Customer> customers)
        {
            return customers.Select(x => new CustomerContactDTO
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                ContactPhone = x.ContactPhone
            });
        }
    }
}
