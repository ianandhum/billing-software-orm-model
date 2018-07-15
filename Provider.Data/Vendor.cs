using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
namespace Provider.Data
{
    public class Vendor
    {
        public Vendor()
        {
            this.Purchases = new HashSet<Purchase>();
        }


        [Column(IsPrimaryKey = true, Name = "VendorId", DbType = "INTEGER")]
        [Key]
        public int VendorId { get; set; }

        [Column(Name = "Name", DbType = "TEXT")]
        public string Name { get; set; }

        [Column(Name = "Email", DbType = "TEXT")]
        public string Email { get; set; }

        [Column(Name = "Telephone", DbType = "TEXT")]
        public string Telephone { get; set; }

        [Column(Name = "BillingAddress", DbType = "TEXT")]
        public string BillingAddress { get; set; }

        [Column(Name = "BillingZIP", DbType = "TEXT")]
        public string BillingZIP { get; set; }

        [Column(Name = "BillingCity", DbType = "TEXT")]
        public string BillingCity { get; set; }

        [Column(Name = "ShippingAddress", DbType = "TEXT")]
        public string ShippingAddress { get; set; }

        [Column(Name = "ShippingZIP", DbType = "TEXT")]
        public string ShippingZIP { get; set; }

        [Column(Name = "ShippingCity", DbType = "TEXT")]
        public string ShippingCity { get; set; }


        [Column(Name = "Details", DbType = "TEXT")]
        public string Details { get; set; }


        [Column(Name = "GSTIN", DbType = "TEXT")]
        public string GSTIN { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
