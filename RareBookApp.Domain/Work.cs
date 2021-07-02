using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Domain
{
    /// <summary>
    /// Work is a dependant property in a 1-to-many rel with Author.
    /// Each author must has at least 1 or more works, but each work
    /// belongs to only 1 author
    /// </summary>
    public class Work
    {
        [Key]
        public int WorkNumber { get; set; }
        [ForeignKey("Author")]
        public int AuthorNumber { get; set; }
        public string Title { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Inverse navigation property in 1-to-many rel with Author
        /// </summary>
        public Author Author { get; set; }
        /// <summary>
        /// Navigation property in a 1-to-many rel with Book
        /// </summary>
        public ICollection<Book> Books { get; set; }


    }
}
