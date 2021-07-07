using RareBookApp.Data;
using RareBookApp.Domain;
using RareBookApp.Service.SaleService.QueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.SaleService.Concrete
{
    public class SaleService
    {
        private readonly RareBookAppContext _context;

        public SaleService(RareBookAppContext context)
        {
            _context = context;
        }

        public IQueryable<Sale> SalesSortFilter(SaleSortFilterPageOptions options, string filterValue)
        {
            var salesQuery = _context.Sales
                                .FilterSalesBy(options.filterOptions, filterValue)
                                .SortSalesBy(options.sortOptions);
                                
            return salesQuery;
        }

        //public IQueryable<Sale> RetrieveSaleInfoOnCustomerPhoneNum(string customerPhoneNum)
        //{
        //    return _context.Sales
        //                    .FilterSalesByCustomerPhone(customerPhoneNum);
        //}
    }
}
