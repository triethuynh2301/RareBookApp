using RareBookApp.Data;
using RareBookApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.SaleService.QueryObjects
{
    public enum FilterOptions
    {
        BySaleId,
        ByCustomerNum,
        BySalesTotalAmount,
        BySaleDate
    }
    public static class SalesFilter
    {
        public static IQueryable<Sale> FilterSalesBy(this IQueryable<Sale> sales, FilterOptions option, string filterValue)
        {
            // If the filterValue is empty, then there will be no change
            if (string.IsNullOrEmpty(filterValue))
                return sales;

            switch (option)
            {
                case FilterOptions.BySaleId:
                    return sales.Where(x => x.SaleID == int.Parse(filterValue));
                case FilterOptions.ByCustomerNum:
                    return sales.Where(x => x.CustomerNumber == int.Parse(filterValue));
                case FilterOptions.BySalesTotalAmount:
                    return sales.Where(x => x.SalesTotalAmount >= decimal.Parse(filterValue));
                case FilterOptions.BySaleDate:
                    return sales.Where(x => x.SaleDate == DateTime.Parse(filterValue));
                default:
                    throw new ArgumentOutOfRangeException(nameof(option), option, null);
            }
        }
        //public static IQueryable<Sale> FilterSalesByDate(this IQueryable<Sale> sales, DateTime fromDate, DateTime toDate)
        //{
        //    return sales.Where(x => x.SaleDate.CompareTo(fromDate) >= 0 &&
        //                            x.SaleDate.CompareTo(toDate) <= 0);
        //}

        //public static IQueryable<Sale> FilterSalesByCustomerPhone(this IQueryable<Sale> sales, string customerPhoneNum)
        //{
        //    return sales.Where(x => x.Customer.ContactPhone == customerPhoneNum);
        //}
    }
}
