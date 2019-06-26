using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillsData
{
    public class Transaction
    {
        [Required]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> TransactionCategoryID { get; set; }
        [Required]
        [Display(Name = "Transaction date")]
        public DateTime TransactionDate { get; set; }
        [Required]
        [Display(Name = "Create date")]
        public DateTime CreateDate { get; set; }
        [Required]
        [Display(Name = "Modyfication date")]
        public DateTime ModyficationDate { get; set; }
        [Required]
        public decimal Price { get; set; }

      
        public Nullable<int> PaymentTypeID { get; set; }
        public virtual TransactionCategory TransactionCategory { get; set; }
        public virtual IdentityUser User { get; set; }
  
        [Display(Name = "Payment type")]
        public virtual PaymentType PaymentType { get; set; }
        public virtual ICollection<TransactionTag> TransactionTags { get; set; }
        public virtual ICollection<TransactionElement> TransactionElements { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}
