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
        
        [Column(Name = "PaymentId", IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int PaymentId { get; set; }

        [Column(Name = "Amount", DbType = "NUMERIC")]
        public Decimal Amount { get; set; }

        [Column(Name = "Type", DbType = "INTEGER")]
        public PaymentType Type { get; set; }

        [Column(Name = "PayDate", DbType = "TEXT")]
        public DateTime PayDate { get; set; }

        [Column(Name = "Flow", DbType = "INTEGER")]
        public CashFlow Flow { get; set; }


        [Column(Name = "Deleted", DbType = "INTEGER")]
        public int Deleted { get; set; }

        public virtual ICollection<InvoicePayments> InvoicePayments { get; set; }
        public virtual ICollection<PurchasePayments> PurchasePayments { get; set; }
    }
}
