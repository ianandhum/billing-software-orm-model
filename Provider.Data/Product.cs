using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Provider.Data
{
    [Table("Product")]
    public class Product
    {
        
        [Key]
        [ForeignKey("Stock")]
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
    }
}
