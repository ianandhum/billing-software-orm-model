using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Provider.Data
{
    [Table(Name = "Client")]
    public class Client
    {
        public Client()
        {
            this.Invoices = new HashSet<Invoice>();
        }


        [Column(IsPrimaryKey = true, Name = "ClientId", DbType = "INTEGER")]
        [Key]
        public int ClientId { get; set; }

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

        public virtual ICollection<Invoice> Invoices { get; set; }


    }
}
