using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Domain
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        [ForeignKey("Work")]
        public int WorkNumber { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherID { get; set; }
        public int Edition { get; set; }
        public string Binding { get; set; }
        public int CopyrightYear { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Inverse navigation property in a 1-to-many rel with Work
        /// </summary>
        public Work Work { get; set; }
        /// <summary>
        /// Inverse navigation property
        /// </summary>
        public Publisher Publisher { get; set; }
        /// <summary>
        /// Navigation property to Volume (1-to-many)
        /// Each book can have multiple inventory in warehouse
        /// </summary>
        public ICollection<Volume> Inventory { get; set; }
    }
}
