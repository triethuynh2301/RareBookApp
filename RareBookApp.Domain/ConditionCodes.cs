using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RareBookApp.Domain
{
    public class ConditionCodes
    {
        [Key]
        public int ConditionCode { get; set; }
        public string ConditionDescription { get; set; }

        //------------------------------
        //Relationships

        /// <summary>
        /// Navigation property to Volume (1-to-many)
        /// </summary>
        public ICollection<Volume> Invetory { get; set; }
    }
}
