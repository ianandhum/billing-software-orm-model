using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Text;

namespace Provider.Data
{
    [Table(Name = "Payment")]
    public class Payment
    {
        public Payment()
        {
            this.InvoicePayments = new HashSet<InvoicePayments>();
            this.PurchasePayments = new HashSet<PurchasePayments>();
        }
        
        [Column(IsPrimaryKey = true)]
        [Key]
        public int PaymentId { get; set; }

        public Decimal Amount { get; set; }

        public PaymentType Type { get; set; }

        public DateTime PayDate { get; set; }

        public CashFlow Flow { get; set; }

        public int Deleted { get; set; }

        public virtual ICollection<InvoicePayments> InvoicePayments { get; set; }
        public virtual ICollection<PurchasePayments> PurchasePayments { get; set; }
    }
}
