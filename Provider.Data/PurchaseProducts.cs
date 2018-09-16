using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
namespace Provider.Data
{
    [Table(Name="PurchaseProducts")]
    public class PurchaseProducts
    {
        [Column(IsPrimaryKey = true, Name = "ID", DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        public int ProductId { get; set; }

        public int PurchaseId { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public Measure MU { get; set; }

        public Decimal Price { get; set; }

        public Decimal Quantity { get; set; }

        public bool InclusiveTax { get; set; }

        public int TaxId { get; set; }

        public Decimal TotalNoTax { get; set; }

        public Decimal TotalTax { get; set; }

        public Decimal Total { get; set; }

        public bool IsDiscount { get; set; }

        public Decimal DiscountPercent { get; set; }

        public String HSN { get; set; }

        public Decimal CESSPercent { get; set; }

        public Purchase Purchase { get; set; }

        public Taxes Tax { get; set; }
    }
}
