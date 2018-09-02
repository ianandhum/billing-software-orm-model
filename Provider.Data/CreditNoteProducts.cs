﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
namespace Provider.Data
{
    [Table(Name = "CreditNoteProducts")]
    public class CreditNoteProducts
    {
        [Column(IsPrimaryKey = true, Name = "ID", DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        public int ProductId { get; set; }

        public int CreditNoteId { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public String MU { get; set; }

        public Nullable<Decimal> Price { get; set; }

        public Nullable<Decimal> Quantity { get; set; }

        public Nullable<int> InclusiveTax { get; set; }

        public int TaxId { get; set; }
        
        public Nullable<Decimal> TotalNoTax { get; set; }

        public Nullable<Decimal> TotalTax { get; set; }

        public Nullable<Decimal> Total { get; set; }
        
        public int IsDiscount { get; set; }

        public Decimal DiscountPercent { get; set; }

        public String HSN { get; set; }

        public Decimal CESSPercent { get; set; }

        public CreditNote CreditNote { get; set; }
    }
}
