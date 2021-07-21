using RareBookApp.Service.SaleService.QueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.SaleService
{
    public class SortFilterPageOptions
    {
        public FilterOptions filterOptions { get; set; }
        public SalesSortOptions sortOptions { get; set; }
        
    }
}
