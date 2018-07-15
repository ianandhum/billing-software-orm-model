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
        [Column(IsPrimaryKey = true, Name = "ID", DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "ProductId", DbType = "INTEGER",CanBeNull =false)]
        public int ProductId { get; set; }

        [Column(Name = "InvoiceId", DbType = "INTEGER",CanBeNull =false)]
        public int InvoiceId { get; set; }

        [Column(Name = "Name", DbType = "TEXT")]
        public String Name { get; set; }

        [Column(Name = "Description", DbType = "TEXT")]
        public String Description { get; set; }

        [Column(Name = "MU", DbType = "TEXT")]
        public String MU { get; set; }

        [Column(Name = "Price", DbType = "NUMERIC")]
        public Nullable<float> Price { get; set; }

        [Column(Name = "Quantity", DbType = "NUMERIC")]
        public Nullable<float> Quantity { get; set; }

        [Column(Name = "InclusiveTax", DbType = "INTEGER")]
        public Nullable<int> InclusiveTax { get; set; }

        [Column(Name = "TaxId", DbType = "INTEGER")]
        public int TaxId { get; set; }


        [Column(Name = "TotalNoTax", DbType = "NUMERIC")]
        public Nullable<float> TotalNoTax { get; set; }

        [Column(Name = "TotalTax", DbType = "NUMERIC")]
        public Nullable<float> TotalTax { get; set; }

        [Column(Name = "Total", DbType = "NUMERIC")]
        public Nullable<float> Total { get; set; }


        [Column(Name = "IsDiscount", DbType = "INTEGER")]
        public bool IsDiscount { get; set; }

        [Column(Name = "DiscountPercent", DbType = "NUMERIC")]
        public float DiscountPercent { get; set; }

        [Column(Name = "HSN", DbType = "TEXT")]
        public String HSN { get; set; }

        [Column(Name = "CESSPercent", DbType = "NUMERIC")]
        public float CESSPercent { get; set; }

        public Invoice Invoice { get; set; }
    }
}
