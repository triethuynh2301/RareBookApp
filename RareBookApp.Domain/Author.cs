using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RareBookApp.Domain
{
    public class Author
    {
        [Key]
        public int AuthorNumber { get; set; }
        public string AuthorFirstLastName { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Navigation property for 1-to-many rel with Work
        /// </summary>
        public ICollection<Work> Works { get; set; }

    }
}
