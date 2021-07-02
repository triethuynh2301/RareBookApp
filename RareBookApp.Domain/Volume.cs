using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Domain
{
    public class Volume
    {
        [Key]
        public int InventoryID { get; set; }
        [ForeignKey("Book")]
        public string ISBN { get; set; }
        [ForeignKey("Condition")]
        public int ConditionCode { get; set; }
        public DateTime DateAcquired{ get; set; }
        public decimal AskingPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        [ForeignKey("SaleID")]
        public int? SaleID { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Inverse navigation property to Book (1-to-many)
        /// </summary>
        public Book Book { get; set; }
        /// <summary>
        /// Inverse navigation property (1-to-many)
        /// </summary>
        public ConditionCodes Condition { get; set; }
        /// <summary>
        /// Inverse navigation property to Sale (1-to-many)
        /// </summary>
        public ICollection<Sale> SaleTicket { get; set; }

    }
}
