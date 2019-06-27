using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillsApplication.Models.TransactionForm
{
    public class DetailsModel
    {
        public int ID { get; set; }
        public string TransactionCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Price { get; set; }
        public string PaymentType { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModyficationDate { get; set; }
        public string TransactionTags { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
        public int Unit { get; set; }
        public string Attachment { get; set; }


    }
}
