using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillsData
{
    public class Tag
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<TransactionTag> TransactionTags { get; set; }
    }
}
