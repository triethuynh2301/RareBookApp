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
            var saleDepartment = new SaleService(_context);
            var filterSortOptions = new SaleSortFilterPageOptions();
            filterSortOptions.filterOptions = SalesFilterOptions.BySalesTotalAmount;
            filterSortOptions.sortOptions = SalesSortOptions.BySaleDate;

            var salesOver100Dollars = saleDepartment
                            .SalesSortFilter(filterSortOptions, "100")
                            .ToList();

            Console.WriteLine("Sale order worth over $100:");
            foreach (var i in salesOver100Dollars)
            {
                Console.WriteLine($"Customer {i.CustomerNumber} made a purchase total of {i.SalesTotalAmount} on {i.SaleDate}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static void DisplayInventory(List<Volume> inventory)
        {
            foreach (var i in inventory)
            {
                Console.WriteLine("ISBN: {0} \n" +
                    "Condition code: {1} \n" +
                    "Date acquired: {2} \n" +
                    "Asking Price {3} \n" +
                    "Selling Price {4}", i.ISBN, i.ConditionCode, i.DateAcquired, i.AskingPrice, i.SellingPrice);
                Console.WriteLine();
            }
        }

        public static void DisplayCustomer(List<Customer> customers)
        {
            foreach (var i in customers)
            {
                Console.WriteLine("Customer Name: {0} {1} \n" +
                    "Address: {2} {3} \n" +
                    "Contact Number: {4}", i.FirstName, i.LastName,
                    i.Street, i.ZipCode, i.ContactPhone);
                Console.WriteLine();
            }
        }

        public static void DisplayCustomerContact(List<CustomerContactDTO> customerContact)
        {
            foreach (var i in customerContact)
            {
                Console.WriteLine("Customer: {0} {1} \n" +
                    "Contact Phone: {2}", i.FirstName, i.LastName, i.ContactPhone);
                Console.WriteLine();
            }
        }

        public static void DisplayCustomerServiceMessage()
        {
            
        }
        public static void MessagePrompt()
        {
            Console.WriteLine("Welcome to RareBookApp Portal!");
            Console.WriteLine("Please select your service inquiry below:");
            Console.WriteLine("1. Exit the app");
            Console.WriteLine("2. Customer service");
            Console.WriteLine("3. Inventory service");
            Console.WriteLine("4. Company's sales service");
            Console.Write("You need help with: ");
        }
    }
}
