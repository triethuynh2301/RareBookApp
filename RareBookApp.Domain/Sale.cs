using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Domain
{
    public class Sale
    {
        public int SaleID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public Decimal SalesTotalAmount { get; set; }
        public string CreditCardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Inverse navigation property to Customer (1-to-many)
        /// Each sale ticket can only belong to 1 customer
        /// </summary>
        public Customer Customer { get; set; }


    }
}
