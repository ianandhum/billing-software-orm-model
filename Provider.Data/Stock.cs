using System;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Provider.Data
{
    [Table(Name ="Stock")]
    public class Stock
    {

        [Column(Name = "StockId", IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int StockId { get; set; }

        [Column(Name = "Quantity", DbType = "NUMERIC")]
        public Decimal Quantity { get; set; }

        [Column(Name = "Deleted", DbType = "INTEGER")]
        public bool Deleted { get; set; }

        [Column(Name = "SoldQuantity", DbType = "NUMERIC")]
        public Decimal SoldQuantity { get; set; }

        [Column(Name = "SoldTotalAmount", DbType = "INTEGER")]
        public Decimal SoldTotalAmount { get; set; }

        public virtual Product Product { get; set; }


    }
}
