using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
namespace Provider.Data
{
    [Table(Name ="InvoicePayments")]
    public class InvoicePayments
    {
        [Column(Name ="ID" , IsPrimaryKey =true,DbType ="INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "PaymentId", DbType = "INTEGER")]
        public int PaymentId { get; set; }

        [Column(Name = "InvoiceId", DbType = "INTEGER")]
        public int InvoiceId { get; set; }

        [Column(Name = "CreditNoteId", DbType = "INTEGER")]
        public Nullable<int> CreditNoteId { get; set; }

        public virtual Payment Payment { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
