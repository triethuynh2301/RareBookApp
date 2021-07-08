using RareBookApp.Data;
using RareBookApp.Service;
using RareBookApp.Service.BookServices.Concrete;
using RareBookApp.Service.Customer;
using RareBookApp.Service.SaleService;
using RareBookApp.Service.Customer.Concrete;
using RareBookApp.Service.SaleService.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using RareBookApp.Domain;
using RareBookApp.Service.SaleService.QueryObjects;

namespace RareBookApp.UI
{
    class Program
    {
        private static readonly RareBookAppContext _context = new RareBookAppContext();

        static void Main(string[] args)
        {
            var saleDepartment = new ListSalesOrderDetails(_context);

            var salesOrderDetailsQuery = saleDepartment.SortFilterSalesOrderDetails().ToList();

            foreach (var i in salesOrderDetailsQuery)
            {
                Console.WriteLine($"{i.InventoryId} " +
                    $"{i.ISBN} " +
                    $"{i.DateAcquired} " +
                    $"{i.AskingPrice} " +
                    $"{i.SellingPrice} " +
                    $"{i.SaleId} " +
                    $"{i.SaleDate} " +
                    $"{i.SalesTotalAmount} " +
                    $"{i.CustomerNumber} " +
                    $"{i.CustomerName} " +
                    $"{i.ContactPhone}");
            }

            Console.ReadLine();
        }
    }
}
