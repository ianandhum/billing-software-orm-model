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

    [Table(Name = "Taxes")]
    public class Taxes
    {
        public Taxes()
        {

        }
        [Column(IsPrimaryKey = true)]
        [Key]
        public int TaxId { get; set; }
        
        public string TaxName { get; set; }
        
        public Decimal Rate { get; set; }

        public bool IsDefault { get; set; }

        public bool Deleted { get; set; }



    }
}
