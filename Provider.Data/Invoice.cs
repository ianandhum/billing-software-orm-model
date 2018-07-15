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

        [Column(Name = "ClientId", DbType = "INTEGER")]
        public int ClientId { get; set; }

        [Column(Name = "IssueDate", DbType = "TEXT")]
        public DateTime IssueDate { get; set; }

        [Column(Name = "DueDate", DbType = "TEXT")]
        public DateTime DueDate { get; set; }

        [Column(Name = "IsPaid", DbType = "INTEGER")]
        public bool IsPaid { get; set; }

        [Column(Name = "TotalNoTax", DbType = "NUMERIC")]
        public Decimal TotalNoTax { get; set; }

        [Column(Name = "TotalTax", DbType = "NUMERIC")]
        public Decimal TotalTax { get; set; }

        [Column(Name = "Total", DbType = "NUMERIC")]
        public Decimal Total { get; set; }

        [Column(Name = "InternalNote", DbType = "TEXT")]
        public string InternalNote { get; set; }

        [Column(Name = "InvoiceNote", DbType = "TEXT")]
        public string InvoiceNote { get; set; }

        [Column(Name = "Deleted", DbType = "INTEGER")]
        public bool Deleted { get; set; }

        [Column(Name = "Discount", DbType = "NUMERIC")]
        public Decimal Discount { get; set; }

        [Column(Name = "RoundedOff", DbType = "NUMERIC")]
        public Decimal RoundedOff { get; set; }

        [Column(Name = "Cancelled", DbType = "INTEGER")]
        public bool Cancelled { get; set; }

        public virtual ICollection<InvoiceProducts> Products { get; set; }

        public virtual ICollection<InvoicePayments> Payments { get; set; }

        public virtual ICollection<CreditNote> CreditNotes { get; set; }

        public virtual Client Client { get; set; }


    }
}
