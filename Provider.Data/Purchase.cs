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


        [Column(IsPrimaryKey = true, Name = "PurchaseId", DbType = "INTEGER")]
        [Key]
        public int PurchaseId { get; set; }

        [Column(Name = "VendorId", DbType = "INTEGER")]
        public int VendorId { get; set; }

        [Column(Name = "IssueDate", DbType = "TEXT")]
        public DateTime IssueDate { get; set; }

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

        [Column(Name = "PurcahseNote", DbType = "TEXT")]
        public string PurchaseNote { get; set; }

        [Column(Name = "Deleted", DbType = "INTEGER")]
        public bool Deleted { get; set; }

        [Column(Name = "Discount", DbType = "NUMERIC")]
        public Decimal Discount { get; set; }

        [Column(Name = "RoundedOff", DbType = "NUMERIC")]
        public Decimal RoundedOff { get; set; }

        [Column(Name = "Cancelled", DbType = "INTEGER")]
        public bool Cancelled { get; set; }

        public virtual ICollection<PurchaseProducts> Products { get; set; }

        public virtual ICollection<PurchasePayments> Payments { get; set; }

        public virtual ICollection<PurchaseReturn> Returns { get; set; }



        public virtual Vendor Vendor { get; set; }
    }
}
