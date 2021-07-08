using RareBookApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.SaleService.QueryObjects
{
    public static class SalesOrderDetailsDTOSelect
    {
        public static IQueryable<SalesOrderDetailsDTO> SelectSalesOrderDetailsDTO(this IQueryable<Sale> saleOrders)
        {
            return saleOrders.Select(x => new SalesOrderDetailsDTO
            {
                InventoryId = x.Inventory.InventoryID,
                ISBN = x.Inventory.ISBN,
                DateAcquired = x.Inventory.DateAcquired,
                AskingPrice = x.Inventory.AskingPrice,
                SellingPrice = (x.Inventory.SellingPrice == null) ? null : x.Inventory.SellingPrice,
                SaleId = x.SaleID,
                SaleDate = x.SaleDate,
                SalesTotalAmount = x.SalesTotalAmount,
                CustomerNumber = x.Customer.CustomerNumber,
                CustomerName = string.Join(" ", x.Customer.FirstName, x.Customer.LastName),
                ContactPhone = x.Customer.ContactPhone
            }
            );
        }
    }
}
