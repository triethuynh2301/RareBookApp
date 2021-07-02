using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Domain
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Navigation property to Book
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
