using Provider.Data.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
namespace Provider.Data
{
    public class Product:NotifyUIBase
    {
        


        [Column(IsPrimaryKey = true)]
        [Key]
        public int ProductId { get; set; }

        private string _Name { get; set; }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }


        private string _Description { get; set; }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                RaisePropertyChanged("Description");
            }
        }



        private Measure _MU { get; set; }

        public Measure MU
        {
            get
            {
                return _MU;
            }
            set
            {
                _MU = value;
                RaisePropertyChanged("MU");
            }
        }



        private Decimal _Price { get; set; }

        public Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
                RaisePropertyChanged("Price");
            }
        }

        private int _TaxId;

        public int TaxId {
            get
            {
                return _TaxId;
            }
            set {
                _TaxId = value;
                RaisePropertyChanged("TaxId");
                RaisePropertyChanged("Taxes");
            }
        }



        private bool _TaxIncluded { get; set; }

        public bool TaxIncluded
        {
            get
            {
                return _TaxIncluded;
            }
            set
            {
                _TaxIncluded = value;
                RaisePropertyChanged("TaxIncluded");
            }
        }

        public bool Deleted { get; set; }



        private Decimal _PurchaseRate { get; set; }

        public Decimal PurchaseRate
        {
            get
            {
                return _PurchaseRate;
            }
            set
            {
                _PurchaseRate = value;
                RaisePropertyChanged("PurchaseRate");
            }
        }



        private string _HSN { get; set; }

        public string HSN
        {
            get
            {
                return _HSN;
            }
            set
            {
                _HSN = value;
                RaisePropertyChanged("HSN");
            }
        }



        private  Decimal _CESSPercent { get; set; }

        public Decimal CESSPercent
        {
            get
            {
                return _CESSPercent;
            }
            set
            {
                _CESSPercent = value;
                RaisePropertyChanged("CESSPercent");
            }
        }


        public virtual Stock Stock { get; set; }

        public virtual Taxes Taxes { get; set; }
    }
}
