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

    [Table(Name = "InvoiceProducts")]
    public class InvoiceProducts
    {
        [Column(IsPrimaryKey = true)]
        [Key]
        public int ID { get; set; }

        public int ProductId { get; set; }

        public int InvoiceId { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public Measure MU { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public bool InclusiveTax { get; set; }

        public int TaxId { get; set; }

        public decimal TotalNoTax { get; set; }

        public decimal TotalTax { get; set; }

        public decimal Total { get; set; }

        public bool IsDiscount { get; set; }

        public Decimal DiscountPercent { get; set; }

        public String HSN { get; set; }

        public decimal CESSPercent { get; set; }

        public virtual Taxes Tax { get; set; }

        public Invoice Invoice { get; set; }
    }
}
