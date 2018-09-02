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

        public int PaymentId { get; set; }

        public int InvoiceId { get; set; }

        public int? CreditNoteId { get; set; }

        public virtual Payment Payment { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
