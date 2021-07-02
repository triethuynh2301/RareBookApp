using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RareBookApp.Data;
using RareBookApp.Domain;

namespace RareBookApp.Service.Customer.QueryObjects
{
    /// <summary>
    /// This class contains extension methods for Volume POCOs
    /// to filter Inventory table
    /// </summary>
    public static class InventoryFilter
    {
        public static IQueryable<Volume> FilterInventoryOnCondition(this IQueryable<Volume> inventory, int conditionCode)
        {
            return inventory.Where(x => x.ConditionCode == conditionCode);
        }

        public static IQueryable<Volume> FilterInventoryOnAskingPrice(this IQueryable<Volume> inventory, decimal askingPrice)
        {
            return inventory.Where(x => x.AskingPrice >= askingPrice);
        }
    }
}
