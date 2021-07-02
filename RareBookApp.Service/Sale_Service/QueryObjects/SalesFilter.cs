using RareBookApp.Data;
using RareBookApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.Sale_Service.QueryObjects
{
    public static class SalesFilter
    {
        public static IQueryable<Sale> FilterSalesByDate(this IQueryable<Sale> sales, DateTime fromDate, DateTime toDate)
        {
            return sales.Where(x => x.SaleDate.CompareTo(fromDate) >= 0 &&
                                    x.SaleDate.CompareTo(toDate) <= 0);
        }

        public static IQueryable<Sale> FilterSalesByCustomerPhone(this IQueryable<Sale> sales, string customerPhoneNum)
        {
            return sales.Where(x => x.Customer.ContactPhone == customerPhoneNum);
        }
    }
}
