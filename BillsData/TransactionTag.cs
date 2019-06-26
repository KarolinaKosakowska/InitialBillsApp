using System;
using System.Collections.Generic;
using System.Text;

namespace BillsData
{
    public class TransactionTag
    {
        public string ID { get; set; }
        public int TransactionID { get; set; }
        public int TagID { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
