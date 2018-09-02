using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
namespace Provider.Data
{
    [Table(Name="PurchasePayments")]
    public class PurchasePayments
    {
        [Column(IsPrimaryKey = true)]
        [Key]
        public int ID { get; set; }

        public int PaymentId { get; set; }

        public int PurchaseId { get; set; }

        public int PurchasereturnId { get; set; }

        public virtual Payment Payment { get; set; }

        public virtual Purchase Purchase  { get; set; }
    }
}
