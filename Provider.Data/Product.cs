using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
namespace Provider.Data
{
    public class Product
    {
        


        [Column(IsPrimaryKey = true)]
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public Measure MU { get; set; }

        public Decimal Price { get; set; }
        
        public int TaxId { get; set; }
        
        public bool TaxIncluded { get; set; }
        
        public bool Deleted { get; set; }
        
        public Decimal PurchaseRate { get; set; }
        
        public string HSN { get; set; }
        
        public Decimal CESSPercent { get; set; }


        public virtual Stock Stock { get; set; }

        public virtual Taxes Taxes { get; set; }
    }
}
