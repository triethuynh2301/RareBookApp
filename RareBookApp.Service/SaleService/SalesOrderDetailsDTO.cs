using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.SaleService
{
    public class SalesOrderDetailsDTO
    {
        public int InventoryId { get; set; }
        public string ISBN { get; set; }
        public DateTime DateAcquired { get; set; }
        public decimal AskingPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SalesTotalAmount { get; set; }
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string ContactPhone { get; set; }
    }
}
