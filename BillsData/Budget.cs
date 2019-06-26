using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace BillsData
{
    public class Budget
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public Nullable<int> TransactionCategoryID { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModyficationDate { get; set; }
        public int UserId { get; set; }

        public virtual IdentityUser User { get; set; }
        public virtual TransactionCategory TransactionCategory { get; set; }
    }
}
