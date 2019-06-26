using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillsData
{
    public class PaymentType
    {
        public int ID { get; set; }
        public PaymentName PaymentName { get; set; }

        public virtual ICollection<Transaction> Trasnsactions { get; set; }
    }
    public enum PaymentName
    {
        Cash,
        Card,
        [Display(Name = "Bank transfer")]
        //[TypeConverter(typeof(PascalCaseWordSplittingEnumConverter))]
        BankTransfer
    }
}
