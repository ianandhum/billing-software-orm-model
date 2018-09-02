using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;

namespace Provider.Data
{
    [Table(Name ="Settings")]
    public class Settings
    {
        [Column(IsPrimaryKey =true)]
        [Key]
        public int ID { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }
    }
}
