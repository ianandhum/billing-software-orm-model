using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
namespace Provider.Data
{   

    public class Purchase
    {

        public Purchase()
        {
            this.Products = new HashSet<PurchaseProducts>();

            this.Payments = new HashSet<PurchasePayments>();
        }

        [Key]
        [Column(IsPrimaryKey = true)]
        public int PurchaseId { get; set; }

        public int VendorId { get; set; }

        public DateTime IssueDate { get; set; }

        public bool IsPaid { get; set; }

        public Decimal TotalNoTax { get; set; }

        public Decimal TotalTax { get; set; }

        public Decimal Total { get; set; }

        public string InternalNote { get; set; }

        public string PurchaseNote { get; set; }

        public bool Deleted { get; set; }

        public Decimal Discount { get; set; }

        public Decimal RoundedOff { get; set; }

        public bool Cancelled { get; set; }

        public virtual ICollection<PurchaseProducts> Products { get; set; }

        public virtual ICollection<PurchasePayments> Payments { get; set; }

        public virtual ICollection<PurchaseReturn> Returns { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
