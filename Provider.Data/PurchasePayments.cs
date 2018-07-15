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
        [Column(Name = "ID", IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "PaymentId", DbType = "INTEGER")]
        public int PaymentId { get; set; }

        [Column(Name = "PurchaseId", DbType = "INTEGER")]
        public int PurchaseId { get; set; }

        [Column(Name = "PurchaseReturnId", DbType = "INTEGER")]
        public int PurchasereturnId { get; set; }

        public virtual Payment Payment { get; set; }

        public virtual Purchase Purchase  { get; set; }
    }
}
