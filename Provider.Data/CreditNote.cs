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

        public DateTime IssueDate { get; set; }

        public int InvoiceId { get; set; }

        public CreditType Reason { get; set; }


        public Decimal TotalNoTax { get; set; }

        public Decimal TotalTax { get; set; }

        public Decimal Total { get; set; }
        
        public string InternalNote { get; set; }

        public string CreditNoteNote { set; get; }

        public int Deleted { get; set; }

      
        [Column(Name = "StockReturned", DbType = "INTEGER")]
        public int StockReturned { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual ICollection<CreditNoteProducts> Products { get; set; }


    }
}
