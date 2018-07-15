using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
namespace Provider.Data
{
    [Table(Name="PurchaseReturn")]
    public class PurchaseReturn
    {
        public PurchaseReturn()
        {
            Products = new HashSet<PurchaseReturnProducts>();
        }

        [Column(Name = "PurchaseReturnId", IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int PurchaseReturnId { get; set; }

        [Column(Name = "IssueDate", DbType = "TEXT")]
        public DateTime IssueDate { get; set; }

        [Column(Name = "PurchaseId", DbType = "INTEGER")]
        public int PurchaseId { get; set; }

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

        [Column(Name = "PurchaseNote", DbType = "TEXT")]
        public string PurchaseNote { set; get; }

        [Column(Name = "Deleted", DbType = "INTEGER")]
        public int Deleted { get; set; }


        [Column(Name = "StockReturned", DbType = "INTEGER")]
        public int StockReturned { get; set; }

        public virtual Purchase Purchase { get; set; }

        public virtual ICollection<PurchaseReturnProducts> Products { get; set; }



    }
}
