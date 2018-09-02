using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Provider.Data
{
   
    [Table(Name ="Invoice")]
    public class Invoice
    {
        public Invoice()
        {
            Products = new HashSet<InvoiceProducts>();
            Payments = new HashSet<InvoicePayments>();
        }
        

        [Column(IsPrimaryKey = true, Name = "InvoiceId", DbType = "INTEGER")]
        [Key]
        public int InvoiceId { get; set; }
        
        public int ClientId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsPaid { get; set; }

        public Decimal SubTotal { get; set; }

        public Decimal TotalTax { get; set; }
        
        public Decimal Total { get; set; }

        public string InternalNote { get; set; }

        public string InvoiceNote { get; set; }

        public bool Deleted { get; set; }

        public Decimal Discount { get; set; }

        public Decimal RoundedOff { get; set; }

        public Decimal ShippingCharge { get; set; }

        public bool Cancelled { get; set; }

        public virtual ICollection<InvoiceProducts> Products { get; set; }

        public virtual ICollection<InvoicePayments> Payments { get; set; }

        public virtual ICollection<CreditNote> CreditNotes { get; set; }

        public virtual Client Client { get; set; }


    }
}
