using RareBookApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.SaleService.QueryObjects
{
    public enum SalesSortOptions
    {
        BySaleId = 0,
        ByCustomerNumber,
        BySaleDate,
        BySaleTotalAmount
    }
    public static class SalesSort
    {
        public static IQueryable<Sale> SortSalesBy(this IQueryable<Sale> sales, SalesSortOptions option)
        {
            switch (option)
            {
                case SalesSortOptions.BySaleId:
                    return sales.OrderBy(x => x.SaleID);
                case SalesSortOptions.ByCustomerNumber:
                    return sales.OrderBy(x => x.CustomerNumber);
                case SalesSortOptions.BySaleDate:
                    return sales.OrderBy(x => x.SaleDate);
                case SalesSortOptions.BySaleTotalAmount:
                    return sales.OrderBy(x => x.SalesTotalAmount);
                default:
                    throw new ArgumentOutOfRangeException(nameof (option), option, null);
            }
        }
    }
}
