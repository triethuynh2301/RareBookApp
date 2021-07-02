using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.Customer.QueryObjects
{
    public enum OrderByOptions
    {
        FirstName,
        LastName
    }
    public static class CustomerContactDTOSort
    {
        public static IQueryable<CustomerContactDTO> SortCustomerDTO(this IQueryable<CustomerContactDTO> customerContacts, OrderByOptions options)
        {
            switch (options)
            {
                case OrderByOptions.FirstName:
                    return customerContacts.OrderBy(x => x.FirstName);
                case OrderByOptions.LastName:
                    return customerContacts.OrderBy(x => x.LastName);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
