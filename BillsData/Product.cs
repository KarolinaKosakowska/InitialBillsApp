using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillsData
{
    public class Product
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Unit Unit { get; set; }

        public virtual ICollection<TransactionElement> TransactionElements { get; set; }
    }
    public enum Unit
    {
        szt,
        ml,
        kg,
        m
    }
}
