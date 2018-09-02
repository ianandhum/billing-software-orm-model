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

        [Column(IsPrimaryKey = true)]
        [Key]
        public int PurchaseReturnId { get; set; }

        public DateTime IssueDate { get; set; }

        public int PurchaseId { get; set; }

        public CreditType Reason { get; set; }

        public Decimal TotalNoTax { get; set; }

        public Decimal TotalTax { get; set; }

        public Decimal Total { get; set; }

        public string InternalNote { get; set; }

        public string PurchaseNote { set; get; }

        public int Deleted { get; set; }

        public int StockReturned { get; set; }

        public virtual Purchase Purchase { get; set; }

        public virtual ICollection<PurchaseReturnProducts> Products { get; set; }

    }
}
