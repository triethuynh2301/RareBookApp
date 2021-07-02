using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Domain
{
    public class Customer
    {
        [Key]
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int ZipCode { get; set; }
        public string ContactPhone { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Navigation property to Customer (1-to-many)
        /// Each customer can make multiple purchases
        /// </summary>
        public IQueryable<Sale> Purchases { get; set; }
    }
}
