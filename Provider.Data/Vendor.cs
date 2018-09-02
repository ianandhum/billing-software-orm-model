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

        [Column(IsPrimaryKey = true)]
        [Key]
        public int VendorId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string BillingAddress { get; set; }

        public string BillingZIP { get; set; }

        public string BillingCity { get; set; }

        public string ShippingAddress { get; set; }

        public string ShippingZIP { get; set; }

        public string ShippingCity { get; set; }

        public string Details { get; set; }

        public string GSTIN { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
