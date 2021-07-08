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
    public class ListSalesOrderDetails
    {
        private readonly RareBookAppContext _context;

        public ListSalesOrderDetails(RareBookAppContext context)
        {
            _context = context;
        }

        public IQueryable<SalesOrderDetailsDTO> SortFilterSalesOrderDetails()
        {
            var salesOrderDetailsQuery = _context.Sales.SelectSalesOrderDetailsDTO();
            return salesOrderDetailsQuery;
        }
    }
}
