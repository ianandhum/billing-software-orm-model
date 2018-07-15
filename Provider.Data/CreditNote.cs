using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Provider.Data
{
    [Table(Name ="CreditNote")]
    public class CreditNote
    {
        public CreditNote()
        {
            Products = new HashSet<CreditNoteProducts>();
        } 

        [Column(Name ="CreditNoteId",IsPrimaryKey =true,DbType ="INTEGER")]
        [Key]
        public int CreditNoteId { get; set; }

        [Column(Name = "IssueDate", DbType = "TEXT")]
        public DateTime IssueDate { get; set; }

        [Column(Name = "InvoiceId", DbType = "INTEGER")]
        public int InvoiceId { get; set; }


        [Column(Name = "Reason", DbType = "INTEGER")]
        public CreditType Reason { get; set; }


        [Column(Name = "TotalNoTax", DbType = "NUMERIC")]
        public Decimal TotalNoTax { get; set; }

        [Column(Name = "TotalTax", DbType = "NUMERIC")]
        public Decimal TotalTax { get; set; }

        [Column(Name = "Total", DbType = "NUMERIC")]
        public Decimal Total { get; set; }


        [Column(Name = "InternalNote", DbType = "TEXT")]
        public string InternalNote { get; set; }

        [Column(Name = "CreditNoteNote", DbType = "TEXT")]
        public string CreditNoteNote { set; get; }

        [Column(Name = "Deleted", DbType = "INTEGER")]
        public int Deleted { get; set; }

      
        [Column(Name = "StockReturned", DbType = "INTEGER")]
        public int StockReturned { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual ICollection<CreditNoteProducts> Products { get; set; }


    }
}
