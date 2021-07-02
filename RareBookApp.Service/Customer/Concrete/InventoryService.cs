using RareBookApp.Data;
using RareBookApp.Domain;
using RareBookApp.Service.Customer.QueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Service.Customer.Concrete
{
    public class InventoryService
    {
        private readonly RareBookAppContext _context;

        public InventoryService(RareBookAppContext context)
        {
            _context = context;
        }

        public IQueryable<Volume> RetrieveInventory(int conditionCode, decimal askingPrice)
        {
            var inventoryQuery = _context.Inventory
                                            .FilterInventoryOnCondition(conditionCode)
                                            .FilterInventoryOnAskingPrice(askingPrice);
            return inventoryQuery;
        }
    }
}
