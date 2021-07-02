using RareBookApp.Data;
using RareBookApp.Domain;
using RareBookApp.Service.Sale_Service.QueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.Sale_Service.Concrete
{
    public class SaleService
    {
        private readonly RareBookAppContext _context;

        public SaleService(RareBookAppContext context)
        {
            _context = context;
        }

        public IQueryable<Sale> RetrieveSaleInfoOnCustomerPhoneNum(string customerPhoneNum)
        {
            return _context.Sales
                            .FilterSalesByCustomerPhone(customerPhoneNum);
        }
    }
}
