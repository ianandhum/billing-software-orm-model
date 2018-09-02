using System;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Provider.Data
{
    [Table(Name ="Stock")]
    public class Stock
    {

        [Column(IsPrimaryKey = true)]
        [Key]
        public int StockId { get; set; }

        public Decimal Quantity { get; set; }

        public bool Deleted { get; set; }

        public Decimal SoldQuantity { get; set; }

        public Decimal SoldTotalAmount { get; set; }

        public virtual Product Product { get; set; }


    }
}
