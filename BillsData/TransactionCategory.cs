using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillsData
{
    public class TransactionCategory
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
